using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Phonebook.Models
{
    public class PhonebookContext : DbContext
    {
        public PhonebookContext():base("phonebookConnection")
        {
            Database.SetInitializer(new PhonebookInitializer());
        }

        public DbSet<Record> Records { get; set; }
    }
}