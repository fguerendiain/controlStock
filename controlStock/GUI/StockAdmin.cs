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
		string archivoXML;


		public StockAdmin (WareHouse activeWareHouseParameter, string archivoXMLPArameter):base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.archivoXML = archivoXMLPArameter;
			this.activeWareHouse = activeWareHouseParameter;
			this.lblDepositoSeleccionado.Text = activeWareHouse.Sala.ToString();
			this.txtArticleListGuide.Buffer.Text = activeWareHouse.ToString ();
		}


		protected void OnBtnAddArticleClicked (object sender, EventArgs e)
		{
			AddItem addItem = new AddItem(activeWareHouse,archivoXML);
			addItem.Show();
			this.Destroy ();
		}

		protected void OnBtnBackToWareHouseSelectClicked (object sender, EventArgs e)
		{
			activeWareHouse.Guardar (archivoXML, activeWareHouse.Stock);
//			this.Hide ();
			MainWindow backMainWindow = new MainWindow ();
			backMainWindow.Show ();
			this.Destroy();
		}

		protected void OnBtnDeleteArticleClicked (object sender, EventArgs e)
		{
			RemoveItem removeItem = new RemoveItem(activeWareHouse,archivoXML);
			removeItem.Show();
			this.Destroy ();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			activeWareHouse.Guardar (archivoXML, activeWareHouse.Stock);
			Application.Quit ();
			a.RetVal = true;
		}



		protected void OnBtnEntryArticleClicked (object sender, EventArgs e)
		{
			EntryArticle entryArticle = new EntryArticle(activeWareHouse,archivoXML,true);
			entryArticle.Show();
			this.Destroy ();
		}

		protected void OnBtnDischargeArticleClicked (object sender, EventArgs e)
		{
			EntryArticle entryArticle = new EntryArticle(activeWareHouse,archivoXML,false);
			entryArticle.Title = "Egreso de Mercaderia";
			entryArticle.Show();
			this.Destroy ();
		}

	}
}

