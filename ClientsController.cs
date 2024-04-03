using VP_Lab_8.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace VP_Lab_8.Server.Controllers
{
	public class ClientsController : Controller
	{
		private readonly IDataAccessProvider _dataAccessProvider;

		public ClientsController(IDataAccessProvider dataAccessProvider)
		{
			_dataAccessProvider = dataAccessProvider;
		}

		[HttpGet]
		[Route("api/Clients/Get")]
		public IEnumerable<Persons> Get()
		{
			return _dataAccessProvider.GetClientRecords();
		}

		[HttpPost]
		[Route("api/Clients/Create")]
		public void Create([FromBody] Persons person)
		{
			if(ModelState.IsValid)
			{
				_dataAccessProvider.AddClientRecord(person);
			}
		}

		[HttpGet]
		[Route("api/Clients/Details/{id}")]
		public Persons Details(int id)
		{
			return _dataAccessProvider.GetClientRecord(id);
		}

		[HttpPut]
		[Route("api/Clients/Edit")]
		public void Edit([FromBody] Persons person)
		{
			if(ModelState.IsValid) 
			{
				_dataAccessProvider.UpdateClientRecord(person);
			}
		}

		[HttpDelete]
		[Route("api/Clients/Delete/{id}")]
		public void DeleteConfirmed(int id)
		{
			_dataAccessProvider.DeleteClientRecord(id);
		}
	}
}
