using System.Collections.Generic;

namespace AuthDemo
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string username, string password);

        
    }
}
