using System;
using Items;
using Gtk;

namespace GUI
{
	public partial class AddItem : Gtk.Window
	{
		WareHouse activeWareHouse;
		WareHouse auxiliarUnmodifyWareHouse;
		string archivoXML;


		public AddItem (WareHouse activeWareHouseParameter, string archivoXMLParameter) :base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.archivoXML = archivoXMLParameter;
			this.auxiliarUnmodifyWareHouse = activeWareHouseParameter;
			this.activeWareHouse = activeWareHouseParameter;
		}

		protected void OnBtnAddItemOkClicked (object sender, EventArgs e)
		{
			int auxNewId;
			string auxNewDescription;
			int auxNewStock;
			int auxNewMinStock;
			int auxNewMaxStock;

			int.TryParse(this.entAddItemId.Text.ToString(), out auxNewId);
			auxNewDescription = this.entAddItemDescription.Text.ToString();
			int.TryParse(this.entAddItemStock.Text.ToString(), out auxNewStock);
			int.TryParse(this.entAddItemMinStock.Text.ToString(), out auxNewMinStock);
			int.TryParse(this.entAddItemMaxStock.Text.ToString(),out auxNewMaxStock);

			Article auxNewArticle = new Article (auxNewId,auxNewDescription,auxNewStock,auxNewMinStock,auxNewMaxStock);

			//valida si pudo o no cargar el nuevo articulo
			if (!activeWareHouse.AddArticle (auxNewArticle))
			{
				this.Hide();
				MessageDialog errorMessage = new MessageDialog (this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "No se puede agregar el articulo");
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

