using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using SomeTasks.Models4.Interfaces;
using SomeTasks.Models4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace SomeTasks.Models4.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;



        [HttpPost("registration")]
        public async Task<ActionResult<UserInformation>> Register(UserIdentity userIdentity)//ActionResult - ответ на HttpPost
        {
            UserInformation userInformation = await _userService.RegisterWithPhone(userIdentity.NumberPrefix, userIdentity.Number, userIdentity.Password);

            return await ConvertToUserInformationAsync(userInformation);
        }

        private async Task<UserInformation> ConvertToUserInformationAsync(UserInformation userInformation)
        {
            if (userInformation == null) throw new ArgumentNullException(nameof(userInformation));

            UserInformation userInformationDto = _mapper.Map<UserInformation>(userInformation);

            return userInformationDto;

        }
    }
}
