using System.Collections.Generic;
using WardrobeCloud.Roles.Dto;
using WardrobeCloud.Users.Dto;

namespace WardrobeCloud.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
