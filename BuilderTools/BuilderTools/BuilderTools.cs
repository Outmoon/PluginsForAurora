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

        public enum ItemSlot
        {
            InvRow1Slot1, InvRow1Slot2, InvRow1Slot3, InvRow1Slot4, InvRow1Slot5, InvRow1Slot6, InvRow1Slot7, InvRow1Slot8, InvRow1Slot9, InvRow1Slot10,
            InvRow2Slot1, InvRow2Slot2, InvRow2Slot3, InvRow2Slot4, InvRow2Slot5, InvRow2Slot6, InvRow2Slot7, InvRow2Slot8, InvRow2Slot9, InvRow2Slot10,
            InvRow3Slot1, InvRow3Slot2, InvRow3Slot3, InvRow3Slot4, InvRow3Slot5, InvRow3Slot6, InvRow3Slot7, InvRow3Slot8, InvRow3Slot9, InvRow3Slot10,
            InvRow4Slot1, InvRow4Slot2, InvRow4Slot3, InvRow4Slot4, InvRow4Slot5, InvRow4Slot6, InvRow4Slot7, InvRow4Slot8, InvRow4Slot9, InvRow4Slot10,
            InvRow5Slot1, InvRow5Slot2, InvRow5Slot3, InvRow5Slot4, InvRow5Slot5, InvRow5Slot6, InvRow5Slot7, InvRow5Slot8, InvRow5Slot9, InvRow5Slot10,
            CoinSlot1, CoinSlot2, CoinSlot3, CoinSlot4, AmmoSlot1, AmmoSlot2, AmmoSlot3, AmmoSlot4, HandSlot,
            ArmorHeadSlot, ArmorBodySlot, ArmorLeggingsSlot, AccessorySlot1, AccessorySlot2, AccessorySlot3, AccessorySlot4, AccessorySlot5, AccessorySlot6, UnknownSlot1,
            VanityHeadSlot, VanityBodySlot, VanityLeggingsSlot, SocialAccessorySlot1, SocialAccessorySlot2, SocialAccessorySlot3, SocialAccessorySlot4, SocialAccessorySlot5, SocialAccessorySlot6, UnknownSlot2,
            DyeHeadSlot, DyeBodySlot, DyeLeggingsSlot, DyeAccessorySlot1, DyeAccessorySlot2, DyeAccessorySlot3, DyeAccessorySlot4, DyeAccessorySlot5, DyeAccessorySlot6, Unknown3,
            EquipmentSlot1, EquipmentSlot2, EquipmentSlot3, EquipmentSlot4, EquipmentSlot5,
            DyeEquipmentSlot1, DyeEquipmentSlot2, DyeEquipmentSlot3, DyeEquipmentSlot4, DyeEquipmentSlot5
        };

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