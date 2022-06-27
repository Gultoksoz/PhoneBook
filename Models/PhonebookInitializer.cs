using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Phonebook.Models
{
    public class PhonebookInitializer:DropCreateDatabaseIfModelChanges<PhonebookContext>
    {
        protected override void Seed(PhonebookContext context)
        {
            List<Record> records = new List<Record>()
            {
                new Record() { Name="Sevde", LastName="Toksoz", Phone="05052309522"},
                new Record() {Name="Kerem", LastName="Can", Phone="05376958412"}
            };

            foreach (var item in records)
            {
                context.Records.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}