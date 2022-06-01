using Api.Hubs;
using Api.Hubs.Clients;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ChatController : Controller
	{
		private readonly IHubContext<ChatHub, IChatClient> _chatHub;

		public ChatController(IHubContext<ChatHub, IChatClient> chatHub)
		{
			_chatHub = chatHub;
		}
		
		[HttpPost("message")]
		public async Task Post(ChatMessage message)
		{
			await _chatHub.Clients.All.ReceiveMessage(message);
		}
	}
}
