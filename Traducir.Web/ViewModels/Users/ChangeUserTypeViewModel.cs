using Traducir.Core.Models.Enums;

namespace Traducir.Web.ViewModels.Users
{
    public class ChangeUserTypeViewModel
    {
        public int UserId { get; set; }

        public UserType UserType { get; set; }
    }
}