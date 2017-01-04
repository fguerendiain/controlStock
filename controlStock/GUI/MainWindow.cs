using System;
using Gtk;
using Items;
using GUI;

public partial class MainWindow: Gtk.Window
{	

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}


	protected void OnBtnMWBiyemasClicked (object sender, EventArgs e)
	{
		this.Hide ();
		StockAdmin stockAdminBiy = new StockAdmin("Biyemas");
		stockAdminBiy.Show ();
	}

	protected void OnBtnMWKandikoClicked (object sender, EventArgs e)
	{
		this.Hide ();
		StockAdmin stockAdminKan = new StockAdmin("Kandiko");
		stockAdminKan.Show ();
	}

	protected void OnBtnMWRebiscoClicked (object sender, EventArgs e)
	{
		this.Hide ();
		StockAdmin stockAdminReb = new StockAdmin("Rebisco");
		stockAdminReb.Show ();
	}
}
