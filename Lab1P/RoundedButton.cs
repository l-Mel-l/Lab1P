using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1P {
    class RoundedButton:Button {
        protected override void OnPaint(PaintEventArgs pEvent) {
            GraphicsPath graphics = new GraphicsPath();  
            graphics.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(graphics);
            base.OnPaint(pEvent);
        }
    }
}
