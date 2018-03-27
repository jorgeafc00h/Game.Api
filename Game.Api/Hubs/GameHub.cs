using Microsoft.AspNetCore.SignalR;
using System;

namespace Game.Api
{
	public class GameHub : Hub
	{
		

		public void Send(string name, string message)
		{
			// Call the broadcastMessage method to update clients.
			Clients.All.SendAsync("broadcastMessage", name, message);
		}
	}
}
