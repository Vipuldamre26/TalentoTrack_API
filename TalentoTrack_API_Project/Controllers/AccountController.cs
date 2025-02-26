using Microsoft.AspNetCore.Mvc;
using TalentoTrack_Common.DTOs.Account;
using TalentoTrack_Common.Services;

namespace TalentoTrack_API_Project.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class AccountController : ControllerBase
{
    
    private readonly ILogger<AccountController> _logger;
    private readonly IAccountService _accountService;

    public AccountController(ILogger<AccountController> logger, IAccountService accountService)
    {
        _logger = logger;
        _accountService = accountService;
    }

    [HttpPost(Name = "Login")]
    public async Task<LoginResponse> LoginUser([FromBody] LoginRequest request)
    {
        var response = await _accountService.VerifyLoginDetails(request);
       
        return response;
    }
}
