using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cross_zero.Extensions;
using cross_zero.Logic.Logics;
using cross_zero.Services.Services;
using Cross_zero.Common.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cross_zero.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : Controller
    {

        private readonly IUserService _userService;
        private readonly IUserLogic _userLogic;

        public AccountController(IUserService userService, IUserLogic userLogic)
        {

            _userService = userService;
            _userLogic = userLogic;

        }


        [HttpGet("[action]")]
        public IActionResult LogIn()
        {

            try
            {

                return View();

            }
            catch(Exception ex)
            {

                return BadRequest(ex.Message);

            }

        }

        [HttpGet("[action]")]
        public IActionResult Registration()
        {

            try
            {

                return View();

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> LogIn([FromForm]LoginViewModel model)
        {
            try 
            {

                var result = await _userService.LogIn(model);

                if (result.Succeeded)
                {

                    return RedirectToAction("UsersList");

                }
                else
                {

                    throw new Exception("При авторизации возникла ошибка");

                }
            
            }
            catch(Exception ex)
            {

                return BadRequest(ex.Message);

            }
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Registration([FromForm]RegistrationViewModel model)
        {
            try
            {

                var result = await _userService.Create(model);

                if (result.Succeeded)
                {

                    return Ok();

                }
                else
                {

                    throw new Exception("При регистрации возникла ошибка");

                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }
        }

        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> LogOut()
        {
            try
            {

                await _userService.LogOut();

                return Ok();

            }
            catch(Exception ex)
            {

                return BadRequest("При выходе из аккаунта возникла ошибка");

            }
        }

        [HttpGet("[action]")]
        [Authorize]
        public IActionResult UsersList()
        {
            try
            {

                var result = _userLogic.GetUsers(this.CurrentUser());


                return View(result);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }
        }
        
    }
}