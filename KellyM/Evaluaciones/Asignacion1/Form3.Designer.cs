namespace Asignacion1
{
    partial class Form3
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
            this.label5 = new System.Windows.Forms.Label();
            this.mtSubTotal = new System.Windows.Forms.MaskedTextBox();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mtMontoPay = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcVuelto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "IVA";
            // 
            // mtSubTotal
            // 
            this.mtSubTotal.Location = new System.Drawing.Point(54, 36);
            this.mtSubTotal.Mask = "9999900000000";
            this.mtSubTotal.Name = "mtSubTotal";
            this.mtSubTotal.Size = new System.Drawing.Size(100, 23);
            this.mtSubTotal.TabIndex = 5;
            this.mtSubTotal.ValidatingType = typeof(int);
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Location = new System.Drawing.Point(249, 60);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(69, 22);
            this.rbTarjeta.TabIndex = 6;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Tarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Location = new System.Drawing.Point(249, 97);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(75, 22);
            this.rbEfectivo.TabIndex = 7;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // txtIVA
            // 
            this.txtIVA.BackColor = System.Drawing.Color.MistyRose;
            this.txtIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIVA.Location = new System.Drawing.Point(54, 97);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 23);
            this.txtIVA.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.MistyRose;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(54, 154);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Monto a pagar";
            // 
            // txtVuelto
            // 
            this.txtVuelto.BackColor = System.Drawing.Color.RosyBrown;
            this.txtVuelto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVuelto.Location = new System.Drawing.Point(461, 98);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.Size = new System.Drawing.Size(100, 23);
            this.txtVuelto.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Vuelto";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Location = new System.Drawing.Point(36, 199);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(118, 47);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Calcular total con descuento";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(382, 234);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 28);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(504, 234);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 28);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mtMontoPay
            // 
            this.mtMontoPay.Location = new System.Drawing.Point(461, 36);
            this.mtMontoPay.Mask = "9999900000000";
            this.mtMontoPay.Name = "mtMontoPay";
            this.mtMontoPay.Size = new System.Drawing.Size(100, 23);
            this.mtMontoPay.TabIndex = 18;
            this.mtMontoPay.ValidatingType = typeof(int);
            // 
            // btnCalcVuelto
            // 
            this.btnCalcVuelto.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCalcVuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcVuelto.Location = new System.Drawing.Point(435, 165);
            this.btnCalcVuelto.Name = "btnCalcVuelto";
            this.btnCalcVuelto.Size = new System.Drawing.Size(126, 32);
            this.btnCalcVuelto.TabIndex = 19;
            this.btnCalcVuelto.Text = "Calcular vuelto";
            this.btnCalcVuelto.UseVisualStyleBackColor = false;
            this.btnCalcVuelto.Click += new System.EventHandler(this.btnCalcVuelto_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(599, 274);
            this.Controls.Add(this.btnCalcVuelto);
            this.Controls.Add(this.mtMontoPay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtVuelto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.rbEfectivo);
            this.Controls.Add(this.rbTarjeta);
            this.Controls.Add(this.mtSubTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label5;
        private MaskedTextBox mtSubTotal;
        private RadioButton rbTarjeta;
        private RadioButton rbEfectivo;
        private TextBox txtIVA;
        private TextBox txtTotal;
        private Label label2;
        private Label label3;
        private TextBox txtVuelto;
        private Label label4;
        private Button btnCalc;
        private Button btnClear;
        private Button btnExit;
        private MaskedTextBox mtMontoPay;
        private Button btnCalcVuelto;
    }
}