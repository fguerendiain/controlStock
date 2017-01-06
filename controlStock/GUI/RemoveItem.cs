using System;
using Items;
using Gtk;

namespace GUI
{
	public partial class RemoveItem : Gtk.Window
	{


		WareHouse activeWareHouse;
		WareHouse auxiliarUnmodifyWareHouse;
		string archivoXML;
		Article auxArticle;


		public RemoveItem (WareHouse activeWareHouseParameter, string archivoXMLParameter):base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.activeWareHouse = activeWareHouseParameter;
			this.auxiliarUnmodifyWareHouse = activeWareHouseParameter;
			this.archivoXML = archivoXMLParameter;
		}

		protected void OnBtnRemoveItemGetArticleClicked (object sender, EventArgs e)
		{
			int idtoSearch;
			int.TryParse (this.entRemoveItemGetId.Text.ToString (), out idtoSearch);
			auxArticle = activeWareHouse.SearchArticleBy (idtoSearch);
			if (auxArticle.Id == 0)
			{
				this.Hide();
				MessageDialog errorMessage = new MessageDialog (this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "El articulo no existe");
				errorMessage.Run ();
				errorMessage.Destroy ();
				this.backToStockAdmin (auxiliarUnmodifyWareHouse);
			}
			this.txtRemoveItemInfo.Buffer.Text = auxArticle.PrintArticle ();
		}

		protected void OnBtnRemoveItemOkClicked (object sender, EventArgs e)
		{
			//verifico si puedo o no eliminar le articulo
			if (!activeWareHouse.RemoveArticle (auxArticle))
			{
				this.Hide();
				MessageDialog errorMessage = new MessageDialog (this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "No se puede eliminar el articulo");
				errorMessage.Run ();
				errorMessage.Destroy ();
				this.backToStockAdmin (auxiliarUnmodifyWareHouse);
			}
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

