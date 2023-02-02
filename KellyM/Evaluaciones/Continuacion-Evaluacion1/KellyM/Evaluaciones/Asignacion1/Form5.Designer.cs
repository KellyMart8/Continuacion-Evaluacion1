namespace Asignacion1
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxTipoD = new System.Windows.Forms.ListBox();
            this.chlbxTipoBien = new System.Windows.Forms.CheckedListBox();
            this.mtValorBien = new System.Windows.Forms.MaskedTextBox();
            this.txtDepre = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de depreciacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de bien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Depreciacion";
            // 
            // lbxTipoD
            // 
            this.lbxTipoD.FormattingEnabled = true;
            this.lbxTipoD.ItemHeight = 18;
            this.lbxTipoD.Items.AddRange(new object[] {
            "Linea recta",
            "Suma de digitos"});
            this.lbxTipoD.Location = new System.Drawing.Point(133, 53);
            this.lbxTipoD.Name = "lbxTipoD";
            this.lbxTipoD.Size = new System.Drawing.Size(179, 40);
            this.lbxTipoD.TabIndex = 4;
            // 
            // chlbxTipoBien
            // 
            this.chlbxTipoBien.FormattingEnabled = true;
            this.chlbxTipoBien.Items.AddRange(new object[] {
            "Vehiculo",
            "Edificio",
            "Equipo de oficina"});
            this.chlbxTipoBien.Location = new System.Drawing.Point(133, 122);
            this.chlbxTipoBien.Name = "chlbxTipoBien";
            this.chlbxTipoBien.Size = new System.Drawing.Size(179, 55);
            this.chlbxTipoBien.TabIndex = 5;
            // 
            // mtValorBien
            // 
            this.mtValorBien.Location = new System.Drawing.Point(133, 219);
            this.mtValorBien.Mask = "99999999999999999";
            this.mtValorBien.Name = "mtValorBien";
            this.mtValorBien.Size = new System.Drawing.Size(100, 22);
            this.mtValorBien.TabIndex = 6;
            this.mtValorBien.ValidatingType = typeof(int);
            // 
            // txtDepre
            // 
            this.txtDepre.Enabled = false;
            this.txtDepre.Location = new System.Drawing.Point(133, 287);
            this.txtDepre.Name = "txtDepre";
            this.txtDepre.Size = new System.Drawing.Size(100, 22);
            this.txtDepre.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 372);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(80, 28);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(142, 372);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 28);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(280, 372);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor del bien";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 414);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDepre);
            this.Controls.Add(this.mtValorBien);
            this.Controls.Add(this.chlbxTipoBien);
            this.Controls.Add(this.lbxTipoD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lbxTipoD;
        private CheckedListBox chlbxTipoBien;
        private MaskedTextBox mtValorBien;
        private TextBox txtDepre;
        private Button btnCalcular;
        private Button btnClear;
        private Button btnSalir;
        private Label label5;
    }
}