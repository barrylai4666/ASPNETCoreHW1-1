namespace ASPNETCoreHW1.Models
{
     public class LoginModel
    {
        public string Username{get;set;}
        public string Pasword{get;set;}
    }

    public class LoginResult{
        public string Token {get;set;}
    }
}