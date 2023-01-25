using Microsoft.AspNetCore.Mvc;
using EmailApiLocobuzz.LogicLayer;

namespace EmailApiLocobuzz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        Email email = new Email();
        [HttpPost]
        public string SendMail()
        {
            // FOR DYNAMIC HERE WE WILL DESERIALIZE THE OBJECT AND SEND THE REQUIRED OBJECTS FURTHER, ALSO ON THE BASIS OF TEMPLATE ID IT CAN BE DESERIALIZED IN NEXT LAYER
            Email.RunAsync().Wait();
            return "executed";
        }
    }
}
