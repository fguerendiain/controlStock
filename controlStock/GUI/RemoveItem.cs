using System;

namespace GUI
{
	public partial class RemoveItem : Gtk.Window
	{
		public RemoveItem () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

