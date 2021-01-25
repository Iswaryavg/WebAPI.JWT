using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.JWT.Controllers
{
    public interface IJWTAuthenticationManager
    {
        public string Authenticate(string username, string password);
    }
}
