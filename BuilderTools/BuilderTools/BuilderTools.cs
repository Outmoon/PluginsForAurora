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
                args.Player.SendSuccessMessage($"Gave tools to {args.Player.Name}");

                //spectre paint set
                args.Player.GiveItem(1543, 1, 0);
                args.Player.GiveItem(1544, 1, 0);
                args.Player.GiveItem(1545, 1, 0);
                //tools
                args.Player.GiveItem(3611, 1, 0);
                args.Player.GiveItem(496, 1, 0);
                args.Player.GiveItem(1326, 1, 0);
                args.Player.GiveItem(3620, 1, 0);
                args.Player.GiveItem(510, 1, 0);
                //ammo
                args.Player.GiveItem(849, 999, 0);
                args.Player.GiveItem(530, 999, 0);
                //accessories
                args.Player.GiveItem(3061, 1, 0);
                args.Player.GiveItem(5010, 1, 0);
                args.Player.GiveItem(407, 1, 0);
                args.Player.GiveItem(1923, 1, 0);
                args.Player.GiveItem(2215, 1, 0);
                args.Player.GiveItem(3624, 1, 0);
                args.Player.GiveItem(4989, 1, 0);
                args.Player.GiveItem(4954, 1, 0);
                args.Player.GiveItem(4409, 1, 0);
                //armor
                args.Player.GiveItem(4008, 1, 0);
                args.Player.GiveItem(410, 1, 0);
                args.Player.GiveItem(411, 1, 0);
                //mount
                args.Player.GiveItem(4444, 1, 0);
            }
        }
    }
}
