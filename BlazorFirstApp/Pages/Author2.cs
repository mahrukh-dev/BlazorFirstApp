namespace BlazorFirstApp.Pages
{
    public class Author2
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string EmailAddress { get; set; }
        public int Salary { get; set; }
        public string Phone { get; set; }

        public Author2()
        {

        }

        public Author2(int authorID, string firstName, string lastName, string city, string emailAddress, int salary, string phoneNumber)
        {
            AuthorID = authorID;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            EmailAddress = emailAddress;
            Salary = salary;
            Phone = phoneNumber;
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
