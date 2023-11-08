﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Back.Clases;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace Front
{
    public partial class AgregarProducto : Form
    {


        public AgregarProducto ( )
        {
            InitializeComponent ();
        }

        private void button4_Click ( object sender, EventArgs e )
        {
            InicioAdm inicio = new InicioAdm ();
            inicio.Show ();
            this.Hide ();

        }



        private void button1_Click ( object sender, EventArgs e )
        {


            Opcion opcion = Principal.context.opciones.Find ();

            List<Ingredientes> ingredientes = opcion.GetIngredientes ();

            MessageBox.Show (ingredientes[0].ToString ());




            IngredienteOpcion IngredienteOpcion = Principal.context.ingredientesOpciones.Find (1);
            MessageBox.Show (IngredienteOpcion.IdIngrediente.ToString ());






            Opcion opcionn = Principal.AgregarOpcion (txtNombre.Text, txtTipo.Text, txtDescripcion.Text, decimal.Parse (txtPrecio.Text), int.Parse (txtCantidad.Text));













            data1.DataSource = Principal.context.opciones.Local.ToBindingList ();



            txtNombre.Clear ();
            txtTipo.Clear ();
            txtDescripcion.Clear ();
            txtPrecio.Clear ();
            txtCantidad.Clear ();



        }

        private void button2_Click ( object sender, EventArgs e )
        {

        }

        private void AgregarProducto_Load ( object sender, EventArgs e )
        {
            Principal.context.opciones.Load ();
            data1.DataSource = null;
            data1.DataSource = Principal.context.opciones.Local.ToBindingList ();

            Principal.context.ingredientes.Load ();
            comboBoxIngredientes.DataSource = null;
            comboBoxIngredientes.DataSource = Principal.context.ingredientes.Local.ToBindingList ();
        }

        private void button3_Click ( object sender, EventArgs e )
        {
            if (data1.SelectedRows.Count == 0)
            {

                MessageBox.Show ("Debes seleccionar una fila para eliminar");
                return;
            }

            DataGridViewRow filaSeleccionada = data1.SelectedRows[0];

            int id = int.Parse (filaSeleccionada.Cells[0].Value.ToString ());
            Principal.context.opciones.Remove (Principal.context.opciones.Find (id));
            Principal.context.SaveChanges ();

            data1.DataSource = Principal.context.opciones.Local.ToBindingList ();


            txtNombre.Clear ();
            txtTipo.Clear ();
            txtDescripcion.Clear ();
            txtPrecio.Clear ();
            txtCantidad.Clear ();

        }

        private void button5_Click ( object sender, EventArgs e )
        {
            DataGridViewRow filaSeleccionada = data1.SelectedRows[0];

            if (filaSeleccionada != null)
            {

                int idOpcion = (int)filaSeleccionada.Cells["IdOpcion"].Value;



                Opcion? objetoSeleccionado = Principal.context.opciones.FirstOrDefault (a => a.IdOpcion == idOpcion);

                IngredienteOpcion ingredienteOpc = new IngredienteOpcion
                {
                    Ingredientes = (Ingredientes)comboBoxIngredientes.SelectedItem,
                    Opcion = objetoSeleccionado

                };
                Principal.context.ingredientesOpciones.Add (ingredienteOpc);
                Principal.context.SaveChanges ();

                listBox1.DataSource = null;
                listBox1.DataSource = objetoSeleccionado.GetIngredientes ();

            }

        }

    }
}

