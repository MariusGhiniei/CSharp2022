
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.VBox vbox1;

	private global::Gtk.Label label1;

	private global::Gtk.HBox hbox3;

	private global::Gtk.VBox vbox4;

	private global::Gtk.HBox hbox5;

	private global::Gtk.Label label3;

	private global::Gtk.Entry entry1;

	private global::Gtk.VBox vbox6;

	private global::Gtk.HBox hbox13;

	private global::Gtk.Label label5;

	private global::Gtk.Entry entry3;

	private global::Gtk.HBox hbox15;

	private global::Gtk.Label label7;

	private global::Gtk.Entry entry5;

	private global::Gtk.HBox hbox17;

	private global::Gtk.Label label9;

	private global::Gtk.Entry entry7;

	private global::Gtk.VBox vbox2;

	private global::Gtk.HBox hbox7;

	private global::Gtk.Label label11;

	private global::Gtk.Entry entry9;

	private global::Gtk.HBox hbox9;

	private global::Gtk.Label label13;

	private global::Gtk.Entry entry11;

	private global::Gtk.HBox hbox11;

	private global::Gtk.Label label15;

	private global::Gtk.Entry entry13;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Button button2;

	private global::Gtk.Button button4;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.WidthRequest = 400;
		this.fixed1.HeightRequest = 500;
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.WidthRequest = 400;
		this.vbox1.HeightRequest = 500;
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Vom calcula ecuatia:\n\naX^3 + bX^2 + cX + d = 0,\n\nunde a, b, c, d sunt numere real" +
				"e cu a != 0\n");
		this.label1.Justify = ((global::Gtk.Justification)(2));
		this.vbox1.Add(this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		w1.Padding = ((uint)(15));
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 5;
		this.vbox4.BorderWidth = ((uint)(20));
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 10;
		this.hbox5.BorderWidth = ((uint)(10));
		// Container child hbox5.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("A = ");
		this.hbox5.Add(this.label3);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label3]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.WidthRequest = 50;
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '●';
		this.hbox5.Add(this.entry1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.entry1]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Padding = ((uint)(10));
		this.vbox4.Add(this.hbox5);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox5]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.vbox6 = new global::Gtk.VBox();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox13 = new global::Gtk.HBox();
		this.hbox13.Name = "hbox13";
		this.hbox13.Spacing = 10;
		this.hbox13.BorderWidth = ((uint)(10));
		// Container child hbox13.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("B = ");
		this.hbox13.Add(this.label5);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.label5]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox13.Gtk.Box+BoxChild
		this.entry3 = new global::Gtk.Entry();
		this.entry3.WidthRequest = 50;
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.IsEditable = true;
		this.entry3.InvisibleChar = '●';
		this.hbox13.Add(this.entry3);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.entry3]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Padding = ((uint)(10));
		this.vbox6.Add(this.hbox13);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox13]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox15 = new global::Gtk.HBox();
		this.hbox15.Name = "hbox15";
		this.hbox15.Spacing = 10;
		this.hbox15.BorderWidth = ((uint)(10));
		// Container child hbox15.Gtk.Box+BoxChild
		this.label7 = new global::Gtk.Label();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("C =");
		this.hbox15.Add(this.label7);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.label7]));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		// Container child hbox15.Gtk.Box+BoxChild
		this.entry5 = new global::Gtk.Entry();
		this.entry5.WidthRequest = 50;
		this.entry5.CanFocus = true;
		this.entry5.Name = "entry5";
		this.entry5.IsEditable = true;
		this.entry5.InvisibleChar = '●';
		this.hbox15.Add(this.entry5);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.entry5]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Padding = ((uint)(10));
		this.vbox6.Add(this.hbox15);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox15]));
		w10.Position = 1;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox17 = new global::Gtk.HBox();
		this.hbox17.Name = "hbox17";
		this.hbox17.Spacing = 10;
		this.hbox17.BorderWidth = ((uint)(10));
		// Container child hbox17.Gtk.Box+BoxChild
		this.label9 = new global::Gtk.Label();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("D =");
		this.hbox17.Add(this.label9);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox17[this.label9]));
		w11.Position = 0;
		w11.Expand = false;
		w11.Fill = false;
		// Container child hbox17.Gtk.Box+BoxChild
		this.entry7 = new global::Gtk.Entry();
		this.entry7.WidthRequest = 50;
		this.entry7.CanFocus = true;
		this.entry7.Name = "entry7";
		this.entry7.IsEditable = true;
		this.entry7.InvisibleChar = '●';
		this.hbox17.Add(this.entry7);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox17[this.entry7]));
		w12.Position = 1;
		w12.Expand = false;
		w12.Padding = ((uint)(10));
		this.vbox6.Add(this.hbox17);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox17]));
		w13.Position = 2;
		w13.Expand = false;
		w13.Fill = false;
		this.vbox4.Add(this.vbox6);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.vbox6]));
		w14.Position = 1;
		w14.Expand = false;
		w14.Fill = false;
		this.hbox3.Add(this.vbox4);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vbox4]));
		w15.Position = 0;
		// Container child hbox3.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 5;
		this.vbox2.BorderWidth = ((uint)(20));
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 20;
		this.hbox7.BorderWidth = ((uint)(20));
		// Container child hbox7.Gtk.Box+BoxChild
		this.label11 = new global::Gtk.Label();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("X1 = ");
		this.hbox7.Add(this.label11);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label11]));
		w16.Position = 0;
		w16.Expand = false;
		w16.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.entry9 = new global::Gtk.Entry();
		this.entry9.WidthRequest = 100;
		this.entry9.CanFocus = true;
		this.entry9.Name = "entry9";
		this.entry9.IsEditable = false;
		this.entry9.InvisibleChar = '●';
		this.hbox7.Add(this.entry9);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.entry9]));
		w17.Position = 1;
		w17.Expand = false;
		this.vbox2.Add(this.hbox7);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox7]));
		w18.Position = 0;
		w18.Expand = false;
		w18.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 20;
		this.hbox9.BorderWidth = ((uint)(20));
		// Container child hbox9.Gtk.Box+BoxChild
		this.label13 = new global::Gtk.Label();
		this.label13.Name = "label13";
		this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("X2 = ");
		this.hbox9.Add(this.label13);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.label13]));
		w19.Position = 0;
		w19.Expand = false;
		w19.Fill = false;
		// Container child hbox9.Gtk.Box+BoxChild
		this.entry11 = new global::Gtk.Entry();
		this.entry11.WidthRequest = 100;
		this.entry11.CanFocus = true;
		this.entry11.Name = "entry11";
		this.entry11.IsEditable = false;
		this.entry11.InvisibleChar = '●';
		this.hbox9.Add(this.entry11);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.entry11]));
		w20.Position = 1;
		w20.Expand = false;
		this.vbox2.Add(this.hbox9);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox9]));
		w21.Position = 1;
		w21.Expand = false;
		w21.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox11 = new global::Gtk.HBox();
		this.hbox11.Name = "hbox11";
		this.hbox11.Spacing = 20;
		this.hbox11.BorderWidth = ((uint)(20));
		// Container child hbox11.Gtk.Box+BoxChild
		this.label15 = new global::Gtk.Label();
		this.label15.Name = "label15";
		this.label15.LabelProp = global::Mono.Unix.Catalog.GetString("X3 = ");
		this.hbox11.Add(this.label15);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.label15]));
		w22.Position = 0;
		w22.Expand = false;
		w22.Fill = false;
		// Container child hbox11.Gtk.Box+BoxChild
		this.entry13 = new global::Gtk.Entry();
		this.entry13.WidthRequest = 100;
		this.entry13.CanFocus = true;
		this.entry13.Name = "entry13";
		this.entry13.IsEditable = false;
		this.entry13.InvisibleChar = '●';
		this.hbox11.Add(this.entry13);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.entry13]));
		w23.Position = 1;
		w23.Expand = false;
		this.vbox2.Add(this.hbox11);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox11]));
		w24.Position = 2;
		w24.Expand = false;
		w24.Fill = false;
		this.hbox3.Add(this.vbox2);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vbox2]));
		w25.Position = 1;
		this.vbox1.Add(this.hbox3);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
		w26.Position = 1;
		w26.Expand = false;
		w26.Fill = false;
		w26.Padding = ((uint)(15));
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button2 = new global::Gtk.Button();
		this.button2.WidthRequest = 150;
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString("Radacinile");
		this.hbox1.Add(this.button2);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button2]));
		w27.Position = 0;
		w27.Expand = false;
		w27.Fill = false;
		w27.Padding = ((uint)(20));
		// Container child hbox1.Gtk.Box+BoxChild
		this.button4 = new global::Gtk.Button();
		this.button4.WidthRequest = 150;
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString("Graficul( Coming Soon!)");
		this.hbox1.Add(this.button4);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button4]));
		w28.Position = 1;
		w28.Expand = false;
		w28.Fill = false;
		w28.Padding = ((uint)(20));
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w29.Position = 2;
		w29.Expand = false;
		w29.Fill = false;
		this.fixed1.Add(this.vbox1);
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 500;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button2.Clicked += new global::System.EventHandler(this.getRoots);
		this.button4.Clicked += new global::System.EventHandler(this.getGraph);
	}
}
