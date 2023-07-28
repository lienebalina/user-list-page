using user_list_page.Services;

namespace user_list_page.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string FullName => FirstName + " " + LastName;
        public int Age => UserService.CalculateAge(DateOfBirth);
    }

    /*
     * <td>
                    @Html.DisplayFor(modelItem => item.Age)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.Action)
                </td>
     */
}
