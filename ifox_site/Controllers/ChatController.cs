using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using ifox_site.Models;

[ApiController]
[Route("api/chat")]
public class ChatController : Controller
{
    private readonly IConfiguration _config;

    public ChatController(IConfiguration config)
    {
        _config = config;
    }

    /* ======================================================
       ✅ WHATSAPP NOTIFY (YOUR EXISTING – IMPROVED)
    ====================================================== */
    [HttpPost("notify-whatsapp")]
    public async Task<IActionResult> NotifyWhatsApp([FromBody] ChatMsg data)
    {
        string phone = "919876543210"; // your whatsapp number
        string url = $"https://api.whatsapp.com/send?phone={phone}&text={Uri.EscapeDataString(data.msg)}";

        using HttpClient client = new HttpClient();
        await client.GetAsync(url);

        return Ok();
    }

    /* ======================================================
       ✅ SIMPLE CHAT SAVE (YOUR EXISTING)
    ====================================================== */
    [HttpPost("save")]
    public IActionResult SaveChat([FromBody] ChatMsg data)
    {
        System.IO.File.AppendAllText("chatlog.txt", data.msg + "\n");
        return Ok();
    }

    /* ======================================================
       🚀 MAIN FEATURE — SEND FULL TRANSCRIPT TO EMAIL
       (THIS IS WHAT YOUR JS CALLS)
    ====================================================== */
    [HttpPost("send-transcript")]
    public async Task<IActionResult> SendTranscript([FromBody] ChatLogModel model)
    {
        await SendEmail(model);
        return Ok();
    }

    /* ======================================================
       📧 EMAIL SENDER
    ====================================================== */
    private async Task SendEmail(ChatLogModel chat)
    {
        var body = new StringBuilder();

        body.AppendLine($"User Email: {chat.UserEmail}");
        body.AppendLine("=================================");
        body.AppendLine("");

        if (chat.Messages != null)
        {
            foreach (var msg in chat.Messages)
            {
                body.AppendLine($"{msg.Time} - {msg.Sender}: {msg.Text}");
            }
        }

        var mail = new MailMessage
        {
            From = new MailAddress(_config["EmailSettings:FromEmail"]),
            Subject = "🔥 New Chat Conversation",
            Body = body.ToString()
        };

        mail.To.Add(_config["EmailSettings:ToEmail"]);

        var smtp = new SmtpClient(_config["EmailSettings:SmtpServer"])
        {
            Port = int.Parse(_config["EmailSettings:Port"]),
            Credentials = new NetworkCredential(
                _config["EmailSettings:FromEmail"],
                _config["EmailSettings:AppPassword"]),
            EnableSsl = true
        };

        await smtp.SendMailAsync(mail);
    }
}

/* ======================================================
   📦 MODELS
====================================================== */

public class ChatMsg
{
    public string msg { get; set; }
}

