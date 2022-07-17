using System;
using System.IO;
using Terraria;
using TerrariaApi.Server;
using Terraria.Localization;
using TShockAPI;

namespace buildertools
{
    [ApiVersion(2, 1)]
    public class BuilderTools : TerrariaPlugin
    {
        public override string Name => "buildertools";
        public override string Description => "Provides tools commonly used by builders to the player.";
        public override string Author => "Outmoon";
        public override Version Version => new Version(1, 0, 0, 0);

        public BuilderTools(Main game) : base(game)
        {
            Order = 1;
        }

        // hooking and unhooking below

        public override void Initialize()
        {
            ServerApi.Hooks.GameInitialize.Register(this, OnInitialize);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ServerApi.Hooks.GameInitialize.Deregister(this, OnInitialize);
            }
            base.Dispose(disposing);
        }

        // functions & commands

        void OnInitialize(EventArgs args)
        {
            Commands.ChatCommands.Add(new Command("buildertools.allowed", Command, "buildertools", "btools"));
        }

        void Command(CommandArgs args)
        {
            if (args.Parameters.Count > 0)
            {
                args.Player.SendErrorMessage("Parameters are not used with this command, you do not need to put your player name.");
            }
            else
            {
                args.Player.SendSuccessMessage($"Gave building tools to {args.Player.Name}.");

                int[] Items = {1543, 1544, 1545, 3611, 496, 1326, 3620, 510, 3061, 5010, 407, 1923, 2215, 3624, 4989, 4953, 4409, 4008, 410, 411, 4444};
                
                for(int i = 0; i < Items.Length; i++)
                {
                    args.Player.GiveItem(Items[i], 1, 0);
                }

                args.Player.GiveItem(849, 999, 0);
                args.Player.GiveItem(530, 999, 0);
            }
        }
    }
}
