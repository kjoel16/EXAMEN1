namespace KevinHernandez
{
    partial class Parte1
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
            this.Intereseslist = new System.Windows.Forms.ListView();
            this.Meses = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.RegresoMenubutton = new System.Windows.Forms.Button();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Intereseslist
            // 
            this.Intereseslist.HideSelection = false;
            this.Intereseslist.Location = new System.Drawing.Point(4, 75);
            this.Intereseslist.Name = "Intereseslist";
            this.Intereseslist.Size = new System.Drawing.Size(119, 363);
            this.Intereseslist.TabIndex = 1;
            this.Intereseslist.UseCompatibleStateImageBehavior = false;
            // 
            // Meses
            // 
            this.Meses.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Meses.Location = new System.Drawing.Point(4, 49);
            this.Meses.Name = "Meses";
            this.Meses.Size = new System.Drawing.Size(119, 20);
            this.Meses.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calculo de Interes de Deposito";
            // 
            // RegresoMenubutton
            // 
            this.RegresoMenubutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegresoMenubutton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegresoMenubutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RegresoMenubutton.Image = global::KevinHernandez.Properties.Resources.casa;
            this.RegresoMenubutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegresoMenubutton.Location = new System.Drawing.Point(129, 92);
            this.RegresoMenubutton.Name = "RegresoMenubutton";
            this.RegresoMenubutton.Size = new System.Drawing.Size(131, 58);
            this.RegresoMenubutton.TabIndex = 3;
            this.RegresoMenubutton.Text = "Menu Principal";
            this.RegresoMenubutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegresoMenubutton.UseVisualStyleBackColor = false;
            this.RegresoMenubutton.Click += new System.EventHandler(this.RegresoMenubutton_Click);
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Calcularbutton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcularbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Calcularbutton.Image = global::KevinHernandez.Properties.Resources.presupuesto;
            this.Calcularbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Calcularbutton.Location = new System.Drawing.Point(129, 49);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(131, 37);
            this.Calcularbutton.TabIndex = 0;
            this.Calcularbutton.Text = "  Calcular";
            this.Calcularbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Calcularbutton.UseVisualStyleBackColor = false;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // Parte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(263, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegresoMenubutton);
            this.Controls.Add(this.Meses);
            this.Controls.Add(this.Intereseslist);
            this.Controls.Add(this.Calcularbutton);
            this.Name = "Parte1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parte1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.ListView Intereseslist;
        private System.Windows.Forms.DateTimePicker Meses;
        private System.Windows.Forms.Button RegresoMenubutton;
        private System.Windows.Forms.Label label1;
    }
}