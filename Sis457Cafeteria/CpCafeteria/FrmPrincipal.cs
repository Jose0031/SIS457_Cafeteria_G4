using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CpCafeteria
{
    public partial class FrmPrincipal : Form
    {
        //se declara un campos privado para almacenar el button actual
        private IconButton currentbtn;
        //se declara un panel privado para aplicar un borde izquierdo al button
        private Panel leftBorderBtn;
        public FrmPrincipal()
        {
            InitializeComponent();
            //inicializamos el panel
            leftBorderBtn = new Panel();
            //asignamos un tamaño 
            leftBorderBtn.Size = new Size(7, 50);
            //agregamos el panel bordeIzquierdo a los controlers del pnlMenu
            pnlMenu.Controls.Add(leftBorderBtn);
        }

        //estructura de colores para cada button
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(253, 138, 114);
            public static Color color3 = Color.FromArgb(95, 77, 221);
            public static Color color4 = Color.FromArgb(249, 88, 155);
            public static Color color5 = Color.FromArgb(199, 0, 57);
            public static Color color6 = Color.FromArgb(255, 87, 51);
        }

        //Metodo para resaltar los buttons
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //button
                DisableButton();
                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = Color.FromArgb(57, 20, 1);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentbtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(57, 20, 1);
                currentbtn.ForeColor = Color.Gainsboro;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.Gainsboro;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int LX, LY;

        private void pbxMaximizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            pbxRestaurar.Visible = true;
            pbxMaximizar.Visible = false;
        }

        private void pbxRestaurar_Click(object sender, EventArgs e)
        {
            this.Location = new Point(LX, LY);
            this.Size = new Size(960, 550);
            pbxRestaurar.Visible = false;
            pbxMaximizar.Visible = true;
        }
        int posX = 0;
        int posY = 0;

        private void pnlBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void pbxSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
