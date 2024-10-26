namespace Services.Thingsboard_Services.BaseModel;

public abstract class Token
{
    public string jwt_token { get; set; }
    public string refresh_token { get; set; }
    public Token(string jwt_token, string refresh_token)
    {
        this.jwt_token = jwt_token;
        this.refresh_token = refresh_token;
    }
}