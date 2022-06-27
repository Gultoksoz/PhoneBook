using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phonebook.Models
{
    public class DataAccess
    {
        private PhonebookContext db = new PhonebookContext();

        public List<Record> GetAll()
        {
            var result = db.Records.ToList();
            return result;
        }

        public Record Edit(String id)
        {
            var result = db.Records.Where(contact => contact.Phone == id).SingleOrDefault();

            return result;
        }

        public void Delete(String id)
        {
            var result = db.Records.Where(contact => contact.Phone == id).SingleOrDefault();
            db.Records.Remove(result);
            db.SaveChanges();

        }


        public void Create(Record record)
        {
            Record contact = new Record();
            contact.Name = record.Name;
            contact.LastName = record.LastName;
            contact.Phone = record.Phone;
            db.Records.Add(contact);
            db.SaveChanges();

        }
    }
}