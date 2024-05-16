using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProvider.Models;

public class UserLoginRequest
{
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsPersistent { get; set; }
}
