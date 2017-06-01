using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingLabels
{
    class LabelBouncer
    {

        //hold a reference to a object that is set to null
        public Label myLabel;

        //as the label bounces back and forth the value will change from true to false and back again
        public bool GoingForward = true;

        //method to check if the label has hit the edge of the form
        public void Move()
        {

            if (myLabel != null)
            {

                if (GoingForward == true)
                {

                    myLabel.Left += 5;

                    if (myLabel.Left >= myLabel.Parent.Width - myLabel.Width)
                    {

                        GoingForward = false;
                    }
                }
                else
                {
                    myLabel.Left -= 5;

                    if (myLabel.Left <= 0)
                    {

                        GoingForward = true;
                    }
                }
            }
        }
    }
}
