﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace On4Hotel.Mira.Interface.Formularios
{
    public partial class FrmAlugar : Form
    {
        public FrmAlugar()
        {
            InitializeComponent();
        }
        
        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmConsultarProduto fcp = new FrmConsultarProduto();
            fcp.ShowDialog();
        }

    }
}
