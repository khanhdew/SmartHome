namespace Services.Thingsboard_Services.BaseModel;

public class Request 
{
    public string url { get; set; }
    public string body { get; set; }
    public Request(string url, string method, string body)
    {
        this.url = url;
        this.body = body;
    }

    public void Post(string url, string body)
    {
        this.url = url;
        this.body = body;
        using HttpClient client = new HttpClient();
    }
}