using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento_Chris
{
    public partial class Form1 : Form
    {
        ConexionComedorEntities BD = new ConexionComedorEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);
            Empleado existe = BD.Empleado.FirstOrDefault(em => em.IDempleado == ID && em.Contraseña == txtPass.Text);
            if (existe != null)
            {

                MessageBox.Show("Bienvenido  " + existe.Nombre_Empleado);
              /*  string Rol = cmbRol.Text.Trim();
                if (Rol == "Administrador")
                {*/

                    Menu_Principal Mp = new Menu_Principal();
                    Mp.ShowDialog();

                }/*
                if (Rol == "Alumno")
                {
                    Menu_alumnos Mp = new Menu_alumnos(BaseDatos);
                    limpiar();
                    Mp.Show();
                    this.Hide();
                }

            }
            else
                MessageBox.Show("No se encontro registrese por favor");
                */
    }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
