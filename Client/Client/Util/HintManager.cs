using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Util
{
    class HintManager
    {
        private ArrayList textBoxes;
        private ArrayList labels;
        public HintManager()
        {
            textBoxes = new ArrayList();
            labels = new ArrayList();
        }
        public void SetPair(TextBox textBox,Label label)
        {
            textBoxes.Add(textBox);
            labels.Add(label);
        }
        public void disableHint(TextBox textBox)
        {
            int index = 0;
            foreach(TextBox t in textBoxes)
            {
                if (t == textBox) {
                    
                    t.Select();
                    break;
                }
                index++;

            }
            int counter = 0;
            foreach(Label l in labels)
            {
                if (counter == index) { l.Visible = false;break; }
                counter++;
            }
        }
        public void disableHint(Label label)
        {
            int index = 0;
            foreach (Label l in labels)
            {
                if (l == label)
                {
                    l.Visible = false; break;
                
                }
                index++;

            }
            int counter = 0;
            foreach (TextBox t in textBoxes)
            {
                if (counter == index) {
                    t.Select();
                    break;
                }
                counter++;
            }
        }
        public void enableHint(TextBox textBox)
        {
            int index = 0;
            bool set = false;
            foreach (TextBox t in textBoxes)
            {
                if (t == textBox)
                {
                    set = (t.Text == "");
                    break;
                }
                index++;

            }
            int counter = 0;
            foreach (Label l in labels)
            {
                if (counter == index && set) { l.Visible = true; break; }
                counter++;
            }
        }

       
    }
}
