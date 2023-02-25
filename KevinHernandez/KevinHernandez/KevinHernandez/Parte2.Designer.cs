namespace KevinHernandez
{
    partial class Parte2
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
            this.ProductotextBox = new System.Windows.Forms.TextBox();
            this.PrecioProductotextBox = new System.Windows.Forms.TextBox();
            this.ProductosdataGridView = new System.Windows.Forms.DataGridView();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Descuentobutton = new System.Windows.Forms.Button();
            this.AgregarProductobutton = new System.Windows.Forms.Button();
            this.RegresoMenubutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese precio del producto";
            // 
            // ProductotextBox
            // 
            this.ProductotextBox.Location = new System.Drawing.Point(366, 33);
            this.ProductotextBox.Name = "ProductotextBox";
            this.ProductotextBox.Size = new System.Drawing.Size(160, 20);
            this.ProductotextBox.TabIndex = 2;
            this.ProductotextBox.TextChanged += new System.EventHandler(this.ProductotextBox_TextChanged);
            this.ProductotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductotextBox_KeyPress);
            // 
            // PrecioProductotextBox
            // 
            this.PrecioProductotextBox.Location = new System.Drawing.Point(366, 90);
            this.PrecioProductotextBox.Name = "PrecioProductotextBox";
            this.PrecioProductotextBox.Size = new System.Drawing.Size(160, 20);
            this.PrecioProductotextBox.TabIndex = 3;
            this.PrecioProductotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioProductotextBox_KeyPress);
            // 
            // ProductosdataGridView
            // 
            this.ProductosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosdataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.ProductosdataGridView.Location = new System.Drawing.Point(12, 9);
            this.ProductosdataGridView.Name = "ProductosdataGridView";
            this.ProductosdataGridView.Size = new System.Drawing.Size(344, 286);
            this.ProductosdataGridView.TabIndex = 4;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(366, 146);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(160, 20);
            this.CantidadtextBox.TabIndex = 7;
            this.CantidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadtextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad del producto";
            // 
            // Descuentobutton
            // 
            this.Descuentobutton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descuentobutton.Image = global::KevinHernandez.Properties.Resources.dolar__2_;
            this.Descuentobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Descuentobutton.Location = new System.Drawing.Point(398, 230);
            this.Descuentobutton.Name = "Descuentobutton";
            this.Descuentobutton.Size = new System.Drawing.Size(124, 52);
            this.Descuentobutton.TabIndex = 6;
            this.Descuentobutton.Text = "Calcular Descuento";
            this.Descuentobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Descuentobutton.UseVisualStyleBackColor = true;
            this.Descuentobutton.Click += new System.EventHandler(this.Descuentobutton_Click);
            // 
            // AgregarProductobutton
            // 
            this.AgregarProductobutton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarProductobutton.Image = global::KevinHernandez.Properties.Resources.icons8_agregar_a_carrito_de_compras_48;
            this.AgregarProductobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarProductobutton.Location = new System.Drawing.Point(398, 172);
            this.AgregarProductobutton.Name = "AgregarProductobutton";
            this.AgregarProductobutton.Size = new System.Drawing.Size(124, 52);
            this.AgregarProductobutton.TabIndex = 5;
            this.AgregarProductobutton.Text = "        Agregar al carrito";
            this.AgregarProductobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarProductobutton.UseVisualStyleBackColor = true;
            this.AgregarProductobutton.Click += new System.EventHandler(this.AgregarProductobutton_Click);
            // 
            // RegresoMenubutton
            // 
            this.RegresoMenubutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RegresoMenubutton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegresoMenubutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegresoMenubutton.Image = global::KevinHernandez.Properties.Resources.casa;
            this.RegresoMenubutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegresoMenubutton.Location = new System.Drawing.Point(398, 288);
            this.RegresoMenubutton.Name = "RegresoMenubutton";
            this.RegresoMenubutton.Size = new System.Drawing.Size(124, 58);
            this.RegresoMenubutton.TabIndex = 9;
            this.RegresoMenubutton.Text = "Menu Principal";
            this.RegresoMenubutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegresoMenubutton.UseVisualStyleBackColor = false;
            this.RegresoMenubutton.Click += new System.EventHandler(this.RegresoMenubutton_Click);
            // 
            // Parte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 350);
            this.Controls.Add(this.RegresoMenubutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.Descuentobutton);
            this.Controls.Add(this.AgregarProductobutton);
            this.Controls.Add(this.ProductosdataGridView);
            this.Controls.Add(this.PrecioProductotextBox);
            this.Controls.Add(this.ProductotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Parte2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercadito";
            ((System.ComponentModel.ISupportInitialize)(this.ProductosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductotextBox;
        private System.Windows.Forms.TextBox PrecioProductotextBox;
        private System.Windows.Forms.DataGridView ProductosdataGridView;
        private System.Windows.Forms.Button AgregarProductobutton;
        private System.Windows.Forms.Button Descuentobutton;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RegresoMenubutton;
    }
}