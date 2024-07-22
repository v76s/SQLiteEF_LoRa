using Microsoft.AspNetCore.Mvc;
using SQLiteEF_LoRa.Data;
using SQLiteEF_LoRa.Models;

namespace SQLiteEF_LoRa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoRaCommController : ControllerBase
    {
        private readonly DataContext _context;

        public LoRaCommController(DataContext context)
        {
            _context = context;
        }

        // In-memory store for received messages
        private static List<LoRaCommModel> _messages = new List<LoRaCommModel>();

        // POST: api/LoRaMessage
        [HttpPost]
        public IActionResult ReceiveMessage([FromBody] LoRaCommModel message)
        {
            if (message == null)
            {
                return BadRequest("Invalid message.");
            }

            // Validate the message (add more validation as needed)
            if (string.IsNullOrEmpty(message.Id) || string.IsNullOrEmpty(message.DeviceAddress) || string.IsNullOrEmpty(message.Payload))
            {
                return BadRequest("Missing required fields.");
            }

            // Process the message
            message.Timestamp = DateTime.UtcNow;  // Set the timestamp to current UTC time

            // LoRa Parser yet unimplemented for the probable endpoint, should be a configurable 
            // parser without need to re-write for different packages, a distriptive XML could be used ...

            // Add the message to the in-memory store
            _messages.Add(message);

            _context.tbLoRaComm.Add(message);
            
            _context.SaveChanges();   

            // Log the message (optional)
            Console.WriteLine($"Received message: {message}, saved in table.");

            return Ok("Message received successfully and saved in DB.");
        }

        // GET: api/LoRaMessage
        [HttpGet]
        public IActionResult GetMessages()
        {
            return Ok(_messages);
        }

        // GET: api/LoRaMessage/{gatewayId}
        [HttpGet("{gatewayId}")]
        public IActionResult GetMessagesByGateway(string gatewayId)
        {
            var messages = _messages.FindAll(m => m.Id == gatewayId);
            if (messages == null || messages.Count == 0)
            {
                return NotFound("No messages found for the specified gateway.");
            }

            return Ok(messages);
        }
    }
}

