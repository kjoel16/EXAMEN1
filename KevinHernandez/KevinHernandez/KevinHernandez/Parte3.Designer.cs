namespace KevinHernandez
{
    partial class Parte3
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
            this.GenerarNumerobutton = new System.Windows.Forms.Button();
            this.RegresoMenubutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerarNumerobutton
            // 
            this.GenerarNumerobutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GenerarNumerobutton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerarNumerobutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GenerarNumerobutton.Image = global::KevinHernandez.Properties.Resources.bloques_numericos__1_;
            this.GenerarNumerobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GenerarNumerobutton.Location = new System.Drawing.Point(1, 2);
            this.GenerarNumerobutton.Name = "GenerarNumerobutton";
            this.GenerarNumerobutton.Size = new System.Drawing.Size(145, 66);
            this.GenerarNumerobutton.TabIndex = 0;
            this.GenerarNumerobutton.Text = "Generar Numero";
            this.GenerarNumerobutton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.GenerarNumerobutton.UseVisualStyleBackColor = false;
            this.GenerarNumerobutton.Click += new System.EventHandler(this.GenerarNumerobutton_Click);
            // 
            // RegresoMenubutton
            // 
            this.RegresoMenubutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RegresoMenubutton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegresoMenubutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegresoMenubutton.Image = global::KevinHernandez.Properties.Resources.casa;
            this.RegresoMenubutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RegresoMenubutton.Location = new System.Drawing.Point(94, 74);
            this.RegresoMenubutton.Name = "RegresoMenubutton";
            this.RegresoMenubutton.Size = new System.Drawing.Size(145, 58);
            this.RegresoMenubutton.TabIndex = 10;
            this.RegresoMenubutton.Text = "Menu Principal";
            this.RegresoMenubutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RegresoMenubutton.UseVisualStyleBackColor = false;
            this.RegresoMenubutton.Click += new System.EventHandler(this.RegresoMenubutton_Click);
            // 
            // Parte3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(251, 141);
            this.Controls.Add(this.RegresoMenubutton);
            this.Controls.Add(this.GenerarNumerobutton);
            this.Name = "Parte3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero Aleatorio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerarNumerobutton;
        private System.Windows.Forms.Button RegresoMenubutton;
    }
}