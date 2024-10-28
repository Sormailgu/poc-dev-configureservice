// Generate a controller for the AccountTypeController
using Microsoft.AspNetCore.Mvc;

namespace ConfigureService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountTypeController : ControllerBase
    {
        private readonly ILogger<AccountTypeController> _logger;
        private readonly IAccountTypeService _accountTypeService;


        public AccountTypeController(ILogger<AccountTypeController> logger, IAccountTypeService accountTypeService)
        {
            _logger = logger;
            _accountTypeService = accountTypeService;
        }

        [HttpGet("GetAccountTypeList")]        
        public ActionResult<IEnumerable<AccountTypeResponseDto>> GetAccountTypes()
        {
            _logger.LogInformation("Getting account types");
            var accountTypes = _accountTypeService.GetAccountTypes();
            // Data to Dto
            var response = accountTypes.Select(at => new AccountTypeResponseDto
            {
                Id = at.Id,
                Name = at.Name,
                Description = at.Description,
                IsActive = at.IsActive
            });
            return Ok(response);
        }
    }
}

