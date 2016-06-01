using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _2_WebForms_BusinessCard.Entities
{
    public class CompanyDbInitializer: DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed ( CompanyContext db )
        {
            db.Employees.Add ( new Employee { Name = "Vasya", Department = "Management", Position = "General Manager", Salary = 25000 } );
            db.Employees.Add ( new Employee { Name = "Fedya", Department = "Production", Position = "Worker", Salary = 3000 } );
            db.Employees.Add ( new Employee { Name = "Bill", Department = "Security", Position = "BodyGuard", Salary = 5000 } );
            db.Employees.Add ( new Employee { Name = "John", Department = "Human Resource", Position = "Hirer", Salary = 4000 } );
            db.Employees.Add ( new Employee { Name = "Bob", Department = "Management", Position = "Counter", Salary = 15000 } );
            
            db.Messages.Add ( new Message { Login = "login", Email = "email@email.com", Date = DateTime.Now, Content = "text text ..." } );

            base.Seed ( db );
        }
    }
}