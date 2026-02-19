using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

public class ChatController : Controller
{
    [HttpPost]
    public async Task<IActionResult> NotifyWhatsApp([FromBody] ChatMsg data)
    {
        string phone = "919876543210"; // your whatsapp number
        string url = $"https://api.whatsapp.com/send?phone={phone}&text={data.msg}";
        using HttpClient client = new HttpClient();
        await client.GetAsync(url);
        return Ok();
    }

    [HttpPost]
    public IActionResult SaveChat([FromBody] ChatMsg data)
    {
        // save to DB later
        System.IO.File.AppendAllText("chatlog.txt", data.msg + "\n");
        return Ok();
    }
}

public class ChatMsg
{
    public string msg { get; set; }
}


