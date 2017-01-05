using System;
using Items;

namespace GUI
{
	public partial class AddItem : Gtk.Window
	{
		WareHouse auxDeposito;
		string selectedWareHouse;
		string archivoXMLBiyemas = "../../../BBiyemas.xml";
		string archivoXMLKandiko = "../../../BKandiko.xml";
		string archivoXMLRebisco = "../../../BRebisco.xml";


		public AddItem (WareHouse activeWareHouse, string selectedWareHouseParameter) :base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			auxDeposito = activeWareHouse;
			selectedWareHouse = selectedWareHouseParameter;

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
			auxDeposito.AddArticle (auxNewArticle);


			switch (selectedWareHouse)
			{
				case "Biyemas":
			{
				auxDeposito.Guardar (archivoXMLBiyemas, auxDeposito.Stock);
			}
				break;				

				case "Kandiko":
			{
				auxDeposito.Guardar (archivoXMLKandiko, auxDeposito.Stock);
			}
				break;				

				case "Rebisco":
			{
				auxDeposito.Guardar (archivoXMLRebisco, auxDeposito.Stock);
			}
				break;		
			}

			StockAdmin backStockAdmin = new StockAdmin (auxDeposito, selectedWareHouse);
			backStockAdmin.Show ();
			this.Destroy();

		}
	}
}

