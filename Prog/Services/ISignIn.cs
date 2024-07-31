using System.Runtime.CompilerServices;

namespace Prog.Services
{
    public interface ISignIn
    {
        public  Task SignInAsync(Object user,HttpContext ctx); 
    }
}
 