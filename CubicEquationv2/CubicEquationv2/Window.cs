using System;
using Gtk;

namespace CubicEquationv2
{
    public partial class Window : Gtk.Window
    {
        public Window() :
                base(Gtk.WindowType.Toplevel)
        {
            Build();
        }

        protected void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        public void drawGraph(object sender,DeleteEventArgs a )
        {
            
        }

        
    }
}
