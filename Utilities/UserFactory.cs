namespace Homework
{
    public static class UserFactory
    {
        public static RegistrationUser CreateValidUser()
        {
            return new RegistrationUser
            {
                FirstName = "Jenny",
                LastName = "Johnson",
                Year = "1990",
                Month = "3",
                Date = "3",
                RealFirstName = "Jennifer",
                RealLastName = "Johnson",
                Password = "gdsjafgujdsw",
                Gender = "female",
                PostCode = "85001",
                Address="Neshto",
                City="Minneapolis",
                State="Minnesota",
                Phone="5555555555",
                Alias="Test"
            };
        }
    }
}
