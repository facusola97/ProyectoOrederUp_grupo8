namespace Front
{
    partial class AgregarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtTipo = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            data1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            txtCantidad = new TextBox();
            comboBoxIngredientes = new ComboBox();
            button5 = new Button();
            numericUpDown1 = new NumericUpDown();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)data1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 84);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 127);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 172);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 212);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(106, 73);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(106, 116);
            txtTipo.Margin = new Padding(3, 4, 3, 4);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(114, 27);
            txtTipo.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(106, 161);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(114, 27);
            txtDescripcion.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(106, 201);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(114, 27);
            txtPrecio.TabIndex = 7;
            // 
            // data1
            // 
            data1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data1.Location = new Point(402, 44);
            data1.Margin = new Padding(3, 4, 3, 4);
            data1.Name = "data1";
            data1.RowHeadersWidth = 51;
            data1.RowTemplate.Height = 25;
            data1.Size = new Size(457, 200);
            data1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(402, 307);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 9;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(495, 307);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 10;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(587, 307);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 11;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(680, 307);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 12;
            button4.Text = "Volver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 257);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 13;
            label5.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(106, 247);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(114, 27);
            txtCantidad.TabIndex = 14;
            // 
            // comboBoxIngredientes
            // 
            comboBoxIngredientes.FormattingEnabled = true;
            comboBoxIngredientes.Location = new Point(84, 322);
            comboBoxIngredientes.Name = "comboBoxIngredientes";
            comboBoxIngredientes.Size = new Size(151, 28);
            comboBoxIngredientes.TabIndex = 15;
            // 
            // button5
            // 
            button5.Location = new Point(149, 366);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 31);
            button5.TabIndex = 16;
            button5.Text = "Agregar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(85, 469);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 17;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(388, 381);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 18;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(listBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(button5);
            Controls.Add(comboBoxIngredientes);
            Controls.Add(txtCantidad);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(data1);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtTipo);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            Load += AgregarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)data1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtTipo;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private DataGridView data1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label5;
        private TextBox txtCantidad;
        private ComboBox comboBoxIngredientes;
        private Button button5;
        private NumericUpDown numericUpDown1;
        private ListBox listBox1;
    }
}