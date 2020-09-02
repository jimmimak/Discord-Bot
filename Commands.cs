using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.Commands;

namespace DiscordBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("Hi")]
        public async Task Hi()
        {
            await ReplyAsync("Hey what's up?");
        }

        [Command("I'm good thanks")]
        public async Task status()
        {
            await ReplyAsync("Glad to hear it!");
        }

        [Command("What about you?")]
        public async Task question_status()
        {
            await ReplyAsync("Ah i'm fine, you know, hanging around");
        }
        [Command("Nice, so what are you doing to spend your time during the quarantine?")]
        public async Task quarantine_question()
        {
            await ReplyAsync("Eh, not much, just waiting for someone to come in and start a conversation with me");
        }
    }
}
