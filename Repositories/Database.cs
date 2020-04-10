using LiteDB;
using easycontacts.Models;
using System.Linq;
using System.Collections.Generic;

namespace easycontacts.Repositories
{
    public class Database : IDatabase
    {
        private static LiteDatabase database;
        public Database()
        {
            database = new LiteDatabase("Database.db");
        }

        public IEnumerable<Contact> FindAll()
        {
            return database.GetCollection<Contact>().FindAll();
        }
    
        public Contact FindOne(int id)
        {
            return database.GetCollection<Contact>().Find(x => x.Id == id).FirstOrDefault();
        }
    
        // public int Insert(Contact contact)
        // {
        //     return database.GetCollection<Contact>().Insert(contact);
        // }
    
        // public bool Update(Contact contact)
        // {
        //     return database.GetCollection<Contact>().Update(contact);
        // }
    
        public bool Delete(int id)
        {
            var contact = database.GetCollection<Contact>().Find(x => x.Id == id).FirstOrDefault();
            contact.IsDeleted = true;
            return Upsert(contact);
        }

        public bool Upsert(Contact contact)
        {
            return database.GetCollection<Contact>().Upsert(contact);
        }
    }
}
