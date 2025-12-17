using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp1
{
    
    
        public class Flop
        {
            List<Panel> Panels = new List<Panel>();
            

            public Flop()
            {
        }
             public Flop(params Panel[] panels) { 
            Panels.AddRange(panels);

        }
        //Bringing panel to front and then setting all panels to visible false other than chosen index
        public void FlopPage(int number)
            {


            foreach (var element in Panels)
            {
                var x = Panels.IndexOf(element);
                element.Visible = (x == number);
            }

            var selected = Panels[number];
            for (Control cur = selected; cur != null; cur = cur.Parent)
            {
                if (cur is Form) break; // stop before touching the Form's Visible
                cur.Visible = true;
                cur.BringToFront();
            }

            selected.BringToFront();

        }
    }
    }
