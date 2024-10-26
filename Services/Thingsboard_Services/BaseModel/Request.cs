using System.Text;
using System.Text.Json;

namespace Services.Thingsboard_Services.BaseModel;

public class Request<T>
{
    public string Url { get; set; }
    public string Body { get; set; }
    public Token? Token { get; set; }
    public Request(string url, string body, Token? token)
    {
        Url = url;
        Body = body;
        Token = token;
    }

    public Response<T>? Post()
    {
        using HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("X-Authorization", "Bearer" + Token.jwt_token);
        client.DefaultRequestHeaders.Add("Content-Type", "application/json");
        client.DefaultRequestHeaders.Add("Accept", "application/json");
        return JsonSerializer.Deserialize<Response<T>>(client.PostAsync(Url, new StringContent(Body, Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync().Result);
    }
    
    public Response<T>? Get()
    {
        using HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("X-Authorization", "Bearer "+ Token.jwt_token );
        client.DefaultRequestHeaders.Add("Content-Type", "application/json");
        client.DefaultRequestHeaders.Add("Accept", "application/json");
        return JsonSerializer.Deserialize<Response<T>>(client.GetAsync(Url).Result.Content.ReadAsStringAsync().Result);
    }
    
    
}