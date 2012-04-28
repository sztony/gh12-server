using System;
using Server.Packets;

namespace Server.Game.Packets {
	[APacket("welcome")]
	public class PacketLauncherWelcome : PacketType {
		static private PacketType instance = new PacketLauncherWelcome();

		private PacketLauncherWelcome() {
			this.AddField("message", "string");
		}
	}
}