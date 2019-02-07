namespace Account.Application.QueryService.Token
{
    public class TokenResponseModel
    {
        public TokenResponseModel(string username, string accessToken, string refreshToken)
        {
            Username = username;
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }
        
        public string Username { get; }
        public string AccessToken { get; }
        public string RefreshToken { get; }
    }
}