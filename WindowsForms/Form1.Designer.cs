namespace WindowsForms
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
            labelMenuPrinc = new Label();
            btn_verAnimales = new Button();
            btn_verCuidadores = new Button();
            btn_salir = new Button();
            SuspendLayout();
            // 
            // labelMenuPrinc
            // 
            labelMenuPrinc.AutoSize = true;
            labelMenuPrinc.BackColor = Color.Transparent;
            labelMenuPrinc.Font = new Font("FreeUniversal", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenuPrinc.Location = new Point(251, 9);
            labelMenuPrinc.Name = "labelMenuPrinc";
            labelMenuPrinc.Size = new Size(312, 45);
            labelMenuPrinc.TabIndex = 1;
            labelMenuPrinc.Text = "MENU PRINCIPAL";
            labelMenuPrinc.TextAlign = ContentAlignment.MiddleCenter;
            labelMenuPrinc.Click += label1_Click;
            // 
            // btn_verAnimales
            // 
            btn_verAnimales.Location = new Point(326, 80);
            btn_verAnimales.Name = "btn_verAnimales";
            btn_verAnimales.Size = new Size(150, 41);
            btn_verAnimales.TabIndex = 2;
            btn_verAnimales.Text = "VER LISTA ANIMALES";
            btn_verAnimales.UseVisualStyleBackColor = true;
            btn_verAnimales.Click += btn_verAnimales_Click;
            // 
            // btn_verCuidadores
            // 
            btn_verCuidadores.Location = new Point(326, 149);
            btn_verCuidadores.Name = "btn_verCuidadores";
            btn_verCuidadores.Size = new Size(150, 41);
            btn_verCuidadores.TabIndex = 3;
            btn_verCuidadores.Text = "VER LISTA CUIDADORES";
            btn_verCuidadores.UseVisualStyleBackColor = true;
            btn_verCuidadores.Click += btn_verCuidadores_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(326, 337);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(150, 41);
            btn_salir.TabIndex = 4;
            btn_salir.Text = "SALIR";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_salir);
            Controls.Add(btn_verCuidadores);
            Controls.Add(btn_verAnimales);
            Controls.Add(labelMenuPrinc);
            Name = "Form1";
            Text = "ZOOLOGICO";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelMenuPrinc;
        private Button btn_verAnimales;
        private Button btn_verCuidadores;
        private Button btn_salir;
    }
}
