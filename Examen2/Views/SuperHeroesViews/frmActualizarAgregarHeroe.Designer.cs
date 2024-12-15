namespace Examen2.Views.SuperHeroesViews
{
    partial class frmActualizarAgregarHeroe
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
            btnGuardar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txNivelPoder = new TextBox();
            txOrigen = new TextBox();
            txAlias = new TextBox();
            txNombre = new TextBox();
            txId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(79, 46);
            label6.Name = "label6";
            label6.Size = new Size(226, 30);
            label6.TabIndex = 25;
            label6.Text = "Actualizar Superheroe";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(204, 293);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 24;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(102, 293);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.RightToLeft = RightToLeft.Yes;
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 230);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 22;
            label5.Text = "Nivel de Poder";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 201);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 21;
            label4.Text = "Origen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 172);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 20;
            label3.Text = "Alias";
            // 
            // txNivelPoder
            // 
            txNivelPoder.Location = new Point(149, 227);
            txNivelPoder.Name = "txNivelPoder";
            txNivelPoder.Size = new Size(156, 23);
            txNivelPoder.TabIndex = 19;
            // 
            // txOrigen
            // 
            txOrigen.Location = new Point(149, 198);
            txOrigen.Name = "txOrigen";
            txOrigen.Size = new Size(156, 23);
            txOrigen.TabIndex = 18;
            // 
            // txAlias
            // 
            txAlias.Location = new Point(149, 169);
            txAlias.Name = "txAlias";
            txAlias.Size = new Size(156, 23);
            txAlias.TabIndex = 17;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(149, 140);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(156, 23);
            txNombre.TabIndex = 16;
            // 
            // txId
            // 
            txId.Location = new Point(149, 111);
            txId.Name = "txId";
            txId.Size = new Size(38, 23);
            txId.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 143);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 114);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 13;
            label1.Text = "Id";
            // 
            // frmActualizarAgregarHeroe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 371);
            Controls.Add(label6);
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txNivelPoder);
            Controls.Add(txOrigen);
            Controls.Add(txAlias);
            Controls.Add(txNombre);
            Controls.Add(txId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmActualizarAgregarHeroe";
            Text = "frmActualizar";
            Load += frmActualizarAgregarHeroe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button btnRegresar;
        private Button btnGuardar;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txNivelPoder;
        private TextBox txOrigen;
        private TextBox txAlias;
        private TextBox txNombre;
        private TextBox txId;
        private Label label2;
        private Label label1;
    }
}