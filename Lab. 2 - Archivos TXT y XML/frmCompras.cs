﻿using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab._2___Archivos_TXT_y_XML
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofdArchivo = new OpenFileDialog();
                ofdArchivo.Filter = "Archivo TXT | *.txt";

                if (ofdArchivo.ShowDialog() == DialogResult.OK)
                {
                    this.tbRuta.Text = ofdArchivo.FileName.Trim();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Carga de compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.tbRuta.Text.Trim()))
                {
                    MessageBox.Show("Favor seleccionar ruta del archivo", "Carga de compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!File.Exists(this.tbRuta.Text.Trim()))
                {
                    MessageBox.Show("Archivo no encontrado", "Carga de compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // toda la funcionalidad requerida
                    BLL.ArchivosTXT archivosTXT = new BLL.ArchivosTXT();

                    List<BLL.Compra> compras = archivosTXT.Leer(this.tbRuta.Text.Trim());

                    foreach (var compra in compras)
                    {
                        // Creamos un listViewItem para agregar los datos
                        ListViewItem listViewItem = new ListViewItem(compra.Identificacion);
                        //listViewItem.SubItems.Add(compra.Identificacion);
                        listViewItem.SubItems.Add(compra.Nombre);
                        listViewItem.SubItems.Add(compra.Apellido);
                        listViewItem.SubItems.Add(compra.Provincia);
                        listViewItem.SubItems.Add(compra.Email);
                        listViewItem.SubItems.Add(compra.Monto.ToString());

                        lvwCompras.Items.Add(listViewItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Carga de compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
