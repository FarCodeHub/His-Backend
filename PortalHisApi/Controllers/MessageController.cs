using Business.SMSManagment.Extensions;
using Business.SMSManagment.IServices;
using Business.SMSManagment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalHisApi.Controllers
{
    [Area("Admin")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpPost]
        public async Task<IActionResult> Message(MessageDto dtos)
        {
            var result = await _messageService.Add(dtos);

            return new CustomActionResult(result);
        }

        [HttpPost("Search")]
        public async Task<IActionResult> Search(MessageFilterDto dtos)
        {
            var result = await _messageService.Search(dtos);

            return new CustomActionResult(result);
        }

        [HttpPost("TransactionSearch")]
        public async Task<IActionResult> TransactionSearch(MessageFilterDto dtos)
        {
            var result = await _messageService.TransactionSearch(dtos);

            return new CustomActionResult(result);
        }

        [HttpPost("LogMessageSearch")]
        public async Task<IActionResult> LogMessageSearch(LogMessageFilterDto dtos)
        {
            var result = await _messageService.LogMessageSearch(dtos);

            return new CustomActionResult(result);
        }


        [HttpGet("BalanceMax")]
        public async Task<IActionResult> BalanceMax()
        {
            var result = await _messageService.BalanceMax();

            return new CustomActionResult(result);
        }

        [HttpGet("General/{pageName}")]
        public async Task<IActionResult> General(string pageName)
        {
            var result = await _messageService.General(pageName);

            return new CustomActionResult(result);
        }

    }
}
