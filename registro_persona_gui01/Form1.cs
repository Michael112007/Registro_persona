using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro_persona_gui01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = false;
            btn_guardar.Enabled = true;
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
            txt_nombre.Clear();
            txt_edad.Clear();


            txt_nombre.Enabled = true;
            txt_edad.Enabled = true;
           
            txt_nombre.Focus();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = true;
            btn_guardar.Enabled = false;
            btn_editar.Enabled = true;
            btn_eliminar.Enabled = true;

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = false;
            btn_guardar.Enabled = true;
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = true;
            btn_guardar.Enabled = false;
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
            txt_nombre.Clear();
            txt_edad.Clear();

        


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_nombre.Enabled=false;
            txt_edad.Enabled=false;
        }
    }
}
