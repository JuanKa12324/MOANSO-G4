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
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label11 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            label9 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            label4 = new Label();
            button7 = new Button();
            btnInsertar = new Button();
            dgvPlanMantenimiento = new DataGridView();
            btnInhabilitarPlanM = new Button();
            btnSalirPlanM = new Button();
            btnNuevoPlanM = new Button();
            btnBuscarEquipo = new Button();
            btnBuscarTecnico = new Button();
            PlanMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlanMantenimiento).BeginInit();
            SuspendLayout();
            // 
            // PlanMantenimiento
            // 
            PlanMantenimiento.Controls.Add(btnBuscarTecnico);
            PlanMantenimiento.Controls.Add(btnBuscarEquipo);
            PlanMantenimiento.Controls.Add(comboBox2);
            PlanMantenimiento.Controls.Add(label5);
            PlanMantenimiento.Controls.Add(comboBox1);
            PlanMantenimiento.Controls.Add(label11);
            PlanMantenimiento.Controls.Add(textBox1);
            PlanMantenimiento.Controls.Add(label10);
            PlanMantenimiento.Controls.Add(comboBox5);
            PlanMantenimiento.Controls.Add(comboBox4);
            PlanMantenimiento.Controls.Add(label9);
            PlanMantenimiento.Controls.Add(dateTimePicker2);
            PlanMantenimiento.Controls.Add(label7);
            PlanMantenimiento.Controls.Add(label4);
            PlanMantenimiento.Location = new Point(12, 339);
            PlanMantenimiento.Name = "PlanMantenimiento";
            PlanMantenimiento.Size = new Size(972, 305);
            PlanMantenimiento.TabIndex = 1;
            PlanMantenimiento.TabStop = false;
            PlanMantenimiento.Text = "Registrar Plan de Mantenimiento";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(156, 80);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(165, 23);
            comboBox2.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 83);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 38;
            label5.Text = "Especialidad:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(156, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 23);
            comboBox1.TabIndex = 37;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(80, 161);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 36;
            label11.Text = "Frecuencia";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(69, 39);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 31;
            label10.Text = "ID del equipo:";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(156, 122);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(165, 23);
            comboBox5.TabIndex = 27;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(156, 236);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(165, 23);
            comboBox4.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(93, 125);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 17;
            label9.Text = "Tecnico:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(156, 201);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(165, 23);
            dateTimePicker2.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 204);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 6;
            label7.Text = "Fecha de Inicio:";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 239);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Prioridad:";
            // 
            // button7
            // 
            button7.Location = new Point(1010, 500);
            button7.Name = "button7";
            button7.Size = new Size(88, 42);
            button7.TabIndex = 21;
            button7.Text = "Cancelar";
            button7.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(1010, 437);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(88, 42);
            btnInsertar.TabIndex = 19;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // dgvPlanMantenimiento
            // 
            dgvPlanMantenimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanMantenimiento.Location = new Point(18, 3);
            dgvPlanMantenimiento.Name = "dgvPlanMantenimiento";
            dgvPlanMantenimiento.Size = new Size(942, 321);
            dgvPlanMantenimiento.TabIndex = 13;
            // 
            // btnInhabilitarPlanM
            // 
            btnInhabilitarPlanM.Location = new Point(979, 215);
            btnInhabilitarPlanM.Name = "btnInhabilitarPlanM";
            btnInhabilitarPlanM.Size = new Size(91, 38);
            btnInhabilitarPlanM.TabIndex = 15;
            btnInhabilitarPlanM.Text = "Inhabilitar";
            btnInhabilitarPlanM.UseVisualStyleBackColor = true;
            // 
            // btnSalirPlanM
            // 
            btnSalirPlanM.Location = new Point(979, 146);
            btnSalirPlanM.Name = "btnSalirPlanM";
            btnSalirPlanM.Size = new Size(91, 38);
            btnSalirPlanM.TabIndex = 16;
            btnSalirPlanM.Text = "Salir";
            btnSalirPlanM.UseVisualStyleBackColor = true;
            // 
            // btnNuevoPlanM
            // 
            btnNuevoPlanM.Location = new Point(979, 70);
            btnNuevoPlanM.Name = "btnNuevoPlanM";
            btnNuevoPlanM.Size = new Size(91, 38);
            btnNuevoPlanM.TabIndex = 0;
            btnNuevoPlanM.Text = "Nuevo";
            btnNuevoPlanM.Click += btnNuevo_Click;
            // 
            // btnBuscarEquipo
            // 
            btnBuscarEquipo.Location = new Point(368, 80);
            btnBuscarEquipo.Name = "btnBuscarEquipo";
            btnBuscarEquipo.Size = new Size(105, 34);
            btnBuscarEquipo.TabIndex = 40;
            btnBuscarEquipo.Text = "Buscar Equipo";
            btnBuscarEquipo.UseVisualStyleBackColor = true;
            // 
            // btnBuscarTecnico
            // 
            btnBuscarTecnico.Location = new Point(368, 142);
            btnBuscarTecnico.Name = "btnBuscarTecnico";
            btnBuscarTecnico.Size = new Size(105, 34);
            btnBuscarTecnico.TabIndex = 41;
            btnBuscarTecnico.Text = "Buscar Tecnico";
            btnBuscarTecnico.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 644);
            Controls.Add(btnNuevoPlanM);
            Controls.Add(btnSalirPlanM);
            Controls.Add(btnInhabilitarPlanM);
            Controls.Add(dgvPlanMantenimiento);
            Controls.Add(PlanMantenimiento);
            Controls.Add(button7);
            Controls.Add(btnInsertar);
            Name = "Form1";
            Text = "Registra Plan Mantenimiento";
            PlanMantenimiento.ResumeLayout(false);
            PlanMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlanMantenimiento).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox PlanMantenimiento;
        private Label label7;
        private Label label4;
        private DataGridView dgvPlanMantenimiento;
        private DateTimePicker dateTimePicker2;
        private Label label9;
        private Button btnInhabilitarPlanM;
        private Button button7;
        private Button btnInsertar;
        private Button btnSalirPlanM;
        private Button btnNuevoPlanM;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private TextBox textBox1;
        private Label label10;
        private Label label11;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label5;
        private Button btnBuscarEquipo;
        private Button btnBuscarTecnico;
    }
}
