namespace ConversionArimetica_Infija_Posfija_Prefija
{
    partial class FrmPosfija
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
            this.panelCrear = new System.Windows.Forms.GroupBox();
            this.txtPrefija = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPosfija = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtexpresion = new System.Windows.Forms.TextBox();
            this.btnConversion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCrear.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONVERSION DE INFIJA A POSFIJA";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panelCrear
            // 
            this.panelCrear.Controls.Add(this.txtPrefija);
            this.panelCrear.Controls.Add(this.label4);
            this.panelCrear.Controls.Add(this.txtPosfija);
            this.panelCrear.Controls.Add(this.label3);
            this.panelCrear.Controls.Add(this.txtexpresion);
            this.panelCrear.Controls.Add(this.btnConversion);
            this.panelCrear.Controls.Add(this.label2);
            this.panelCrear.Location = new System.Drawing.Point(12, 63);
            this.panelCrear.Name = "panelCrear";
            this.panelCrear.Size = new System.Drawing.Size(474, 230);
            this.panelCrear.TabIndex = 6;
            this.panelCrear.TabStop = false;
            this.panelCrear.Text = "POSFIJA";
            // 
            // txtPrefija
            // 
            this.txtPrefija.Location = new System.Drawing.Point(237, 155);
            this.txtPrefija.Name = "txtPrefija";
            this.txtPrefija.Size = new System.Drawing.Size(215, 20);
            this.txtPrefija.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "NOTACION  PREFIJA";
            // 
            // txtPosfija
            // 
            this.txtPosfija.Location = new System.Drawing.Point(237, 102);
            this.txtPosfija.Name = "txtPosfija";
            this.txtPosfija.Size = new System.Drawing.Size(215, 20);
            this.txtPosfija.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOTACION  POSFIJA";
            // 
            // txtexpresion
            // 
            this.txtexpresion.Location = new System.Drawing.Point(19, 45);
            this.txtexpresion.Name = "txtexpresion";
            this.txtexpresion.Size = new System.Drawing.Size(205, 20);
            this.txtexpresion.TabIndex = 6;
            // 
            // btnConversion
            // 
            this.btnConversion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversion.Location = new System.Drawing.Point(265, 41);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(101, 27);
            this.btnConversion.TabIndex = 5;
            this.btnConversion.Text = "CONVERSION";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.BtnConversion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "EXPRESION";
            // 
            // FrmPosfija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.panelCrear);
            this.Controls.Add(this.label1);
            this.Name = "FrmPosfija";
            this.Text = "FrmPosfija";
            this.panelCrear.ResumeLayout(false);
            this.panelCrear.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox panelCrear;
        private System.Windows.Forms.TextBox txtPosfija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtexpresion;
        private System.Windows.Forms.Button btnConversion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrefija;
        private System.Windows.Forms.Label label4;
    }
}