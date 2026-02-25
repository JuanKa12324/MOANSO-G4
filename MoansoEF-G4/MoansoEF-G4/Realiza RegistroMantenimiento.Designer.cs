namespace MoansoEF_G4
{
    partial class Realiza_RegistroMantenimiento
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
            dataGridView1 = new DataGridView();
            cmbMantenimiento = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbIDPlanMantenimiento = new ComboBox();
            txtDescripcion = new TextBox();
            label4 = new Label();
            label6 = new Label();
            DtpRealizacion = new DateTimePicker();
            label7 = new Label();
            txtIDRecursos = new TextBox();
            btnAgregarLista = new Button();
            label8 = new Label();
            txtCantidad = new TextBox();
            listBox = new ListBox();
            cmbEstado = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            cmbEquipoID = new ComboBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(632, 272);
            dataGridView1.TabIndex = 0;
            // 
            // cmbMantenimiento
            // 
            cmbMantenimiento.FormattingEnabled = true;
            cmbMantenimiento.Location = new Point(169, 345);
            cmbMantenimiento.Name = "cmbMantenimiento";
            cmbMantenimiento.Size = new Size(220, 23);
            cmbMantenimiento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 348);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 2;
            label1.Text = "Tipo mantenimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 296);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 3;
            label2.Text = " ID Plan de Mantenimiento:";
            // 
            // cmbIDPlanMantenimiento
            // 
            cmbIDPlanMantenimiento.FormattingEnabled = true;
            cmbIDPlanMantenimiento.Location = new Point(169, 293);
            cmbIDPlanMantenimiento.Name = "cmbIDPlanMantenimiento";
            cmbIDPlanMantenimiento.Size = new Size(220, 23);
            cmbIDPlanMantenimiento.TabIndex = 4;
            cmbIDPlanMantenimiento.Text = " ";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(173, 437);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(220, 23);
            txtDescripcion.TabIndex = 6;
            txtDescripcion.Text = " ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 440);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 7;
            label4.Text = "Descripción:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 543);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 10;
            label6.Text = "Fecha de realización:";
            // 
            // DtpRealizacion
            // 
            DtpRealizacion.Location = new Point(173, 537);
            DtpRealizacion.Name = "DtpRealizacion";
            DtpRealizacion.Size = new Size(216, 23);
            DtpRealizacion.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(456, 296);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 12;
            label7.Text = "ID Recursos usados:";
            // 
            // txtIDRecursos
            // 
            txtIDRecursos.Location = new Point(456, 314);
            txtIDRecursos.Name = "txtIDRecursos";
            txtIDRecursos.Size = new Size(188, 23);
            txtIDRecursos.TabIndex = 13;
            // 
            // btnAgregarLista
            // 
            btnAgregarLista.Location = new Point(506, 411);
            btnAgregarLista.Name = "btnAgregarLista";
            btnAgregarLista.Size = new Size(75, 44);
            btnAgregarLista.TabIndex = 14;
            btnAgregarLista.Text = "Agregar a Lista";
            btnAgregarLista.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(456, 353);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 15;
            label8.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(456, 371);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(188, 23);
            txtCantidad.TabIndex = 16;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(461, 461);
            listBox.Name = "listBox";
            listBox.Size = new Size(183, 124);
            listBox.TabIndex = 17;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(173, 488);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(216, 23);
            cmbEstado.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 488);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 8;
            label5.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 467);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // cmbEquipoID
            // 
            cmbEquipoID.FormattingEnabled = true;
            cmbEquipoID.Location = new Point(169, 391);
            cmbEquipoID.Name = "cmbEquipoID";
            cmbEquipoID.Size = new Size(220, 23);
            cmbEquipoID.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(102, 394);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 19;
            label9.Text = "ID Equipo:";
            // 
            // Realiza_RegistroMantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 588);
            Controls.Add(label9);
            Controls.Add(cmbEquipoID);
            Controls.Add(listBox);
            Controls.Add(txtCantidad);
            Controls.Add(label8);
            Controls.Add(btnAgregarLista);
            Controls.Add(txtIDRecursos);
            Controls.Add(label7);
            Controls.Add(DtpRealizacion);
            Controls.Add(label6);
            Controls.Add(cmbEstado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(cmbIDPlanMantenimiento);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbMantenimiento);
            Controls.Add(dataGridView1);
            Name = "Realiza_RegistroMantenimiento";
            Text = "Realiza_RegistroMantenimiento";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbMantenimiento;
        private Label label1;
        private Label label2;
        private ComboBox cmbIDPlanMantenimiento;
        private TextBox txtDescripcion;
        private Label label4;
        private Label label6;
        private DateTimePicker DtpRealizacion;
        private Label label7;
        private TextBox txtIDRecursos;
        private Button btnAgregarLista;
        private Label label8;
        private TextBox txtCantidad;
        private ListBox listBox;
        private ComboBox cmbEstado;
        private Label label5;
        private Label label3;
        private ComboBox cmbEquipoID;
        private Label label9;
    }
}