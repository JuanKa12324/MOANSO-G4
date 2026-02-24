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
            comboBox4 = new ComboBox();
            button7 = new Button();
            btnModificar = new Button();
            btnInsertar = new Button();
            label9 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvMantenimiento = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnNuevo = new Button();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            label10 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label11 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            PlanMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimiento).BeginInit();
            SuspendLayout();
            // 
            // PlanMantenimiento
            // 
            PlanMantenimiento.Controls.Add(comboBox1);
            PlanMantenimiento.Controls.Add(label11);
            PlanMantenimiento.Controls.Add(textBox4);
            PlanMantenimiento.Controls.Add(textBox3);
            PlanMantenimiento.Controls.Add(textBox2);
            PlanMantenimiento.Controls.Add(textBox1);
            PlanMantenimiento.Controls.Add(label10);
            PlanMantenimiento.Controls.Add(comboBox6);
            PlanMantenimiento.Controls.Add(comboBox5);
            PlanMantenimiento.Controls.Add(comboBox4);
            PlanMantenimiento.Controls.Add(label9);
            PlanMantenimiento.Controls.Add(dateTimePicker2);
            PlanMantenimiento.Controls.Add(label8);
            PlanMantenimiento.Controls.Add(dateTimePicker1);
            PlanMantenimiento.Controls.Add(label7);
            PlanMantenimiento.Controls.Add(label6);
            PlanMantenimiento.Controls.Add(label4);
            PlanMantenimiento.Controls.Add(label3);
            PlanMantenimiento.Controls.Add(label2);
            PlanMantenimiento.Controls.Add(label1);
            PlanMantenimiento.Location = new Point(12, 339);
            PlanMantenimiento.Name = "PlanMantenimiento";
            PlanMantenimiento.Size = new Size(972, 305);
            PlanMantenimiento.TabIndex = 1;
            PlanMantenimiento.TabStop = false;
            PlanMantenimiento.Text = "groupBox1";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(62, 225);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(183, 23);
            comboBox4.TabIndex = 26;
            // 
            // button7
            // 
            button7.Location = new Point(1023, 568);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 21;
            button7.Text = "Cancelar";
            button7.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(1023, 508);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(1023, 446);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 19;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(309, 127);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 17;
            label9.Text = "Tecnico:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(642, 94);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(306, 23);
            dateTimePicker2.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(642, 71);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 6;
            label7.Text = "Fecha de Inicio:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(309, 79);
            label6.Name = "label6";
            label6.Size = new Size(135, 15);
            label6.TabIndex = 5;
            label6.Text = "Tipo de Mantenimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 229);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Prioridad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 177);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 2;
            label3.Text = "Estado del equipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 125);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Equipo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 76);
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
            dgvMantenimiento.Size = new Size(942, 321);
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
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(366, 125);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(224, 23);
            comboBox5.TabIndex = 27;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(450, 73);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(140, 23);
            comboBox6.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 34);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 31;
            label10.Text = "ID del equipo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(62, 73);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(183, 23);
            textBox2.TabIndex = 33;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(62, 117);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(183, 23);
            textBox3.TabIndex = 34;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(122, 172);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(123, 23);
            textBox4.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(316, 180);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 36;
            label11.Text = "Frecuencia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(642, 151);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 15;
            label8.Text = "Fecha de Finalización:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(642, 169);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(306, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(386, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 23);
            comboBox1.TabIndex = 37;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 644);
            Controls.Add(btnNuevo);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dgvMantenimiento);
            Controls.Add(PlanMantenimiento);
            Controls.Add(button7);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvMantenimiento;
        private DateTimePicker dateTimePicker2;
        private Label label9;
        private Button button2;
        private Button button3;
        private Button button7;
        private Button btnModificar;
        private Button btnInsertar;
        private Button button4;
        private Button btnNuevo;
        private ComboBox comboBox4;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private TextBox textBox1;
        private Label label10;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label11;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
    }
}
