using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

public class ChatController : Controller
{
    private readonly string apiKey = "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";

    [HttpPost]
    public async Task<IActionResult> AskBot([FromBody] string message)
    {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", apiKey);

        var requestBody = new
        {
            model = "gpt-4.1-mini",
            messages = new[]
            {
                new { role = "system", content = "You are a helpful support assistant for IFox IT company." },
                new { role = "user", content = message }
            }
        };

        var content = new StringContent(JsonConvert.SerializeObject(requestBody),
            Encoding.UTF8, "application/json");

        var response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);
        var result = await response.Content.ReadAsStringAsync();

        dynamic json = JsonConvert.DeserializeObject(result);
        string reply = json.choices[0].message.content;

        return Json(reply);
    }
}
