using EntutyFrameworkDemo.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EntutyFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ctx = new SoftUniContext();

            Console.WriteLine(UpdateAddresses(ctx));
            //CreateNewProject(ctx);

        }
        public static string FindEmployeesWithJobTitele(SoftUniContext context)
        {
            var result = context.Employees
                .Where(e => e.JobTitle == "Design Engineer")
                .Select(x => x.FirstName)
                .ToList();

            return string.Join(Environment.NewLine, result);
        }
        public static string FindProjectWithID(SoftUniContext ctx)
        {
            Project project = ctx.Projects.Find(2);
            return project.Name;
        }

        public static void CreateNewProject(SoftUniContext ctx)
        {
            Project project = new Project()
            {
                Name = "Test",
                StartDate = DateTime.Now,
                Description = "Test"
            };
            ctx.Projects.Add(project);
            ctx.SaveChanges();
        }

        public static string UpdateFirstEmployee(SoftUniContext ctx)
        {
            var employee = ctx.Employees.FirstOrDefault();
            if(employee.FirstName != null)
            {
                employee.FirstName = "Alex";
                ctx.SaveChanges();
                return employee.FirstName;
            }
            return "";
        }

        public static string UpdateAddresses(SoftUniContext ctx)
        {
            //List<Address> AddressText = ctx.Addresses.Where(a => a.AddressText.Contains("Drive")).Where(x => x.TownId.Value = 2).ToList();
            //foreach (var address in AddressText)
            //{
            //    address.TownId = 2;
            //}
            //ctx.SaveChanges();
            //return AddressText.Count().ToString();

            var updatedCount = ctx.Addresses
            .Where(a => a.AddressText.Contains("Drive"))
            .ExecuteUpdate(setters => setters.SetProperty(a => a.TownId, 2));

            return updatedCount.ToString();
        }
    }
}