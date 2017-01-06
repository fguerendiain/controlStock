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
		private Empresa _place;
		private List<Article> _stock;
		#endregion

		#region ---------------PROPIEDADES-------------
		public List<Article> Stock
		{
			get{return _stock;}
			set{_stock = value;}
		}

		public string Sala
		{
			get{return this._place.ToString ();}
		}

		#endregion

		#region --------------CONSTRUCTORES------------
		public WareHouse(){}

		public WareHouse (Empresa sala)
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
			return false;
		}

		/// <summary>
		/// Modify the stock based on the recived amount
		/// </summary>
		/// <param name="amount">Amount of items</param>
		/// <param name="operation">If true add the amount, if false remove</param>
		public bool ModifyStock(Article serchArticle, int amount, bool operation)
		{
			if (operation == true)
			{
				(this.SearchArticleBy(serchArticle)).Stock += amount;
				return true;
			}
			if (operation == false)
			{
				(this.SearchArticleBy(serchArticle)).Stock -= amount;
				if ((this.SearchArticleBy (serchArticle)).Stock < 0)
				{
					(this.SearchArticleBy(serchArticle)).Stock = 0;
					
				}
				return true;
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
			return new Article (0, "null");
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
			return new Article(0,"null");
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

			cadena.AppendLine ("Deposito:\t--" + this._place.ToString().ToUpper() + "--");
			cadena.AppendLine ("");
	
//			this._stock.Sort ();   averiguar como hacer el metodo para ordenar por id

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
		public enum Empresa
		{
			Biyemas,
			Kandiko,
			Rebisco
		}
		#endregion

	}
}

