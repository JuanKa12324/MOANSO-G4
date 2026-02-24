namespace MoansoEF_G4
{
    partial class MovimientoInventario
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
            DgvMovimientoInventario = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtIDRecurso = new TextBox();
            txtCantidadIngreso = new TextBox();
            txtTipoRecurso = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvMovimientoInventario).BeginInit();
            SuspendLayout();
            // 
            // DgvMovimientoInventario
            // 
            DgvMovimientoInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMovimientoInventario.Location = new Point(12, 12);
            DgvMovimientoInventario.Name = "DgvMovimientoInventario";
            DgvMovimientoInventario.Size = new Size(512, 276);
            DgvMovimientoInventario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 323);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "ID Recurso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 396);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad de ingreso:";
            // 
            // txtIDRecurso
            // 
            txtIDRecurso.Location = new Point(160, 320);
            txtIDRecurso.Name = "txtIDRecurso";
            txtIDRecurso.Size = new Size(222, 23);
            txtIDRecurso.TabIndex = 3;
            // 
            // txtCantidadIngreso
            // 
            txtCantidadIngreso.Location = new Point(160, 393);
            txtCantidadIngreso.Name = "txtCantidadIngreso";
            txtCantidadIngreso.Size = new Size(222, 23);
            txtCantidadIngreso.TabIndex = 4;
            // 
            // txtTipoRecurso
            // 
            txtTipoRecurso.Location = new Point(160, 356);
            txtTipoRecurso.Name = "txtTipoRecurso";
            txtTipoRecurso.Size = new Size(222, 23);
            txtTipoRecurso.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 359);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 6;
            label3.Text = "Tipo de recurso:";
            // 
            // MovimientoInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtTipoRecurso);
            Controls.Add(txtCantidadIngreso);
            Controls.Add(txtIDRecurso);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DgvMovimientoInventario);
            Name = "MovimientoInventario";
            Text = "MovimientoInventario";
            ((System.ComponentModel.ISupportInitialize)DgvMovimientoInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvMovimientoInventario;
        private Label label1;
        private Label label2;
        private TextBox txtIDRecurso;
        private TextBox txtCantidadIngreso;
        private TextBox txtTipoRecurso;
        private Label label3;
    }
}