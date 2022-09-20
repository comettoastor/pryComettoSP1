using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComettoSP1_09_09_22_LP1_PAG_11
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        public void InicioFrmBienvenido()
        {
            MessageBox.Show("Acceso Correcto!");
            this.Hide();
            FrmBienvenido FrmBienvenido = new FrmBienvenido();
            FrmBienvenido.ShowDialog();
        }
        Int16 VarEntradasFallidas;
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Adm" && TxtContrseña.Text == "@1a" && (LstModulo.Text == "ADM" || LstModulo.Text == "COM" || LstModulo.Text == "VTA"))
                {
                InicioFrmBienvenido();
            }
            else 
            {
                if (TxtUsuario.Text == "John" && TxtContrseña.Text == "*2b" && LstModulo.Text == "SIST")
                {
                    InicioFrmBienvenido();
                }
                else
                {
                    if (TxtUsuario.Text == "Ceci" && TxtContrseña.Text == "*@3c" && (LstModulo.Text == "ADM" || LstModulo.Text == "VTA"))
                    {
                        InicioFrmBienvenido();
                    }
                    else
                    {
                        if (TxtUsuario.Text == "God" && TxtContrseña.Text == "*@#4d" && (LstModulo.Text == "ADM" || LstModulo.Text == "COM" || LstModulo.Text == "VTA" || LstModulo.Text == "SIST"))
                        {
                            InicioFrmBienvenido();
                        }
                        else
                        {
                            VarEntradasFallidas += 1;
                            MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                            if (VarEntradasFallidas == 2)
                            {
                                MessageBox.Show("Límite de fallas alcanzado, cerrando programa");
                                Application.Exit();
                            }
                        }
                    }
                }
            }             
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            TxtContrseña.Enabled = true;
            if (TxtUsuario.Text=="")
            {
                TxtContrseña.Enabled = false;
            }
        }

        private void TxtContrseña_TextChanged(object sender, EventArgs e)
        {
            LstModulo.Enabled = true;
            if (TxtContrseña.Text == "")
            {
                LstModulo.Enabled = false;
            }
        }

        private void LstModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnAceptar.Enabled = true;
            if (LstModulo.Text == "")
            {
                BtnAceptar.Enabled = false;
            }
        }

    }
}
