using System.Threading.Tasks;
using Discord.Commands;

namespace bitrix_gate.Modules
{
	public class Commands : ModuleBase<SocketCommandContext>
	{
		/// <summary>
		/// Команда определения канала
		/// </summary>
		/// <returns></returns>
		[Command("detect")]
		public async Task Detect()
		{
			var message = "Channel #" + Context.Channel.Id + "; ";
			message += "Name `" + Context.Channel.Name + "`";
			await Context.Channel.SendMessageAsync(message);
		}

		/// <summary>
		/// Ответ на пинг
		/// </summary>
		/// <returns></returns>
		[Command("ping")]
		public async Task Ping()
		{
			await ReplyAsync("Pong");
		}
	}
}
