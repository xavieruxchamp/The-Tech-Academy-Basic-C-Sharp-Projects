using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace FinalAssignmenModule12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the last name:");
            string lastName = Console.ReadLine();

            using (var context = new newDbContext())
            {
                var student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName
                };

                context.People.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student saved to the database.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    // Define your entity class representing a student
    [Table("Students")] // Explicitly specify the table name
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // Define your DbContext class
    public class newDbContext : DbContext
    {
        public newDbContext() : base("name=newDbContext") // Specify the connection string name
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<newDbContext>()); // DB Initialization: Create the database if it doesn't exist
        }

        public DbSet<Student> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Code-First Conventions: Customize mappings and configurations
            modelBuilder.Entity<Student>()
                .Property(s => s.FirstName)
                .IsRequired(); // Set the FirstName property as required

            modelBuilder.Entity<Student>()
                .Property(s => s.LastName)
                .HasMaxLength(50); // Set the maximum length of LastName to 50 characters

            base.OnModelCreating(modelBuilder);
        }
    }
}
