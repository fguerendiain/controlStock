using System;
using Gtk;
using Items;
using GUI;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window
{	
	WareHouse depositoBiyemas;
	WareHouse depositoKandiko;
	WareHouse depositoRebisco;
	string archivoXMLBiyemas = "../../../BBiyemas.xml";
	string archivoXMLKandiko = "../../../BKandiko.xml";
	string archivoXMLRebisco = "../../../BRebisco.xml";

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
		depositoBiyemas = new WareHouse (WareHouse.Sala.Biyemas);
		List<Article> auxList = new List<Article> ();	
		depositoBiyemas.Leer (archivoXMLBiyemas, out auxList);
		depositoBiyemas.Stock = auxList;
		StockAdmin stockAdminBiy = new StockAdmin(depositoBiyemas,"Biyemas");
		stockAdminBiy.Show ();
	}

	protected void OnBtnMWKandikoClicked (object sender, EventArgs e)
	{
		this.Hide ();
		depositoKandiko = new WareHouse (WareHouse.Sala.Kandiko);
		List<Article> auxList = new List<Article> ();	
		depositoKandiko.Leer (archivoXMLKandiko, out auxList);
		depositoKandiko.Stock = auxList;
		StockAdmin stockAdminKan = new StockAdmin(depositoKandiko,"Kandiko");
		stockAdminKan.Show ();
	}

	protected void OnBtnMWRebiscoClicked (object sender, EventArgs e)
	{
		this.Hide ();
		depositoRebisco = new WareHouse (WareHouse.Sala.Rebisco);
		List<Article> auxList = new List<Article> ();	
		depositoRebisco.Leer (archivoXMLRebisco, out auxList);
		depositoRebisco.Stock = auxList;
		StockAdmin stockAdminReb = new StockAdmin(depositoRebisco,"Rebisco");
		stockAdminReb.Show ();
	}
}
