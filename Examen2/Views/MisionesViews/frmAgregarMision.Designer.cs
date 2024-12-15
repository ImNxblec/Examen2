namespace Examen2.Views.MisionesViews
{
    partial class frmAgregarMision
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
            txtDescripcion = new RichTextBox();
            btnRegresar = new Button();
            btnAgregar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txMision = new TextBox();
            txAlias = new TextBox();
            txNombre = new TextBox();
            txId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            txPoder = new TextBox();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(156, 205);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(156, 42);
            txtDescripcion.TabIndex = 51;
            txtDescripcion.Text = "";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(226, 300);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 50;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(124, 300);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 49;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 205);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 48;
            label5.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 176);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 47;
            label4.Text = "Mision";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 121);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 46;
            label3.Text = "Alias";
            // 
            // txMision
            // 
            txMision.Location = new Point(156, 173);
            txMision.Name = "txMision";
            txMision.Size = new Size(156, 23);
            txMision.TabIndex = 45;
            // 
            // txAlias
            // 
            txAlias.Location = new Point(156, 118);
            txAlias.Name = "txAlias";
            txAlias.Size = new Size(156, 23);
            txAlias.TabIndex = 44;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(156, 89);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(156, 23);
            txNombre.TabIndex = 43;
            // 
            // txId
            // 
            txId.Location = new Point(156, 60);
            txId.Name = "txId";
            txId.Size = new Size(38, 23);
            txId.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 92);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 41;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 63);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 40;
            label1.Text = "Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(156, 20);
            label6.Name = "label6";
            label6.Size = new Size(89, 28);
            label6.TabIndex = 52;
            label6.Text = "Misiones";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(108, 262);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 53;
            label7.Text = "Estado";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(156, 259);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 54;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(118, 147);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 55;
            label8.Text = "Poder";
            // 
            // txPoder
            // 
            txPoder.Location = new Point(156, 144);
            txPoder.Name = "txPoder";
            txPoder.Size = new Size(156, 23);
            txPoder.TabIndex = 56;
            // 
            // frmAgregarMision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 371);
            Controls.Add(txPoder);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtDescripcion);
            Controls.Add(btnRegresar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txMision);
            Controls.Add(txAlias);
            Controls.Add(txNombre);
            Controls.Add(txId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAgregarMision";
            Text = "frmAgregarMision";
            Load += frmAgregarMision_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtDescripcion;
        private Button btnRegresar;
        private Button btnAgregar;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txMision;
        private TextBox txAlias;
        private TextBox txNombre;
        private TextBox txId;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private TextBox txPoder;
    }
}