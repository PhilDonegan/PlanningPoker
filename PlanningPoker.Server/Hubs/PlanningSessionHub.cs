using Microsoft.AspNetCore.SignalR;
using PlanningPoker.Server.Hubs.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanningPoker.Server.Hubs
{
	public class PlanningSessionHub : Hub
	{
		public async Task CreateSession()
		{
			await Groups.AddToGroupAsync(Context.ConnectionId, RandomStringGenerator.RandomString(5));
		}
	}
}
