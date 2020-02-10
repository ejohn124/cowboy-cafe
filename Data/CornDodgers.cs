using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CornDodgers: Side
    {
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 717;
                }

            }
        }
    }
}
