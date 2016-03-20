using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Lavirint
{
    public partial class DisplayPanel : UserControl
    {
        public DisplayPanel()
        {
            InitializeComponent();
            State.lavirint = new int[Main.brojVrsta,Main.brojKolona];
            lavirintPoruke = new String[Main.brojVrsta][];
            for (int i = 0; i < Main.brojVrsta; i++)
            {
                lavirintPoruke[i] = new String[Main.brojKolona];
            }
            icon = Properties.Resources.robot2;
        }

       
        public String[][] lavirintPoruke;
        public int X, Y;
        public int iconI = 0;
        public int iconJ = 0;
        Image icon = null;

        public void resetLavirintPoruke() {
            lavirintPoruke = new String[Main.brojVrsta][];
            for (int i = 0; i < Main.brojVrsta; i++)
            {
                lavirintPoruke[i] = new String[Main.brojKolona];
            }
        }

        //TODO 3.1: Prosiriti metodu tako da se napravi novi Color objekat npr: Color.MediumBlue
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics gr = e.Graphics;
            gr.FillRectangle(Brushes.White, this.ClientRectangle);

            Rectangle rec = this.ClientRectangle;

            // nacrtaj grid
            int width = rec.Width;
            int height = rec.Height;
            int dx = (int)(width / Main.brojKolona);
            int dy = (int)(height / Main.brojVrsta);

            for (int j = 0; j < Main.brojKolona; j++)
            {
                Color c = Color.FromArgb(40, Color.Gray);
                int xx = dx * j;
                int y0 = 0;
                int yH = height;
                gr.DrawLine(new Pen(c), xx, y0, xx, yH);
            }
            for (int i = 0; i < Main.brojVrsta; i++)
            {
                Color c = Color.FromArgb(40, Color.Gray);
                int yy = dy * i;
                int x0 = 0;
                int xH = width;
                gr.DrawLine(new Pen(c), x0, yy, xH, yy);
            }

            for (int i = 0; i < Main.brojVrsta; i++)
            {
                for (int j = 0; j < Main.brojKolona; j++)
                {
                    int xx = (int)(dx / 2) + dx * j;
                    int yy = (int)(dy / 2) + dy * i;

                    Font f = new Font(FontFamily.GenericSerif, 8);
                    Rectangle r = new Rectangle(dx * j + 2, dy * i + 2, dx - 4, dy - 4);
                    Color cc1 = Color.FromArgb(100, Color.White);
                    Color cc2 = Color.FromArgb(100, Color.White);
                    if (i == X && j == Y)
                    {
                        cc1 = Color.FromArgb(100, Color.YellowGreen);
                        cc2 = Color.FromArgb(20, Color.YellowGreen);
                    }
                    int tt = State.lavirint[i,j];
                    switch (tt)
                    {
                        case 1:
                            cc2 = Color.FromArgb(100, Color.Gray);
                            break;
                        case 2:
                            cc2 = Color.FromArgb(100, Color.Green);
                            break;
                        case 3:
                            cc2 = Color.FromArgb(100, Color.Red);
                            break;
                    }
                    String ttS = lavirintPoruke[i][j];
                    gr.FillRectangle(new SolidBrush(cc2), r);
                    gr.DrawRectangle(new Pen(cc1, 2), r);
                    SizeF sf = gr.MeasureString("" + ttS, f);
                    gr.DrawString("" + ttS, f, Brushes.Black, xx - sf.Width / 2, yy - sf.Height / 2);
                }
            }

            // nacrtati iconu
            gr.DrawImage(icon, dx * iconJ + dx/2-icon.Width/2, dy * iconI + dy/2-icon.Height/2);
        }

        
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int eX = e.X;
            int eY = e.Y;
            Rectangle rec = this.ClientRectangle;
            int width = rec.Width;
            int height = rec.Height;
            int dx = (int)(width / Main.brojKolona);
            int dy = (int)(height / Main.brojVrsta);

            int j = eX / dx;
            int i = eY / dy;

            if (X != i || Y != j)
            {
                int sX = X;
                int sY = Y;
                X = i;
                Y = j;
                InvalidateAdv(X, Y);
                InvalidateAdv(sX, sY);
            }
        }

        //TODO 3.2: Prosiriti metodu 
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            int eX = e.X;
            int eY = e.Y;
            Rectangle rec = this.ClientRectangle;
            int width = rec.Width;
            int height = rec.Height;
            int dx = (int)(width / Main.brojKolona);
            int dy = (int)(height / Main.brojVrsta);

            int j = eX / dx;
            int i = eY / dy;
            int tt = State.lavirint[i,j];
            switch (tt)
            {
                case 0:
                    tt = 1;
                    break;
                case 1:
                    tt = 2;
                    break;
                case 2:
                    tt = 3;
                    break;
                case 3:
                    tt = 0;
                    break;
            }                    

            State.lavirint[i,j] = tt;
            InvalidateAdv(i, j);
        }

        protected void moveIcon(int dI, int dJ) { 
            int nI = iconI+dI;
            int nJ = iconJ + dJ;
            if (nI < 0)
                nI = Main.brojVrsta - 1;
            if (nI > Main.brojVrsta - 1)
                nI = 0;
            if (nJ < 0)
                nJ = Main.brojKolona - 1;
            if (nJ > Main.brojKolona - 1)
                nJ = 0;
            int sIconI = iconI;
            int sIconJ = iconJ;
            // ovaj deo je da se spreci prolazak kroz zidove
            if (State.lavirint[nI,nJ] != 1) {
                iconI = nI;
                iconJ = nJ;
                InvalidateAdv(iconI, iconJ);
                InvalidateAdv(sIconI, sIconJ);
            }            
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            lavirintPoruke[iconI][iconJ] = lavirintPoruke[iconI][iconJ] + e.KeyChar;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyData == Keys.Back) {
                int n = lavirintPoruke[iconI][iconJ].Length;
                if(n > 1){
                    lavirintPoruke[iconI][iconJ] = lavirintPoruke[iconI][iconJ].Substring(0, n - 2); 
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                moveIcon(0, -1);
                return true;
            }
            else if (keyData == Keys.Right)
            {
                moveIcon(0, 1);
                return true;
            }
            else if (keyData == Keys.Down)
            {
                moveIcon(1, 0);
                return true;
            }
            else if (keyData == Keys.Up)
            {
                moveIcon(-1, 0);
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        public void InvalidateAdv(int i, int j)
        {
            Rectangle rec = this.ClientRectangle;
            int width = rec.Width;
            int height = rec.Height;
            int dx = (int)(width / Main.brojKolona);
            int dy = (int)(height / Main.brojVrsta);
            Rectangle tt1 = new Rectangle(j * dx, i * dy, dx, dy);
            this.Invalidate(tt1);
        }

    }
}
