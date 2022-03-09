using Business.CenterManagment.IServices;
using Business.Common.IServices;
using Business.Common.Models;
using Core.His.Models;
using DataAccess.Entities.His.HisEntities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PortalHisApi.Controllers
{
    
    [Route("api/[controller]/[action]")]
    [ApiController]
 
    public class AuthController : ControllerBase
    {
        private IConfiguration _config;
        IAccountService accountService;
        IPatientService patientService;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        public AuthController(IConfiguration config,
            IAccountService accountService,IPatientService patientService, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _config = config;
            this.accountService = accountService;
            this.patientService = patientService;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

       
     
        [HttpPost]
        
        public async Task<ResponseResult> Login(UserModel login)
        {
            var result = await accountService.Login(login);
            return result;
           
        }

        [AllowAnonymous]
        [Authorize(Roles = "User")]
        [HttpPost]

        public async Task<ResponseResult> LoginPatient(UserModel login)
        {
 
         //   var result =new ResponseResult { Status = ResponseStatus.Fail, Message = "Username or password is incorrect" };

          //  var loginPatient = await signInManager.PasswordSignInAsync(login.UserName, login.Password, true, true);
          //  if (loginPatient.Succeeded)
            var  result = await patientService.LoginPatient(login);

            return result;


        }

 

        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterModel register)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserName = register.MobileNumber,
                    PhoneNumber = register.MobileNumber,
                };
                var result = await userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                    return Ok(result);
                else
                {
                    foreach (var err in result.Errors)
                    {
                        ModelState.AddModelError(String.Empty, err.Description);
                    }
                    return BadRequest(register);
                }
                
            }
            return BadRequest(new { message = "Somthing Bad Happend" });
        }
        //[HttpGet]
        //public IActionResult LoginUser()
        //{

        //}

        [HttpPost]
        public async Task<IActionResult> LoginUser([FromBody] LoginModel login)
        {
            if (ModelState.IsValid)
            {
               
               
                    var result = await signInManager.PasswordSignInAsync(login.MobileNumber, login.Password, login.RememberMe, true);
                    if (result.Succeeded)
                        return Ok();
 

            }
            else
            {
                ModelState.AddModelError(String.Empty, "Invalid Login Attemp.");
            }
            return BadRequest(login);
        }


        [HttpGet]
        public async Task<IActionResult> LoginUser()
        {
            if (!signInManager.IsSignedIn(User))
                return Ok();

            var model = new LoginModel()
            {
                ReturnUrl = "",
                ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()

            };
            return Ok(model);

         }

        [HttpPost]
        public async Task<IActionResult> LogoutUser()
        {
            await signInManager.SignOutAsync();
            return Ok();
        }

         public IActionResult AddUser([FromBody] UserModel addUser)
        {
 

            var user = accountService.AddUser(addUser);

            if (user != null)
            {
                //  user.Token = GenerateJSONWebToken(user);

                return Ok(user);
            }

              return BadRequest(new ResponseResult
            {
                Status = ResponseStatus.Fail,
                Message = "Somthing bad happend.",
                Data = new
                {
                    data = false
                }
            }
            );
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> IsPhoneInUse(string phone)
        //{
        //    var user = await userManager.FindByNameAsync(phone);
        //    if (user == null) return Ok(new ResponseResult
        //    {
        //        Status = ResponseStatus.Success,
                
        //        Data = new
        //        {
        //            data = true
        //        }
        //    }
        //    );

        //    return Ok(new ResponseResult
        //    {
        //        Status = ResponseStatus.NotValid,
        //        Message = "This phone number already exist.",
        //        Data = new
        //        {
        //            data = false
        //        }
        //    }
        //    );

        //}


        //// ---- routing to google
        //[HttpPost]
        //public IActionResult ExternalLogin(string provider, string returnUrl)
        //{
        //    var redirectUrl = Url.Action("ExternalLoginCallBack", "Auth",
        //        new { ReturnUrl = returnUrl });

        //    var properties = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
        //    return new ChallengeResult(provider, properties);
        //}


        //// ------ after select account
        //public async Task<IActionResult> ExternalLoginCallBack(string returnUrl = null, string remoteError = null)
        //{
        //    returnUrl =
        //        (returnUrl != null && Url.IsLocalUrl(returnUrl)) ? returnUrl : Url.Content("~/");

        //    var loginViewModel = new LoginModel()
        //    {
        //        ReturnUrl = returnUrl,
        //        ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
        //    };

        //    if (remoteError != null)
        //    {
        //        ModelState.AddModelError("", $"Error : {remoteError}");
        //        return Ok(new ResponseResult
        //        {
        //            Status = ResponseStatus.Fail,
        //            Message = "Somthing bad happend",
        //            Data = new
        //            {
        //                data = false
        //            }
        //        });
        //    }

        //    var externalLoginInfo = await signInManager.GetExternalLoginInfoAsync();
        //    if (externalLoginInfo == null)
        //    {
        //        ModelState.AddModelError("ErrorLoadingExternalLoginInfo", $"مشکلی پیش آمد");
        //        return Ok(new ResponseResult
        //        {
        //            Status = ResponseStatus.Fail,
        //            Message = "Somthing bad happend",
        //            Data = new
        //            {
        //                data = false
        //            }
        //        });
        //    }

        //    var signInResult = await signInManager.ExternalLoginSignInAsync(externalLoginInfo.LoginProvider,
        //        externalLoginInfo.ProviderKey, false, true);

        //    if (signInResult.Succeeded)
        //    {
        //        return Redirect(returnUrl);
        //    }

        //    var email = externalLoginInfo.Principal.FindFirstValue(ClaimTypes.Email);

        //    if (email != null)
        //    {
        //        var user = await userManager.FindByEmailAsync(email);
        //        if (user == null)
        //        {
                 
        //            user = new IdentityUser()
        //            {
        //                UserName = email,
        //                Email = email,
        //                EmailConfirmed = true
        //            };

        //            await userManager.CreateAsync(user);
        //        }

        //        await userManager.AddLoginAsync(user, externalLoginInfo);
        //        await signInManager.SignInAsync(user, false);

        //        return Ok(new ResponseResult
        //        {
        //            Status = ResponseStatus.Success,
        //            Message = "Ok",
        //            Data = new
        //            {
        //                data = true
        //            }
        //        });
        //    }

 
        //    return Ok(new ResponseResult
        //    { 
        //        Status = ResponseStatus.Fail,
        //        Message="مشکلی پیش آمده است لطفا با پشتیبانی تماس بگیرید",
        //        Data = new { 
        //            data = false
        //        }
        //    });
        //}



        //private string GenerateJSONWebToken(UserModel userInfo)
        //{
        //    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        //    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);


        //    var claims = new List<Claim>()
        //        {
        //            new Claim("UserName", userInfo.UserName),
        //            new Claim(ClaimTypes.Role, userInfo.Roles[0].RoleTitle),  // --- dotnet core identity must be replace
        //            new Claim(ClaimTypes.Email, userInfo.Email),
        //            new Claim("Jti", Guid.NewGuid().ToString()),
        //         };
        //    var userIdentity = new ClaimsIdentity(claims, "User Identity");
        //    var userPrincipal = new ClaimsPrincipal(new[] { userIdentity });
        //    HttpContext.SignInAsync(userPrincipal);



        //    var token = new JwtSecurityToken(_config["Jwt:Issuer"],
        //          _config["Jwt:Issuer"],
        //          claims,
        //          expires: DateTime.Now.AddMinutes(120),
        //          signingCredentials: credentials);

        //    return new JwtSecurityTokenHandler().WriteToken(token);
        //}


    }
}
