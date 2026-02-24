namespace MoansoEF_G4
{
    partial class MantenedorRubro
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
            DgvRubro = new DataGridView();
            btnEditarMRubro = new Button();
            btnEliminarMRubro = new Button();
            txtAgregarMRubro = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvRubro).BeginInit();
            SuspendLayout();
            // 
            // DgvRubro
            // 
            DgvRubro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvRubro.Location = new Point(12, 12);
            DgvRubro.Name = "DgvRubro";
            DgvRubro.Size = new Size(310, 418);
            DgvRubro.TabIndex = 0;
            // 
            // btnEditarMRubro
            // 
            btnEditarMRubro.Location = new Point(423, 178);
            btnEditarMRubro.Name = "btnEditarMRubro";
            btnEditarMRubro.Size = new Size(75, 23);
            btnEditarMRubro.TabIndex = 1;
            btnEditarMRubro.Text = "Editar";
            btnEditarMRubro.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMRubro
            // 
            btnEliminarMRubro.Location = new Point(423, 276);
            btnEliminarMRubro.Name = "btnEliminarMRubro";
            btnEliminarMRubro.Size = new Size(75, 23);
            btnEliminarMRubro.TabIndex = 2;
            btnEliminarMRubro.Text = "Eliminar";
            btnEliminarMRubro.UseVisualStyleBackColor = true;
            // 
            // txtAgregarMRubro
            // 
            txtAgregarMRubro.Location = new Point(364, 87);
            txtAgregarMRubro.Name = "txtAgregarMRubro";
            txtAgregarMRubro.Size = new Size(179, 23);
            txtAgregarMRubro.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 69);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 4;
            label1.Text = "Rubro a agregar:";
            // 
            // MantenedorRubro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 450);
            Controls.Add(label1);
            Controls.Add(txtAgregarMRubro);
            Controls.Add(btnEliminarMRubro);
            Controls.Add(btnEditarMRubro);
            Controls.Add(DgvRubro);
            Name = "MantenedorRubro";
            Text = "MantenedorRubro";
            ((System.ComponentModel.ISupportInitialize)DgvRubro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvRubro;
        private Button btnEditarMRubro;
        private Button btnEliminarMRubro;
        private TextBox txtAgregarMRubro;
        private Label label1;
    }
}