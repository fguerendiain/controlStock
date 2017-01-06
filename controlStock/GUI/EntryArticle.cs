using System;
using Gtk;
using Items;

namespace GUI
{
	public partial class EntryArticle : Gtk.Window
	{

		WareHouse activeWareHouse;
		WareHouse auxiliarUnmodifyWareHouse;
		string archivoXML;
		Article auxArticle;
		bool addOrRemove;


		public EntryArticle (WareHouse activeWareHouseParameter, string archivoXMLParameter, bool addOrRemoveParameter):base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.activeWareHouse = activeWareHouseParameter;
			this.auxiliarUnmodifyWareHouse = activeWareHouseParameter;
			this.archivoXML = archivoXMLParameter;
			this.addOrRemove = addOrRemoveParameter;
		}



		protected void OnBtnEntryArticleGetIdClicked (object sender, EventArgs e)
		{
			int idtoSearch;
			int.TryParse (this.entEntryArticleGetId.Text.ToString (), out idtoSearch);
			auxArticle = activeWareHouse.SearchArticleBy (idtoSearch);
			if (auxArticle.Id == 0)
			{
				this.Hide();
				MessageDialog errorMessage = new MessageDialog (this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "El articulo no existe");
				errorMessage.Run ();
				errorMessage.Destroy ();
				this.backToStockAdmin (auxiliarUnmodifyWareHouse);
			}
			this.txtEntryArticleInfo.Buffer.Text = auxArticle.PrintArticle ();
		}


		//codear el agregado de stock

		protected void OnBtnEntryArticleOkClicked (object sender, EventArgs e)
		{
			int userQuantity;
			int.TryParse (this.entEntryArticleQuantity.Text.ToString (), out userQuantity);
			activeWareHouse.ModifyStock (auxArticle,userQuantity, addOrRemove);
			activeWareHouse.Guardar (archivoXML, activeWareHouse.Stock);
			this.backToStockAdmin (activeWareHouse);
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			this.backToStockAdmin (auxiliarUnmodifyWareHouse);
		}

		/// <summary>
		/// Backs to stock admin.
		/// </summary>
		/// <param name="workedWareHouse">Worked ware house.</param>
		private void backToStockAdmin(WareHouse workedWareHouse)
		{
			StockAdmin backStockAdmin = new StockAdmin (workedWareHouse, archivoXML);
			backStockAdmin.Show ();
			this.Destroy();
		}

	}
}

