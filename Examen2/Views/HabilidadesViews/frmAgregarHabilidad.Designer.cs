namespace Examen2.Views.HabilidadesViews
{
    partial class frmAgregarHabilidad
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
            label6 = new Label();
            btnRegresar = new Button();
            btnAgregar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txHabilidad = new TextBox();
            txAlias = new TextBox();
            txNombre = new TextBox();
            txId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtDescripcion = new RichTextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(141, 44);
            label6.Name = "label6";
            label6.Size = new Size(121, 30);
            label6.TabIndex = 38;
            label6.Text = "HABILIDAD";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(218, 300);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 37;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(116, 300);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 36;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 235);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 35;
            label5.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 206);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 34;
            label4.Text = "Habilidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 177);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 33;
            label3.Text = "Alias";
            // 
            // txHabilidad
            // 
            txHabilidad.Location = new Point(153, 203);
            txHabilidad.Name = "txHabilidad";
            txHabilidad.Size = new Size(156, 23);
            txHabilidad.TabIndex = 31;
            // 
            // txAlias
            // 
            txAlias.Location = new Point(153, 174);
            txAlias.Name = "txAlias";
            txAlias.Size = new Size(156, 23);
            txAlias.TabIndex = 30;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(153, 145);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(156, 23);
            txNombre.TabIndex = 29;
            // 
            // txId
            // 
            txId.Location = new Point(153, 116);
            txId.Name = "txId";
            txId.Size = new Size(38, 23);
            txId.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 148);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 27;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 119);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 26;
            label1.Text = "Id";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(153, 235);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(156, 42);
            txtDescripcion.TabIndex = 39;
            txtDescripcion.Text = "";
            // 
            // frmAgregarHabilidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 371);
            Controls.Add(txtDescripcion);
            Controls.Add(label6);
            Controls.Add(btnRegresar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txHabilidad);
            Controls.Add(txAlias);
            Controls.Add(txNombre);
            Controls.Add(txId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAgregarHabilidad";
            Text = "frmAgregarHabilidad";
            Load += frmAgregarHabilidad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button btnRegresar;
        private Button btnAgregar;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txHabilidad;
        private TextBox txAlias;
        private TextBox txNombre;
        private TextBox txId;
        private Label label2;
        private Label label1;
        private RichTextBox txtDescripcion;
    }
}