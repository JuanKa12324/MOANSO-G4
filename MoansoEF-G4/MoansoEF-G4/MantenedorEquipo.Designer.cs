namespace MoansoEF_G4
{
    partial class MantenedorEquipo
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
            btnBuscarMEquipo = new Button();
            DgvEquipo = new DataGridView();
            btnNuevoMEquipo = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtNombreMEquipo = new TextBox();
            DtpRegistroMEquipo = new DateTimePicker();
            label5 = new Label();
            comboxEstadoMEquipo = new ComboBox();
            label4 = new Label();
            txtAreaMEquipo = new ComboBox();
            txtTipoMEquipo = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtCodigoMEquipo = new TextBox();
            label1 = new Label();
            btnModificarMEquipo = new Button();
            btnEliminarMEquipo = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvEquipo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscarMEquipo
            // 
            btnBuscarMEquipo.Location = new Point(613, 109);
            btnBuscarMEquipo.Name = "btnBuscarMEquipo";
            btnBuscarMEquipo.Size = new Size(89, 44);
            btnBuscarMEquipo.TabIndex = 0;
            btnBuscarMEquipo.Text = "Buscar";
            btnBuscarMEquipo.UseVisualStyleBackColor = true;
            // 
            // DgvEquipo
            // 
            DgvEquipo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEquipo.Location = new Point(12, 12);
            DgvEquipo.Name = "DgvEquipo";
            DgvEquipo.Size = new Size(575, 273);
            DgvEquipo.TabIndex = 1;
            // 
            // btnNuevoMEquipo
            // 
            btnNuevoMEquipo.Location = new Point(613, 26);
            btnNuevoMEquipo.Name = "btnNuevoMEquipo";
            btnNuevoMEquipo.Size = new Size(89, 44);
            btnNuevoMEquipo.TabIndex = 2;
            btnNuevoMEquipo.Text = "Nuevo";
            btnNuevoMEquipo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNombreMEquipo);
            groupBox1.Controls.Add(DtpRegistroMEquipo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboxEstadoMEquipo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAreaMEquipo);
            groupBox1.Controls.Add(txtTipoMEquipo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCodigoMEquipo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 302);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 206);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar Equipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 48);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 13;
            label6.Text = "Nombre:";
            // 
            // txtNombreMEquipo
            // 
            txtNombreMEquipo.Location = new Point(104, 45);
            txtNombreMEquipo.Name = "txtNombreMEquipo";
            txtNombreMEquipo.Size = new Size(177, 23);
            txtNombreMEquipo.TabIndex = 12;
            // 
            // DtpRegistroMEquipo
            // 
            DtpRegistroMEquipo.Location = new Point(322, 130);
            DtpRegistroMEquipo.Name = "DtpRegistroMEquipo";
            DtpRegistroMEquipo.Size = new Size(232, 23);
            DtpRegistroMEquipo.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 112);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 10;
            label5.Text = "Fecha de registro:";
            // 
            // comboxEstadoMEquipo
            // 
            comboxEstadoMEquipo.FormattingEnabled = true;
            comboxEstadoMEquipo.Location = new Point(104, 169);
            comboxEstadoMEquipo.Name = "comboxEstadoMEquipo";
            comboxEstadoMEquipo.Size = new Size(177, 23);
            comboxEstadoMEquipo.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 172);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 8;
            label4.Text = "Estado:";
            // 
            // txtAreaMEquipo
            // 
            txtAreaMEquipo.FormattingEnabled = true;
            txtAreaMEquipo.Location = new Point(104, 84);
            txtAreaMEquipo.Name = "txtAreaMEquipo";
            txtAreaMEquipo.Size = new Size(177, 23);
            txtAreaMEquipo.TabIndex = 7;
            // 
            // txtTipoMEquipo
            // 
            txtTipoMEquipo.FormattingEnabled = true;
            txtTipoMEquipo.Location = new Point(104, 127);
            txtTipoMEquipo.Name = "txtTipoMEquipo";
            txtTipoMEquipo.Size = new Size(177, 23);
            txtTipoMEquipo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 130);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo de equipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 87);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Área asignada:";
            // 
            // txtCodigoMEquipo
            // 
            txtCodigoMEquipo.Location = new Point(377, 45);
            txtCodigoMEquipo.Name = "txtCodigoMEquipo";
            txtCodigoMEquipo.Size = new Size(177, 23);
            txtCodigoMEquipo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 48);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // btnModificarMEquipo
            // 
            btnModificarMEquipo.Location = new Point(613, 386);
            btnModificarMEquipo.Name = "btnModificarMEquipo";
            btnModificarMEquipo.Size = new Size(89, 35);
            btnModificarMEquipo.TabIndex = 6;
            btnModificarMEquipo.Text = "Modificar";
            btnModificarMEquipo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMEquipo
            // 
            btnEliminarMEquipo.Location = new Point(613, 188);
            btnEliminarMEquipo.Name = "btnEliminarMEquipo";
            btnEliminarMEquipo.Size = new Size(89, 44);
            btnEliminarMEquipo.TabIndex = 7;
            btnEliminarMEquipo.Text = "Eliminar";
            btnEliminarMEquipo.UseVisualStyleBackColor = true;
            // 
            // MantenedorEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 520);
            Controls.Add(btnEliminarMEquipo);
            Controls.Add(groupBox1);
            Controls.Add(btnNuevoMEquipo);
            Controls.Add(DgvEquipo);
            Controls.Add(btnBuscarMEquipo);
            Controls.Add(btnModificarMEquipo);
            Name = "MantenedorEquipo";
            Text = "MantenedorEquipo";
            ((System.ComponentModel.ISupportInitialize)DgvEquipo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscarMEquipo;
        private DataGridView DgvEquipo;
        private Button btnNuevoMEquipo;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtCodigoMEquipo;
        private Label label1;
        private Label label3;
        private ComboBox txtTipoMEquipo;
        private ComboBox comboxEstadoMEquipo;
        private Label label4;
        private ComboBox txtAreaMEquipo;
        private Button btnModificarMEquipo;
        private DateTimePicker DtpRegistroMEquipo;
        private Label label5;
        private Label label6;
        private TextBox txtNombreMEquipo;
        private Button btnEliminarMEquipo;
    }
}