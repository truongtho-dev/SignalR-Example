using Api.Hubs.Clients;
using Api.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Hubs
{
	public class ChatHub: Hub<IChatClient>
	{
		//public async Task SendMessage(ChatMessage message)
		//{
		//	await Clients.All.ReceiveMessage(message);
		//}
	}
}
