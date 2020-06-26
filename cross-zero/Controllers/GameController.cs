using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cross_zero.Logic.Logics;
using cross_zero.Services.Services;
using Cross_zero.Common.Enums;
using Cross_zero.Common.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cross_zero.Controllers
{
    [ApiController]
    public class GameController : Controller
    {

        private readonly IHistoryGamesService _historyGamesService;
        private readonly IGameLogic _gameLogic;

        public GameController(IHistoryGamesService historyGamesService, IGameLogic gameLogic)
        {
            _historyGamesService = historyGamesService;
            _gameLogic = gameLogic;
        }


        [HttpGet("[action]/{userNameOne}/{userNameTwo}")]
        [Authorize]
        public async Task<IActionResult> Game([FromRoute]GameViewModel model)
        {
            if (User.Identity.IsAuthenticated)
            {

                var result = await _gameLogic.GetGame(model);

                return View(result);

            }
            else
            {

                throw new Exception("Пользователь не авторизован");

            }

        }

        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> CreateGame([FromForm] GameViewModel model)
        {
            try
            {
                

                await _gameLogic.CreateGame(model);

                return Ok();

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }
        }

        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> EndGame([FromForm] GameViewModel model)
        {
            try 
            {

                await _gameLogic.EndGame(model);

                return Ok();
            
            }
            catch(Exception ex)
            {

                return BadRequest(ex.Message);

            }
        }

    }
}