using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;

namespace Api.Hubs.Clients
{
	public interface IChatClient
	{
		Task ReceiveMessage(ChatMessage message);
	}
}
