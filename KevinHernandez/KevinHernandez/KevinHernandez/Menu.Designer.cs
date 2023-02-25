namespace KevinHernandez
{
    partial class Menu
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
            this.AbrirParte1button = new System.Windows.Forms.Button();
            this.Supermercadobutton = new System.Windows.Forms.Button();
            this.Multiplosbutton = new System.Windows.Forms.Button();
            this.Cerrarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AbrirParte1button
            // 
            this.AbrirParte1button.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbrirParte1button.Image = global::KevinHernandez.Properties.Resources.presupuesto;
            this.AbrirParte1button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AbrirParte1button.Location = new System.Drawing.Point(12, 33);
            this.AbrirParte1button.Name = "AbrirParte1button";
            this.AbrirParte1button.Size = new System.Drawing.Size(127, 56);
            this.AbrirParte1button.TabIndex = 0;
            this.AbrirParte1button.Text = "Calculo de Interes";
            this.AbrirParte1button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AbrirParte1button.UseVisualStyleBackColor = true;
            this.AbrirParte1button.Click += new System.EventHandler(this.AbrirParte1button_Click);
            // 
            // Supermercadobutton
            // 
            this.Supermercadobutton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supermercadobutton.Image = global::KevinHernandez.Properties.Resources.icons8_agregar_a_carrito_de_compras_48;
            this.Supermercadobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Supermercadobutton.Location = new System.Drawing.Point(12, 95);
            this.Supermercadobutton.Name = "Supermercadobutton";
            this.Supermercadobutton.Size = new System.Drawing.Size(231, 45);
            this.Supermercadobutton.TabIndex = 1;
            this.Supermercadobutton.Text = "Supermercado";
            this.Supermercadobutton.UseVisualStyleBackColor = true;
            this.Supermercadobutton.Click += new System.EventHandler(this.Supermercadobutton_Click);
            // 
            // Multiplosbutton
            // 
            this.Multiplosbutton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplosbutton.Image = global::KevinHernandez.Properties.Resources.bloques_numericos__1_;
            this.Multiplosbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Multiplosbutton.Location = new System.Drawing.Point(145, 33);
            this.Multiplosbutton.Name = "Multiplosbutton";
            this.Multiplosbutton.Size = new System.Drawing.Size(98, 56);
            this.Multiplosbutton.TabIndex = 2;
            this.Multiplosbutton.Text = "Multiplos";
            this.Multiplosbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Multiplosbutton.UseVisualStyleBackColor = true;
            this.Multiplosbutton.Click += new System.EventHandler(this.Multiplosbutton_Click);
            // 
            // Cerrarbutton
            // 
            this.Cerrarbutton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrarbutton.Image = global::KevinHernandez.Properties.Resources.casa;
            this.Cerrarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cerrarbutton.Location = new System.Drawing.Point(12, 146);
            this.Cerrarbutton.Name = "Cerrarbutton";
            this.Cerrarbutton.Size = new System.Drawing.Size(231, 45);
            this.Cerrarbutton.TabIndex = 3;
            this.Cerrarbutton.Text = "Cerrar Programa";
            this.Cerrarbutton.UseVisualStyleBackColor = true;
            this.Cerrarbutton.Click += new System.EventHandler(this.Cerrarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenido al Menu Principal";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(265, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cerrarbutton);
            this.Controls.Add(this.Multiplosbutton);
            this.Controls.Add(this.Supermercadobutton);
            this.Controls.Add(this.AbrirParte1button);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AbrirParte1button;
        private System.Windows.Forms.Button Supermercadobutton;
        private System.Windows.Forms.Button Multiplosbutton;
        private System.Windows.Forms.Button Cerrarbutton;
        private System.Windows.Forms.Label label1;
    }
}