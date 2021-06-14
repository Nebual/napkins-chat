using System;
using System.Collections.Generic;
using MinimalExtended;
using Sandbox;

namespace NapkinsChat
{
	[Library( "napkins-chat" )]
	public class AddonInfo : BaseAddonInfo
	{
		public override string Name => "NapkinsChat";

		public override string Description => "Vanilla+ chat UI";

		public override string Author => "napkins";

		public override double Version => 1.0;

		public override List<AddonDependency> Dependencies => new() {
			new AddonDependency() {
				Name = "SandboxPlus",
				MinVersion = 1.0
			},
		};
	}
	public partial class NapkinsChat : AddonClass<AddonInfo> { }
}
