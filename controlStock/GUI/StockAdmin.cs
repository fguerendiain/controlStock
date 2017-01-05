using System;
using Gtk;
using Items;
using GUI;
using System.Collections.Generic;

namespace GUI
{
	public partial class StockAdmin : Gtk.Window
	{

		WareHouse activeWareHouse;
		string archivoXMLBiyemas = "../../../BBiyemas.xml";
		string archivoXMLKandiko = "../../../BKandiko.xml";
		string archivoXMLRebisco = "../../../BRebisco.xml";


		public StockAdmin (WareHouse activeWareHouseParameter, string selectedWareHouse):base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.lblDepositoSeleccionado.Text = selectedWareHouse;
			this.activeWareHouse = activeWareHouseParameter;

			switch (selectedWareHouse) {
			
				case "Biyemas":
				{
				this.txtArticleListGuide.Buffer.Text = activeWareHouse.ToString ();
				}
				break;
			
				case "Kandiko":
				{
				this.txtArticleListGuide.Buffer.Text = activeWareHouse.ToString ();
				}
				break;
	
				case "Rebisco":
				{
				this.txtArticleListGuide.Buffer.Text = activeWareHouse.ToString ();
				}
				break;
			}
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			switch (this.lblDepositoSeleccionado.Text)
			{
				case "Biyemas":
				{
					activeWareHouse.Guardar (archivoXMLBiyemas, activeWareHouse.Stock);
				}
				break;				
	
				case "Kandiko":
				{
					activeWareHouse.Guardar (archivoXMLKandiko, activeWareHouse.Stock);
				}
				break;				

				case "Rebisco":
				{
					activeWareHouse.Guardar (archivoXMLRebisco, activeWareHouse.Stock);
				}
				break;		
			}
			Application.Quit ();
			a.RetVal = true;
		}

		protected void OnBtnAddArticleClicked (object sender, EventArgs e)
		{
			AddItem addItem = new AddItem(activeWareHouse,this.lblDepositoSeleccionado.Text.ToString());
			addItem.Show();
			this.Destroy ();
		}



		protected void OnBtnBackToWareHouseSelectClicked (object sender, EventArgs e)
		{
			MainWindow backMainWindow = new MainWindow ();
			backMainWindow.Show ();

			switch (this.lblDepositoSeleccionado.Text)
			{
				case "Biyemas":
			{
				activeWareHouse.Guardar (archivoXMLBiyemas, activeWareHouse.Stock);
			}
				break;				

				case "Kandiko":
			{
				activeWareHouse.Guardar (archivoXMLKandiko, activeWareHouse.Stock);
			}
				break;				

				case "Rebisco":
			{
				activeWareHouse.Guardar (archivoXMLRebisco, activeWareHouse.Stock);
			}
				break;		
			}
			this.Destroy();
		}
	}
}

