using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Lab_8.Shared.Models
{
    public interface IDataAccessProvider
    {
        void AddClientRecord(Persons person);
        void UpdateClientRecord(Persons person);
        void DeleteClientRecord(int Id);
        Persons GetClientRecord(int Id);
        List<Persons> GetClientRecords();
    }
}
