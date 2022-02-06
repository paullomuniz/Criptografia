
namespace Criptografia
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
            this.numericUpDownChave1 = new System.Windows.Forms.NumericUpDown();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.brnEncriptografar = new System.Windows.Forms.Button();
            this.brnDescriptografar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownChave2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChave1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChave2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownChave1
            // 
            this.numericUpDownChave1.Location = new System.Drawing.Point(87, 93);
            this.numericUpDownChave1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownChave1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownChave1.Name = "numericUpDownChave1";
            this.numericUpDownChave1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownChave1.TabIndex = 0;
            this.numericUpDownChave1.Value = new decimal(new int[] {
            7062019,
            0,
            0,
            0});
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(87, 47);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(448, 23);
            this.txtTexto.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(89, 260);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(448, 23);
            this.txtResultado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chave 1";
            // 
            // brnEncriptografar
            // 
            this.brnEncriptografar.Location = new System.Drawing.Point(107, 201);
            this.brnEncriptografar.Name = "brnEncriptografar";
            this.brnEncriptografar.Size = new System.Drawing.Size(124, 23);
            this.brnEncriptografar.TabIndex = 6;
            this.brnEncriptografar.Text = "Encriptografar";
            this.brnEncriptografar.UseVisualStyleBackColor = true;
            this.brnEncriptografar.Click += new System.EventHandler(this.brnEncriptografar_Click);
            // 
            // brnDescriptografar
            // 
            this.brnDescriptografar.Location = new System.Drawing.Point(290, 201);
            this.brnDescriptografar.Name = "brnDescriptografar";
            this.brnDescriptografar.Size = new System.Drawing.Size(126, 23);
            this.brnDescriptografar.TabIndex = 7;
            this.brnDescriptografar.Text = "Descriptografar";
            this.brnDescriptografar.UseVisualStyleBackColor = true;
            this.brnDescriptografar.Click += new System.EventHandler(this.brnDescriptografar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chave 2";
            // 
            // numericUpDownChave2
            // 
            this.numericUpDownChave2.Location = new System.Drawing.Point(87, 137);
            this.numericUpDownChave2.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownChave2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownChave2.Name = "numericUpDownChave2";
            this.numericUpDownChave2.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownChave2.TabIndex = 8;
            this.numericUpDownChave2.Value = new decimal(new int[] {
            1562018,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 299);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownChave2);
            this.Controls.Add(this.brnDescriptografar);
            this.Controls.Add(this.brnEncriptografar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.numericUpDownChave1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criptografia by Paulo Muniz";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChave1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChave2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownChave1;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button brnEncriptografar;
        private System.Windows.Forms.Button brnDescriptografar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownChave2;
    }
}

