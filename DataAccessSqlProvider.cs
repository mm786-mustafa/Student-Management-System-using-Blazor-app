﻿using VP_Lab_8.Server.DataAccess;
using VP_Lab_8.Shared.Models;

namespace VP_Lab_8.Server.DataAccess
{
    public class DataAccessSqlProvider : IDataAccessProvider
    {
        private readonly DomainModelSqlContext _context;

        public DataAccessSqlProvider(DomainModelSqlContext context)
        {
            _context = context;
        }

        public void AddClientRecord(Persons person)
        {
            _context.Info.Add(person);
            _context.SaveChanges();
        }

		public void UpdateClientRecord(Persons person)
		{
			_context.Info.Update(person);
			_context.SaveChanges();
		}

		public void DeleteClientRecord(int id)
		{
            var entity = _context.Info.First(t => t.Id == id);
			_context.Info.Remove(entity);
			_context.SaveChanges();
		}

        public Persons GetClientRecord(int id)
        {
            return _context.Info.First(t =>t.Id == id);
        }

        public List<Persons> GetClientRecords()
        {
            return _context.Info.ToList();
        }
	}
}
