using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UFAR.Classwork.Core.Services;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IBalanceManagementService _transactionService;

        public TransactionController(IBalanceManagementService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet("List")]
        public IActionResult GetTransactions()
        {
            return Ok(_transactionService.GetAllTransactions());
        }

        [HttpGet("GetTransactionById")]
        public IActionResult GetTransactionById(int transactionId)
        {
            return Ok(_transactionService.GetTransactionById(transactionId));
        }

        [HttpPost("AddTransaction")]
        public IActionResult AddTransaction(TransactionEntity transaction)
        {
            _transactionService.AddTransaction(transaction);
            return Ok();
        }

        [HttpDelete("DeleteTransaction")]
        public IActionResult DeleteTransaction(int transactionId)
        {
            _transactionService.DeleteTransaction(transactionId);
            return Ok();
        }
    }
}

