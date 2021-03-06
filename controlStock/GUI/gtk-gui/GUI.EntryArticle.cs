
// This file has been generated by the GUI designer. Do not modify.
namespace GUI
{
	public partial class EntryArticle
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Image image9;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Alignment alignment3;
		private global::Gtk.Label lblEntryArticleGetId;
		private global::Gtk.Alignment alignment5;
		private global::Gtk.Entry entEntryArticleGetId;
		private global::Gtk.Alignment alignment4;
		private global::Gtk.Button btnEntryArticleGetId;
		private global::Gtk.Alignment alignment6;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView txtEntryArticleInfo;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Alignment alignment7;
		private global::Gtk.Label lblEntryArticleQuantity;
		private global::Gtk.Alignment alignment8;
		private global::Gtk.Entry entEntryArticleQuantity;
		private global::Gtk.Alignment alignment9;
		private global::Gtk.Button btnEntryArticleOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget GUI.EntryArticle
			this.Name = "GUI.EntryArticle";
			this.Title = global::Mono.Unix.Catalog.GetString ("Ingreso de Mercaderia");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child GUI.EntryArticle.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.image9 = new global::Gtk.Image ();
			this.image9.Name = "image9";
			this.image9.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./logo.jpg"));
			this.vbox2.Add (this.image9);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.image9]));
			w1.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.alignment3.LeftPadding = ((uint)(10));
			// Container child alignment3.Gtk.Container+ContainerChild
			this.lblEntryArticleGetId = new global::Gtk.Label ();
			this.lblEntryArticleGetId.Name = "lblEntryArticleGetId";
			this.lblEntryArticleGetId.LabelProp = global::Mono.Unix.Catalog.GetString ("ID");
			this.alignment3.Add (this.lblEntryArticleGetId);
			this.hbox2.Add (this.alignment3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.alignment3]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment5.Name = "alignment5";
			this.alignment5.RightPadding = ((uint)(10));
			// Container child alignment5.Gtk.Container+ContainerChild
			this.entEntryArticleGetId = new global::Gtk.Entry ();
			this.entEntryArticleGetId.CanFocus = true;
			this.entEntryArticleGetId.Name = "entEntryArticleGetId";
			this.entEntryArticleGetId.IsEditable = true;
			this.entEntryArticleGetId.InvisibleChar = '●';
			this.alignment5.Add (this.entEntryArticleGetId);
			this.hbox2.Add (this.alignment5);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.alignment5]));
			w5.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.alignment4.RightPadding = ((uint)(10));
			// Container child alignment4.Gtk.Container+ContainerChild
			this.btnEntryArticleGetId = new global::Gtk.Button ();
			this.btnEntryArticleGetId.CanFocus = true;
			this.btnEntryArticleGetId.Name = "btnEntryArticleGetId";
			this.btnEntryArticleGetId.UseUnderline = true;
			this.btnEntryArticleGetId.Label = global::Mono.Unix.Catalog.GetString ("...");
			this.alignment4.Add (this.btnEntryArticleGetId);
			this.hbox2.Add (this.alignment4);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.alignment4]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment6 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment6.Name = "alignment6";
			this.alignment6.LeftPadding = ((uint)(10));
			this.alignment6.RightPadding = ((uint)(10));
			// Container child alignment6.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.txtEntryArticleInfo = new global::Gtk.TextView ();
			this.txtEntryArticleInfo.CanFocus = true;
			this.txtEntryArticleInfo.Name = "txtEntryArticleInfo";
			this.txtEntryArticleInfo.Editable = false;
			this.GtkScrolledWindow.Add (this.txtEntryArticleInfo);
			this.alignment6.Add (this.GtkScrolledWindow);
			this.vbox2.Add (this.alignment6);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment6]));
			w11.Position = 2;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.alignment7 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment7.Name = "alignment7";
			this.alignment7.LeftPadding = ((uint)(10));
			// Container child alignment7.Gtk.Container+ContainerChild
			this.lblEntryArticleQuantity = new global::Gtk.Label ();
			this.lblEntryArticleQuantity.Name = "lblEntryArticleQuantity";
			this.lblEntryArticleQuantity.LabelProp = global::Mono.Unix.Catalog.GetString ("Cantidad");
			this.alignment7.Add (this.lblEntryArticleQuantity);
			this.hbox3.Add (this.alignment7);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.alignment7]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.alignment8 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment8.Name = "alignment8";
			this.alignment8.RightPadding = ((uint)(10));
			// Container child alignment8.Gtk.Container+ContainerChild
			this.entEntryArticleQuantity = new global::Gtk.Entry ();
			this.entEntryArticleQuantity.CanFocus = true;
			this.entEntryArticleQuantity.Name = "entEntryArticleQuantity";
			this.entEntryArticleQuantity.IsEditable = true;
			this.entEntryArticleQuantity.InvisibleChar = '●';
			this.alignment8.Add (this.entEntryArticleQuantity);
			this.hbox3.Add (this.alignment8);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.alignment8]));
			w15.Position = 1;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
			w16.Position = 3;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment9 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment9.Name = "alignment9";
			this.alignment9.LeftPadding = ((uint)(10));
			this.alignment9.RightPadding = ((uint)(10));
			this.alignment9.BottomPadding = ((uint)(5));
			// Container child alignment9.Gtk.Container+ContainerChild
			this.btnEntryArticleOk = new global::Gtk.Button ();
			this.btnEntryArticleOk.CanFocus = true;
			this.btnEntryArticleOk.Name = "btnEntryArticleOk";
			this.btnEntryArticleOk.UseUnderline = true;
			this.btnEntryArticleOk.Label = global::Mono.Unix.Catalog.GetString ("Aceptar");
			this.alignment9.Add (this.btnEntryArticleOk);
			this.vbox2.Add (this.alignment9);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment9]));
			w18.Position = 4;
			w18.Expand = false;
			w18.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 341;
			this.DefaultHeight = 320;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.btnEntryArticleGetId.Clicked += new global::System.EventHandler (this.OnBtnEntryArticleGetIdClicked);
			this.btnEntryArticleOk.Clicked += new global::System.EventHandler (this.OnBtnEntryArticleOkClicked);
		}
	}
}
