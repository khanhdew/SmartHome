using System.Net.Http.Headers;
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

    public T? Post()
    {
        try
        {
            using HttpClient client = new HttpClient();
        
            if (Token != null)
            {
                client.DefaultRequestHeaders.Add("X-Authorization", "Bearer " + Token.token);
            }

            var content = new StringContent(Body, Encoding.UTF8, "application/json");

            var request = client.PostAsync(Url, content);
            request.Wait();
            // log request in console color green
            Console.WriteLine($"\u001b[32mRequest URL: {Url}\u001b[0m");
            Console.WriteLine($"\u001b[32mRequest Content: {Body}\u001b[0m");
            
            
            var response = request.Result;

            // Kiểm tra trạng thái phản hồi
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                return default;
            }

            var responseString = response.Content.ReadAsStringAsync().Result;

            // Deserialize JSON thành đối tượng loại T
            return JsonSerializer.Deserialize<T>(responseString);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Deserialization Error: {ex.Message}");
            return default;
        }
    }

    
    public async Task<T?> GetAsync()
    {
        using HttpClient client = new HttpClient();

        if (Token != null)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token.token);
        }

        client.DefaultRequestHeaders.Add("Accept", "application/json");

        try
        {
            var response = await client.GetAsync(Url);
            response.EnsureSuccessStatusCode(); // Kiểm tra mã trạng thái HTTP

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(jsonResponse);
        }
        catch (HttpRequestException ex)
        {
            // Xử lý lỗi kết nối tại đây
            Console.WriteLine($"Request error: {ex.Message}");
            return default; // Hoặc ném ngoại lệ tùy theo nhu cầu của bạn
        }
        catch (JsonException ex)
        {
            // Xử lý lỗi deserialize tại đây
            Console.WriteLine($"JSON deserialization error: {ex.Message}");
            return default; // Hoặc ném ngoại lệ tùy theo nhu cầu của bạn
        }
    }
}
    
    