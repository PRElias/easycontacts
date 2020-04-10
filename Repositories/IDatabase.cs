using System.Collections.Generic;
using easycontacts.Models;

namespace easycontacts.Repositories
{
    public interface IDatabase
    {
        IEnumerable<Contact> FindAll();
        Contact FindOne(int id);
        int Insert(Contact contact);
        bool Update(Contact contact);
        bool Delete(int id);
    }
}
