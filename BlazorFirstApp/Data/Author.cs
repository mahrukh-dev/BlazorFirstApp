using BlazorFirstApp.Pages;
using System.Numerics;

namespace BlazorFirstApp.Data
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string EmailAddress { get; set; }
        public int Salary { get; set; }
        public string Phone { get; set; }
        public Author()
        {

        }
        public Author(int authorID, string firstName, string lastName, string emailAddress, int salary,
                    string phoneNumber, string city)
        {
            AuthorID = authorID;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            EmailAddress = emailAddress;
            Phone = phoneNumber;
            City = city;
        }

        public void clear()
        {
            AuthorID = 0;
            FirstName = "";
            LastName = "";
            Salary = 0;
            EmailAddress = "";
            Phone = "";
            City = "";
        }
    }
}
