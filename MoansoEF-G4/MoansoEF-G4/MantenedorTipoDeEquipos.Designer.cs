namespace MoansoEF_G4
{
    partial class MantenedorTipoDeEquipos
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
            txtMTipoEquipo = new TextBox();
            btnEliminarEquipo = new Button();
            btnNuevoEquipo = new Button();
            btnAgregarEquipo = new Button();
            label1 = new Label();
            DgvEquipo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvEquipo).BeginInit();
            SuspendLayout();
            // 
            // txtMTipoEquipo
            // 
            txtMTipoEquipo.Location = new Point(105, 363);
            txtMTipoEquipo.Name = "txtMTipoEquipo";
            txtMTipoEquipo.Size = new Size(274, 23);
            txtMTipoEquipo.TabIndex = 11;
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.Location = new Point(426, 178);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(75, 23);
            btnEliminarEquipo.TabIndex = 10;
            btnEliminarEquipo.Text = "Eliminar";
            btnEliminarEquipo.UseVisualStyleBackColor = true;
            // 
            // btnNuevoEquipo
            // 
            btnNuevoEquipo.Location = new Point(426, 107);
            btnNuevoEquipo.Name = "btnNuevoEquipo";
            btnNuevoEquipo.Size = new Size(75, 23);
            btnNuevoEquipo.TabIndex = 9;
            btnNuevoEquipo.Text = "Nuevo";
            btnNuevoEquipo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.Location = new Point(166, 410);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(75, 23);
            btnAgregarEquipo.TabIndex = 8;
            btnAgregarEquipo.Text = "Agregar";
            btnAgregarEquipo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 366);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 7;
            label1.Text = "Tipo de equipo";
            // 
            // DgvEquipo
            // 
            DgvEquipo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEquipo.Location = new Point(12, 22);
            DgvEquipo.Name = "DgvEquipo";
            DgvEquipo.Size = new Size(367, 319);
            DgvEquipo.TabIndex = 6;
            // 
            // MantenedorTipoDeEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 450);
            Controls.Add(txtMTipoEquipo);
            Controls.Add(btnEliminarEquipo);
            Controls.Add(btnNuevoEquipo);
            Controls.Add(btnAgregarEquipo);
            Controls.Add(label1);
            Controls.Add(DgvEquipo);
            Name = "MantenedorTipoDeEquipos";
            Text = "MantenedorTipoDeEquipos";
            ((System.ComponentModel.ISupportInitialize)DgvEquipo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMTipoEquipo;
        private Button btnEliminarEquipo;
        private Button btnNuevoEquipo;
        private Button btnAgregarEquipo;
        private Label label1;
        private DataGridView DgvEquipo;
    }
}