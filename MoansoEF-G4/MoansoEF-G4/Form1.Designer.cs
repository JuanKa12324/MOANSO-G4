namespace MoansoEF_G4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PlanMantenimiento = new GroupBox();
            button7 = new Button();
            btnModificar = new Button();
            btnInsertar = new Button();
            txtTecnico = new TextBox();
            label9 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            lbRecursos = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            txtTipoDeMantenimiento = new TextBox();
            txtRecursos = new TextBox();
            txtPrioridad = new TextBox();
            txtEstado = new TextBox();
            txtEquipo = new TextBox();
            txtArea = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvMantenimiento = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnNuevo = new Button();
            idMant = new TextBox();
            PlanMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimiento).BeginInit();
            SuspendLayout();
            // 
            // PlanMantenimiento
            // 
            PlanMantenimiento.Controls.Add(idMant);
            PlanMantenimiento.Controls.Add(button7);
            PlanMantenimiento.Controls.Add(btnModificar);
            PlanMantenimiento.Controls.Add(btnInsertar);
            PlanMantenimiento.Controls.Add(txtTecnico);
            PlanMantenimiento.Controls.Add(label9);
            PlanMantenimiento.Controls.Add(dateTimePicker2);
            PlanMantenimiento.Controls.Add(label8);
            PlanMantenimiento.Controls.Add(lbRecursos);
            PlanMantenimiento.Controls.Add(dateTimePicker1);
            PlanMantenimiento.Controls.Add(txtTipoDeMantenimiento);
            PlanMantenimiento.Controls.Add(txtRecursos);
            PlanMantenimiento.Controls.Add(txtPrioridad);
            PlanMantenimiento.Controls.Add(txtEstado);
            PlanMantenimiento.Controls.Add(txtEquipo);
            PlanMantenimiento.Controls.Add(txtArea);
            PlanMantenimiento.Controls.Add(label7);
            PlanMantenimiento.Controls.Add(label6);
            PlanMantenimiento.Controls.Add(label5);
            PlanMantenimiento.Controls.Add(label4);
            PlanMantenimiento.Controls.Add(label3);
            PlanMantenimiento.Controls.Add(label2);
            PlanMantenimiento.Controls.Add(label1);
            PlanMantenimiento.Location = new Point(12, 339);
            PlanMantenimiento.Name = "PlanMantenimiento";
            PlanMantenimiento.Size = new Size(1071, 219);
            PlanMantenimiento.TabIndex = 1;
            PlanMantenimiento.TabStop = false;
            PlanMantenimiento.Text = "groupBox1";
            // 
            // button7
            // 
            button7.Location = new Point(967, 176);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 21;
            button7.Text = "Cancelar";
            button7.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(873, 176);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(774, 176);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 19;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtTecnico
            // 
            txtTecnico.Location = new Point(351, 122);
            txtTecnico.Name = "txtTecnico";
            txtTecnico.Size = new Size(224, 23);
            txtTecnico.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(294, 125);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 17;
            label9.Text = "Tecnico:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(748, 47);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(306, 23);
            dateTimePicker2.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(748, 104);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 15;
            label8.Text = "Fecha de Finalización:";
            // 
            // lbRecursos
            // 
            lbRecursos.FormattingEnabled = true;
            lbRecursos.Location = new Point(590, 21);
            lbRecursos.Name = "lbRecursos";
            lbRecursos.Size = new Size(152, 184);
            lbRecursos.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(748, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(306, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // txtTipoDeMantenimiento
            // 
            txtTipoDeMantenimiento.Location = new Point(435, 71);
            txtTipoDeMantenimiento.Name = "txtTipoDeMantenimiento";
            txtTipoDeMantenimiento.Size = new Size(140, 23);
            txtTipoDeMantenimiento.TabIndex = 12;
            // 
            // txtRecursos
            // 
            txtRecursos.Location = new Point(357, 21);
            txtRecursos.Name = "txtRecursos";
            txtRecursos.Size = new Size(218, 23);
            txtRecursos.TabIndex = 11;
            // 
            // txtPrioridad
            // 
            txtPrioridad.Location = new Point(70, 172);
            txtPrioridad.Name = "txtPrioridad";
            txtPrioridad.Size = new Size(175, 23);
            txtPrioridad.TabIndex = 10;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(62, 125);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(183, 23);
            txtEstado.TabIndex = 9;
            // 
            // txtEquipo
            // 
            txtEquipo.Location = new Point(62, 71);
            txtEquipo.Name = "txtEquipo";
            txtEquipo.Size = new Size(183, 23);
            txtEquipo.TabIndex = 8;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(46, 26);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(199, 23);
            txtArea.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(748, 24);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 6;
            label7.Text = "Fecha de Inicio:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(294, 74);
            label6.Name = "label6";
            label6.Size = new Size(135, 15);
            label6.TabIndex = 5;
            label6.Text = "Tipo de Mantenimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(294, 26);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Recursos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 180);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Prioridad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 128);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Equipo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Área:";
            label1.Click += label1_Click;
            // 
            // dgvMantenimiento
            // 
            dgvMantenimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantenimiento.Location = new Point(18, 3);
            dgvMantenimiento.Name = "dgvMantenimiento";
            dgvMantenimiento.Size = new Size(887, 321);
            dgvMantenimiento.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(979, 79);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(979, 122);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "Inhabilitar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(979, 171);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 16;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(979, 35);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.Click += btnNuevo_Click;
            // 
            // idMant
            // 
            idMant.Location = new Point(350, 164);
            idMant.Name = "idMant";
            idMant.Size = new Size(100, 23);
            idMant.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 598);
            Controls.Add(btnNuevo);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dgvMantenimiento);
            Controls.Add(PlanMantenimiento);
            Name = "Form1";
            Text = "Form1";
            PlanMantenimiento.ResumeLayout(false);
            PlanMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimiento).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox PlanMantenimiento;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTipoDeMantenimiento;
        private TextBox txtRecursos;
        private TextBox txtPrioridad;
        private TextBox txtEstado;
        private TextBox txtEquipo;
        private TextBox txtArea;
        private ListBox lbRecursos;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgvMantenimiento;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private TextBox txtTecnico;
        private Label label9;
        private Button button2;
        private Button button3;
        private Button button7;
        private Button btnModificar;
        private Button btnInsertar;
        private Button button4;
        private Button btnNuevo;
        private TextBox idMant;
    }
}
