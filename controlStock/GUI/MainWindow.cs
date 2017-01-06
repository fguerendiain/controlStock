using System;
using Gtk;
using Items;
using GUI;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window
{	

	//setea la direccion y nombre del archivo xml de cada sala
	string archivoXMLBiyemas = "BBiyemas.xml";
	string archivoXMLKandiko = "BKandiko.xml";
	string archivoXMLRebisco = "BRebisco.xml";

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
		WareHouse depositoBiyemas = new WareHouse (WareHouse.Empresa.Biyemas);
		List<Article> auxList = new List<Article> ();	
		depositoBiyemas.Leer (archivoXMLBiyemas, out auxList);
		depositoBiyemas.Stock = auxList;
		StockAdmin stockAdminBiy = new StockAdmin(depositoBiyemas, archivoXMLBiyemas);
		stockAdminBiy.Show ();
		this.Destroy ();
	}

	protected void OnBtnMWKandikoClicked (object sender, EventArgs e)
	{
		this.Hide ();
		WareHouse depositoKandiko = new WareHouse (WareHouse.Empresa.Kandiko);
		List<Article> auxList = new List<Article> ();	
		depositoKandiko.Leer (archivoXMLKandiko, out auxList);
		depositoKandiko.Stock = auxList;
		StockAdmin stockAdminKan = new StockAdmin(depositoKandiko,archivoXMLKandiko);
		stockAdminKan.Show ();
	}

	protected void OnBtnMWRebiscoClicked (object sender, EventArgs e)
	{
		this.Hide ();
		WareHouse depositoRebisco = new WareHouse (WareHouse.Empresa.Rebisco);
		List<Article> auxList = new List<Article> ();	
		depositoRebisco.Leer (archivoXMLRebisco, out auxList);
		depositoRebisco.Stock = auxList;
		StockAdmin stockAdminReb = new StockAdmin(depositoRebisco,archivoXMLRebisco);
		stockAdminReb.Show ();
	}
}
