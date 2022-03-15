using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
  

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    public void getRoots(object sender, EventArgs args)
    {
        var a = Convert.ToDouble(entry1.Text);
        var b = Convert.ToDouble(entry3.Text);
        var c = Convert.ToDouble(entry5.Text);
        var d = Convert.ToDouble(entry7.Text);
        

        ///////////// Cardano ///////////////////
        ///


        //Facem substitutia x = (y - b ) / ( a * 3);
        //Obtinem y^3 + py + q =0;
        //p = c / a - b * b / 3 * a * a;
        //q = 2 * b ^ 3 / 27 * a ^ 3 - b * c / 3 * a ^2  + d / a;

        //double p = c / a - (b * b) / (3 * a * a);
        //double q = (2 * b * b * b) / (27 * a * a * a) - (b * c) / (3 * a * a) + (d / a);

        //Notam urmatoarele:
        //P = (-q/a +((p/3)^2 + (q/2)^2)^1/2)^1/3
        //Q = (-q/a - ((p/3)^2 + (q/2)^2)^1/2)^1/3
        //Notatie suplimentara: (q/2)^2)^1/2 = r

        //double r = Math.Sqrt(Math.Pow(p/3d,3)+ (q / 2d) * (q / 2d));
        //double qa = -q / a + r;
        //double P, Q;
        //if(qa > 0)
        //     P = Math.Pow(-q / a + r, 1/3d);
        //else
        //     P = Math.Pow(+q / a - r, 1/3d);

        //double aq = -q / a - r;
        //if(aq > 0)
        //     Q = Math.Pow((-q / a - r), 1/3d);
        //else
        //     Q = Math.Pow((+q / a + r), 1/3d);

        ////Cu notatiile de mai sus avem radacinile:
        ////x1 = P + Q;
        ////x2 = - (P + Q) / 2 + sqrt(3)(P - Q) / 2 * i;
        ////x3 = - (P + Q) / 2 - sqrt(3)(P - Q) / 2 * i;
        //double rad3 = Math.Sqrt(3);

        //double x1Re = P + Q;
        //double x2Re = (P + Q) / 2d;
        //double x3Re = (P + Q) / 2d;

        //double x1Im = 0;
        //double x2Im = (rad3*(P - Q) )/ 2d;
        //double x3Im = (rad3*(P - Q)) / 2d;

        //entry9.Text = Convert.ToString( x1Re + " + " + x1Im + "i");
        //entry11.Text = Convert.ToString(-x2Re + " + " + x2Im + "i");
        //entry13.Text = Convert.ToString(-x3Re + " + " + -x3Im + "i");


        //////////////////General Formula //////////////


        double delta_0 = (b * b) - (3 * a * c);
        double delta_1 = (2 * b * b * b) - (9 * a * b * c) + (27 * a * a * d);

        double root = Math.Sqrt(Math.Abs((delta_1 * delta_1) - (4 * delta_0 * delta_0 * delta_0)));
       

        double C = Math.Pow(Math.Abs(((delta_1 + root) / 2)), 0.33333333);

        double rad3 = Math.Sqrt(3);
        double ksi = (-1 + rad3) / 2;
        double frac = -1 / (3 * a);
       
        

        double x1Re = frac * (b + C + delta_0 / C);
        double x2Re = frac *(b - C/2 - delta_0 /C);
        double x3Re = frac * (b - C + 6 * delta_0 / (7 * C) );
        double x2Im = frac * ((rad3/2)*C -rad3/(4*C));
        double x3Im = frac * ((rad3/2)*C + rad3/(7*C));
        entry9.Text = Convert.ToString(x1Re + " + 0i");
        entry11.Text = Convert.ToString(x2Re + " + " + x2Im + " i");
        entry13.Text = Convert.ToString(x3Re + " + " + x3Im + " i");


    }

    public void getGraph(object sender, EventArgs e)
    {
        Window graph = new Window("Reprezentarea grafica a solutiilor");   
        graph.Show();
    }
}
