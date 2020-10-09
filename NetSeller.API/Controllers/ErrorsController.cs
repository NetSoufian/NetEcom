using Microsoft.AspNetCore.Mvc;
using NetSeller.API.Errors;

namespace NetSeller.API.Controllers
{
    [Route("errors/{code}")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorsController : BaseApiController
    {
       public IActionResult Error(int code)
       {
         return new ObjectResult(new ApiResponse(code));
       } 
    }
}