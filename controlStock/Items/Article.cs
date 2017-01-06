using System;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Items
{
	[Serializable]
	public class Article
	{
		#region ---------------ATRIBBUTOS--------------
		private int _id;
		private string _description;
		private int _stock;
		private int _minStock;
		private int _maxStock;
		#endregion

		#region ---------------PROPIEDADES-------------
		public int Id
		{
			get{return this._id;}

			set{this._id = value;}
		}

		public string Description
		{
			get{return this._description;}
			set{this._description = ValidateDescription(value);}
		}

		public int Stock
		{
			get{return this._stock;}

			set
			{
				if (value < 0) {
					this._stock = 0;
				} else {
					this._stock = value;
				}
			}
		}

		public int MinStock
		{
			get{return this._minStock;}

			set
			{
				if (value < 0) {
					this._minStock = 0;
				} else {
					this._minStock = value;
				}
			}
		}

		public int MaxStock
		{
			get{return this._maxStock;}
			
			set
			{
				if (value < 0) {
					this._maxStock = 0;
				} else {
					this._maxStock = value;
				}
			}
		}
		#endregion

		#region --------------CONSTRUCTORES------------
		public Article(){}

		public Article (int id, string description)
		{
			this.Id = id;
			this.Description = description;
			this._stock = 0;
			this._minStock = 0;
			this._maxStock = 0;
		}

		public Article (int id, string description, int initialStock):this(id,description)
		{
			this.Stock = initialStock;
		}

		public Article (int id, string description, int initialStock, int minStock, int maxStock):this(id,description,initialStock)
		{
			this.MinStock = minStock;
			this.MaxStock = maxStock;
		}
		#endregion

		#region -----------------METODOS---------------
		/// <summary>
		/// Validates the description.
		/// </summary>
		/// <returns>The description.</returns>
		/// <param name="descriptionAttempt">Description attempt.</param>
		public string ValidateDescription(string descriptionAttempt)
		{
			return descriptionAttempt;
		}

		/// <summary>
		/// Prints the complete info article.
		/// </summary>
		/// <returns>The article.</returns>
		public string PrintArticle ()
		{
			StringBuilder cadena = new StringBuilder ();
			cadena.AppendLine ("ID:\t\t\t\t\t" + this.Id.ToString().PadLeft(4,'0'));
			cadena.AppendLine ("DESCRIPCION:\t\t" + this.Description);
			cadena.AppendLine ("STOCK:\t\t\t\t" + this.Stock);
			cadena.AppendLine ("-----------------------------");
			cadena.AppendLine ("STOCK MINIMO:\t\t" + this.MinStock);
			cadena.AppendLine ("STOCK MAXIMO:\t" + this.MaxStock);
			return cadena.ToString();
		}

		#endregion

		#region ----------SOBRECARGA DE METODOS--------
		/// <summary>
		/// Prints only basic info article
		/// </summary>
		/// <returns>A <see cref="System.String"/> that represents the current <see cref="Items.Article"/>.</returns>
		public override string ToString ()
		{
			StringBuilder cadena = new StringBuilder ();
			cadena.AppendLine ("ID: " + this.Id.ToString().PadLeft(4,'0') + " | S: " + this.Stock.ToString().PadLeft(2,'0') + " | " + this.Description);
			return cadena.ToString();
		}

		#endregion

	}
}

