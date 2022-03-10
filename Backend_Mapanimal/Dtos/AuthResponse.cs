using System;

namespace Backend_Mapanimal.Dtos
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
