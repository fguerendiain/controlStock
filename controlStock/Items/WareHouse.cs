using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Items
{
	[Serializable]
	public class WareHouse : XMLMannager<List<Article>>
	{
		#region ---------------ATRIBBUTOS--------------
		private Sala _place;
		private List<Article> _stock;
		#endregion

		#region ---------------PROPIEDADES-------------
		public List<Article> Stock
		{
			get{return _stock;}
			set{_stock = value;}
		}

		#endregion

		#region --------------CONSTRUCTORES------------
		public WareHouse(){}

		public WareHouse (Sala sala)
		{
			this._place = sala;
			this._stock = new List<Article> ();
		}
		#endregion

		#region -----------------METODOS---------------


		// -------------------------ABM-----------------------------

		/// <summary>
		/// Adds the article.
		/// </summary>
		/// <returns><c>true</c>, if article was added, <c>false</c> otherwise.</returns>
		/// <param name="articulo">Articulo.</param>
		public bool AddArticle(Article articulo)
		{
			if (ValidateUniqueIdOnList (articulo.Id))
			{
				this._stock.Add (articulo);
				return true;
			}
			else
			{
				(this.SearchArticleBy (articulo)).ModifyStock (articulo.MaxStock,true);
			}
			return false;
		}

		/// <summary>
		/// Removes the article.
		/// </summary>
		/// <returns><c>true</c>, if article was removed, <c>false</c> otherwise.</returns>
		/// <param name="articulo">Articulo.</param>
		public bool RemoveArticle(Article articulo)
		{
			if(this._stock.Contains(articulo))
			{
				this._stock.Remove(articulo);
				return true;
			}
			else
			{
				(this.SearchArticleBy (articulo)).ModifyStock (articulo.MaxStock,false);
			}
			return false;
		}

		/// <summary>
		/// Modifies the attributes article.
		/// </summary>
		/// <param name="articulo">Articulo.</param>
		/// <param name="id">Identifier.</param>
		/// <param name="description">Description.</param>
		/// <param name="initialStock">Initial stock.</param>
		/// <param name="minStock">Minimum stock.</param>
		/// <param name="maxStock">Max stock.</param>
		public void ModifyArticle(Article articulo, int id, string description, int initialStock, int minStock, int maxStock)
		{
			(this.SearchArticleBy (articulo)).Id = id;
			(this.SearchArticleBy (articulo)).Description = description;
			(this.SearchArticleBy (articulo)).Stock = initialStock;
			(this.SearchArticleBy (articulo)).MinStock = minStock;
			(this.SearchArticleBy (articulo)).MaxStock = maxStock;
		}


		//--------------------------HERRAMIENTAS-------------------------------

		/// <summary>
		/// Searchs the article by ID.
		/// </summary>
		/// <returns>The article by.</returns>
		/// <param name="id">Identifier.</param>
		public Article SearchArticleBy(int id)
		{
			foreach (Article t in this._stock)
			{
				if (t.Id == id)
				{
					return t;
				}
			}
			return null;
		}

		/// <summary>
		/// Searchs the article by article.
		/// </summary>
		/// <returns>The article by.</returns>
		/// <param name="articulo">Articulo.</param>
		public Article SearchArticleBy(Article articulo)
		{
			foreach (Article t in this._stock)
			{
				if (t.Id == articulo.Id)
				{
					return t;
				}
			}
			return null;
		}



		//----------------------------VALIDACIONES------------------------------

		/// <summary>
		/// Validates the unique identifier on list.
		/// </summary>
		/// <returns><c>true</c> The ID is in use <c>false</c>The ID is free</returns>
		/// <param name="idToCompare">Identifier to compare.</param>
		public bool ValidateUniqueIdOnList(int idToCompare)
		{
			foreach (Article t in this._stock)
			{
				if (t.Id == idToCompare)
				{
					return false;
				}
			}
			return true;
		}

		#endregion

		#region ----------SOBRECARGA DE METODOS--------
		public override string ToString ()
		{
			StringBuilder cadena = new StringBuilder ();

			cadena.AppendLine ("DEPOSITO: " + this._place.ToString ());
			cadena.AppendLine ("");
			foreach (Article t in this._stock)
			{
				cadena.Append (t.ToString ());

			}

			return cadena.ToString();
		}

		#endregion

		#region ---------SOBRECARGA DE OPERADORES------
		#endregion

		#region ----------------ENUMERADOS-------------
		public enum Sala
		{
			Biyemas,
			Kandiko,
			Rebisco
		}
		#endregion

	}
}

