using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost("registration")]
        public async Task<ActionResult<UserInformation>> Register(UserIdentity userIdentity)//ActionResult - ответ на HttpPost
        {
            UserInformation userInformation = await _userService.RegisterWithPhone(userIdentityDto.NumberPrefix, userIdentityDto.Number, userIdentityDto.Password);

            return await ConvertToUserInformationAsync(userInformationBlo);
        }
    }
}
