using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BBBEditor
{
	class OrthographicViewControl : GraphicsDeviceControl
	{
		protected override int Initialise( )
		{
			Application.Idle += delegate { Invalidate( ); };

			m_ClearColour = new Color( 32, 96, 32 );

			return 0;
		}

		protected override void Draw( )
		{
		}
	}
}
