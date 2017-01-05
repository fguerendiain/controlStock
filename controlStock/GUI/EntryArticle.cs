using System;

namespace GUI
{
	public partial class EntryArticle : Gtk.Window
	{
		public EntryArticle () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

