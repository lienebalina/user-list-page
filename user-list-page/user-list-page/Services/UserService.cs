using user_list_page.Models;

namespace user_list_page.Services
{
    public class UserService : IUserService
    {
        private User _user;

        public UserService(User user)
        {
            _user = user;
        }
        public static int CalculateAge(DateTime dateOfBirth)
        {
            var month = DateTime.Now.Month - dateOfBirth.Month;

            var day = DateTime.Now.Day - dateOfBirth.Day;

            var age = 0;

            if (month < 0)
            {
                age = DateTime.Now.Year - dateOfBirth.Year - 1;
            } 
            else if (month == 0)
            {
                if (day < 0)
                {
                    age = DateTime.Now.Year - dateOfBirth.Year - 1;
                }

                if (day >= 0)
                {
                    age = DateTime.Now.Year - dateOfBirth.Year;
                }
            }
            else
            {
                age = DateTime.Now.Year - dateOfBirth.Year;
            }

            return age;
        }
    }
}
