
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Button buttonClear;
	private global::Gtk.Button buttonUcase;
	private global::Gtk.Button buttonLcase;
	private global::Gtk.Button buttonSave;
	private global::Gtk.TextView textview1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonClear = new global::Gtk.Button ();
		this.buttonClear.CanFocus = true;
		this.buttonClear.Name = "buttonClear";
		this.buttonClear.UseUnderline = true;
		this.buttonClear.Label = global::Mono.Unix.Catalog.GetString ("Clear");
		this.hbox1.Add (this.buttonClear);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonClear]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonUcase = new global::Gtk.Button ();
		this.buttonUcase.CanFocus = true;
		this.buttonUcase.Name = "buttonUcase";
		this.buttonUcase.UseUnderline = true;
		this.buttonUcase.Label = global::Mono.Unix.Catalog.GetString ("Upper Case");
		this.hbox1.Add (this.buttonUcase);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonUcase]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonLcase = new global::Gtk.Button ();
		this.buttonLcase.CanFocus = true;
		this.buttonLcase.Name = "buttonLcase";
		this.buttonLcase.UseUnderline = true;
		this.buttonLcase.Label = global::Mono.Unix.Catalog.GetString ("Lower Case");
		this.hbox1.Add (this.buttonLcase);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonLcase]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonSave = new global::Gtk.Button ();
		this.buttonSave.CanFocus = true;
		this.buttonSave.Name = "buttonSave";
		this.buttonSave.UseUnderline = true;
		this.buttonSave.Label = global::Mono.Unix.Catalog.GetString ("Save");
		this.hbox1.Add (this.buttonSave);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonSave]));
		w4.Position = 3;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.textview1 = new global::Gtk.TextView ();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.vbox1.Add (this.textview1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.textview1]));
		w6.Position = 1;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.buttonClear.Clicked += new global::System.EventHandler (this.OnButtonClearClicked);
		this.buttonUcase.Clicked += new global::System.EventHandler (this.OnButtonUcaseClicked);
		this.buttonLcase.Clicked += new global::System.EventHandler (this.OnButtonLcaseClicked);
		this.buttonSave.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
	}
}
