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
        //Arranque del Formulario FrmLogin
        public FrmLogin()
        {
            InitializeComponent();
        }

        //Cierra la aplicación en caso de hacer click en BtnCancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //Procedimiento público que despliega un mensaje si el Acceso es correcto y abre el Formulario FrmBienvenido
        public void InicioFrmBienvenido()
        {
            MessageBox.Show("Acceso Correcto!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            FrmBienvenido FrmBienvenido = new FrmBienvenido();
            FrmBienvenido.ShowDialog();
        }

        //Variable Global Contadora para las entradas fallidas
        Int16 VarEntradasFallidas;

        //Checkeo de los datos ingresados para el acceso mediante BtnAceptar
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Anidación de If que comprueban los datos ingresados (si son correctos llaman al procedimiento InicioFrmBienvenido)
            if (TxtUsuario.Text == "Adm" && TxtPassword.Text == "@1a" && (LstModulo.Text == "ADM" || LstModulo.Text == "COM" || LstModulo.Text == "VTA"))
            {
                InicioFrmBienvenido();
            }
            else 
            {
                if (TxtUsuario.Text == "John" && TxtPassword.Text == "*2b" && LstModulo.Text == "SIST")
                {
                    InicioFrmBienvenido();
                }
                else
                {
                    if (TxtUsuario.Text == "Ceci" && TxtPassword.Text == "*@3c" && (LstModulo.Text == "ADM" || LstModulo.Text == "VTA"))
                    {
                        InicioFrmBienvenido();
                    }
                    else
                    {
                        if (TxtUsuario.Text == "God" && TxtPassword.Text == "*@#4d" && (LstModulo.Text == "ADM" || LstModulo.Text == "COM" || LstModulo.Text == "VTA" || LstModulo.Text == "SIST"))
                        {
                            InicioFrmBienvenido();
                        }
                        else
                        {
                            //Los datos ingresados no son correctos, se suma 1 entrada fallida y se muestra mensaje de advertencia
                            VarEntradasFallidas += 1;
                            MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado", "Advertencia " + VarEntradasFallidas + "/2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //Si ocurren dos entradas fallidas la aplicación muestra advertencia y se cierra
                            if (VarEntradasFallidas == 2)
                            {
                                MessageBox.Show("Límite de fallas alcanzado, cerrando programa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Application.Exit();
                            }
                        }
                    }
                }
            }             
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            TxtPassword.Enabled = true;
            if (TxtUsuario.Text == "")
            {
                TxtPassword.Enabled = false;
                LstModulo.Enabled = false;
                BtnAceptar.Enabled = false;
            }
            if (TxtUsuario.Text != "" && TxtPassword.Text != "")
            {
                LstModulo.Enabled = true;
            }
            if (TxtUsuario.Text != "" && TxtPassword.Text != "" && LstModulo.SelectedIndex != -1)
            {
                BtnAceptar.Enabled = true;
            }
        }

        private void TxtContrseña_TextChanged(object sender, EventArgs e)
        {
            LstModulo.Enabled = true;
            if (TxtPassword.Text == "")
            {
                LstModulo.Enabled = false;
                BtnAceptar.Enabled = false;
            }
            if (TxtPassword.Text != "" && LstModulo.SelectedIndex != -1)
            {
                BtnAceptar.Enabled = true;
            }
        }

        private void LstModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnAceptar.Enabled = true;
            if (LstModulo.SelectedIndex == -1)
            {
                BtnAceptar.Enabled = false;
            }
        }

    }
}
