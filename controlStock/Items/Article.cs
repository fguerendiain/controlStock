using System;

namespace Items
{
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
		/// Modify the stock based on the recived amount
		/// </summary>
		/// <param name="amount">Amount of items</param>
		/// <param name="operation">If true add the amount, if false remove</param>
		public void ModifyStock(int amount, bool operation)
		{
			if (operation == true)
			{
				this._stock = this._stock + amount;
			}
			if (operation == false)
			{
				this._stock = this._stock - amount;
			}
		}

		/// <summary>
		/// Validates the description.
		/// </summary>
		/// <returns>The description.</returns>
		/// <param name="descriptionAttempt">Description attempt.</param>
		public string ValidateDescription(string descriptionAttempt)
		{
			return descriptionAttempt;
		}


		#endregion
	}
}

