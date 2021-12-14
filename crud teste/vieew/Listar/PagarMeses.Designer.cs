
namespace crud_teste.vieew.Listar
{
    partial class PagarMeses
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
            this.nudMeses = new System.Windows.Forms.NumericUpDown();
            this.txtquantidadeTotal = new crud_teste.Config.Custom_Controls.MoneyTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeses)).BeginInit();
            this.SuspendLayout();
            // 
            // nudMeses
            // 
            this.nudMeses.Location = new System.Drawing.Point(12, 35);
            this.nudMeses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMeses.Name = "nudMeses";
            this.nudMeses.Size = new System.Drawing.Size(260, 20);
            this.nudMeses.TabIndex = 0;
            this.nudMeses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMeses.ValueChanged += new System.EventHandler(this.nudMeses_ValueChanged);
            // 
            // txtquantidadeTotal
            // 
            this.txtquantidadeTotal.Location = new System.Drawing.Point(12, 105);
            this.txtquantidadeTotal.Name = "txtquantidadeTotal";
            this.txtquantidadeTotal.Negative = System.Drawing.Color.Red;
            this.txtquantidadeTotal.Positive = System.Drawing.Color.Green;
            this.txtquantidadeTotal.ReadOnly = true;
            this.txtquantidadeTotal.Size = new System.Drawing.Size(100, 20);
            this.txtquantidadeTotal.StyleText = false;
            this.txtquantidadeTotal.TabIndex = 1;
            this.txtquantidadeTotal.Text = "0,00";
            this.txtquantidadeTotal.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtquantidadeTotal.Zero = System.Drawing.Color.Black;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(130, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pagar Meses";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PagarMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 158);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtquantidadeTotal);
            this.Controls.Add(this.nudMeses);
            this.Name = "PagarMeses";
            this.Text = "PagarMeses";
            this.Load += new System.EventHandler(this.PagarMeses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMeses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudMeses;
        private Config.Custom_Controls.MoneyTextBox txtquantidadeTotal;
        private System.Windows.Forms.Button button1;
    }
}