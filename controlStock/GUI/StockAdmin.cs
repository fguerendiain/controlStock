using System;
using Gtk;
using Items;
using GUI;

namespace GUI
{
	public partial class StockAdmin : Gtk.Window
	{
		public StockAdmin (string selectedWareHouse) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.lblDepositoSeleccionado.Text = selectedWareHouse;

			switch (selectedWareHouse) {
			
				case "Biyemas":
				break;
			
				case "Kandiko":
				break;
	
				case "Rebisco":
				break;

			}


		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}


	}
}

