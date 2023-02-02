namespace Asignacion1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtIng = new System.Windows.Forms.MaskedTextBox();
            this.mtMontoReq = new System.Windows.Forms.MaskedTextBox();
            this.mtEgr = new System.Windows.Forms.MaskedTextBox();
            this.cboTipoIn = new System.Windows.Forms.ComboBox();
            this.cboPlazo = new System.Windows.Forms.ComboBox();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plazo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto requerido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Egreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ingreso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cuota";
            // 
            // mtIng
            // 
            this.mtIng.Location = new System.Drawing.Point(59, 90);
            this.mtIng.Mask = "999999999999";
            this.mtIng.Name = "mtIng";
            this.mtIng.Size = new System.Drawing.Size(89, 23);
            this.mtIng.TabIndex = 7;
            this.mtIng.ValidatingType = typeof(int);
            // 
            // mtMontoReq
            // 
            this.mtMontoReq.Location = new System.Drawing.Point(420, 90);
            this.mtMontoReq.Mask = "999999999999";
            this.mtMontoReq.Name = "mtMontoReq";
            this.mtMontoReq.Size = new System.Drawing.Size(89, 23);
            this.mtMontoReq.TabIndex = 8;
            this.mtMontoReq.ValidatingType = typeof(int);
            // 
            // mtEgr
            // 
            this.mtEgr.Location = new System.Drawing.Point(59, 148);
            this.mtEgr.Mask = "999999999999";
            this.mtEgr.Name = "mtEgr";
            this.mtEgr.Size = new System.Drawing.Size(89, 23);
            this.mtEgr.TabIndex = 9;
            this.mtEgr.ValidatingType = typeof(int);
            // 
            // cboTipoIn
            // 
            this.cboTipoIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoIn.FormattingEnabled = true;
            this.cboTipoIn.Items.AddRange(new object[] {
            "Asalariado",
            "Jubilado",
            "Ingreso propio"});
            this.cboTipoIn.Location = new System.Drawing.Point(420, 31);
            this.cboTipoIn.Name = "cboTipoIn";
            this.cboTipoIn.Size = new System.Drawing.Size(121, 26);
            this.cboTipoIn.TabIndex = 10;
            // 
            // cboPlazo
            // 
            this.cboPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlazo.FormattingEnabled = true;
            this.cboPlazo.Items.AddRange(new object[] {
            "6",
            "9",
            "12",
            "19",
            "24",
            "36"});
            this.cboPlazo.Location = new System.Drawing.Point(420, 145);
            this.cboPlazo.Name = "cboPlazo";
            this.cboPlazo.Size = new System.Drawing.Size(121, 26);
            this.cboPlazo.TabIndex = 11;
            // 
            // txtCuota
            // 
            this.txtCuota.BackColor = System.Drawing.Color.RosyBrown;
            this.txtCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuota.Location = new System.Drawing.Point(59, 248);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(100, 23);
            this.txtCuota.TabIndex = 12;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.RosyBrown;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.ForeColor = System.Drawing.Color.Black;
            this.txtEstado.Location = new System.Drawing.Point(59, 291);
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(202, 61);
            this.txtEstado.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(59, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 14;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Location = new System.Drawing.Point(322, 269);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(92, 26);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightCoral;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(449, 269);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(92, 26);
            this.btnClean.TabIndex = 16;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(449, 335);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 26);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(555, 382);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.cboPlazo);
            this.Controls.Add(this.cboTipoIn);
            this.Controls.Add(this.mtEgr);
            this.Controls.Add(this.mtMontoReq);
            this.Controls.Add(this.mtIng);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaskedTextBox mtIng;
        private MaskedTextBox mtMontoReq;
        private MaskedTextBox mtEgr;
        private ComboBox cboTipoIn;
        private ComboBox cboPlazo;
        private TextBox txtCuota;
        private TextBox txtEstado;
        private TextBox txtName;
        private Button btnCalc;
        private Button btnClean;
        private Button btnExit;
    }
}