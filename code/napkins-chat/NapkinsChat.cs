using System.Threading.Tasks;

using MinimalExtended;
using Sandbox;

namespace NapkinsChat
{
	public partial class NapkinsChat : IAutoload
	{
		public bool ReloadOnHotload => false;
		public NapkinsChat()
		{
			Initialize();
		}

		private async void Initialize()
		{
			if ( IsClient ) {
				Log.Info( "[Client] NapkinsChat created" );

				await Task.Delay( 1 );
				Local.Hud.AddChild<ClassicChatBox>();
			}
		}
	}
}
