namespace WindowsForms
{
    partial class FichaAnimal
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
            label1 = new Label();
            btn_FichaAnim_salir = new Button();
            dataGrid_ambos = new DataGridView();
            btn_agregar = new Button();
            box_esp_Anim = new TextBox();
            box_comi_Anim = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            box_nomb_Anim = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid_ambos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 9);
            label1.Name = "label1";
            label1.Size = new Size(248, 24);
            label1.TabIndex = 0;
            label1.Text = "LISTA DE ANIMALES";
            label1.Click += label1_Click;
            // 
            // btn_FichaAnim_salir
            // 
            btn_FichaAnim_salir.Location = new Point(249, 387);
            btn_FichaAnim_salir.Name = "btn_FichaAnim_salir";
            btn_FichaAnim_salir.Size = new Size(121, 30);
            btn_FichaAnim_salir.TabIndex = 1;
            btn_FichaAnim_salir.Text = "VOLVER";
            btn_FichaAnim_salir.UseVisualStyleBackColor = true;
            btn_FichaAnim_salir.Click += btn_FichaAnim_salir_Click;
            // 
            // dataGrid_ambos
            // 
            dataGrid_ambos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_ambos.Location = new Point(56, 51);
            dataGrid_ambos.Name = "dataGrid_ambos";
            dataGrid_ambos.Size = new Size(509, 166);
            dataGrid_ambos.TabIndex = 2;
            dataGrid_ambos.CellContentClick += dataGrid_animal_CellContentClick;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(249, 304);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(121, 40);
            btn_agregar.TabIndex = 3;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += button1_Click;
            // 
            // box_esp_Anim
            // 
            box_esp_Anim.Location = new Point(249, 259);
            box_esp_Anim.Name = "box_esp_Anim";
            box_esp_Anim.Size = new Size(114, 23);
            box_esp_Anim.TabIndex = 5;
            box_esp_Anim.TextChanged += box_esp_Anim_TextChanged;
            // 
            // box_comi_Anim
            // 
            box_comi_Anim.Location = new Point(451, 259);
            box_comi_Anim.Name = "box_comi_Anim";
            box_comi_Anim.Size = new Size(114, 23);
            box_comi_Anim.TabIndex = 6;
            box_comi_Anim.TextChanged += box_comi_Anim_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 235);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 235);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 9;
            label3.Text = "Especie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 235);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 10;
            label4.Text = "Comida";
            // 
            // box_nomb_Anim
            // 
            box_nomb_Anim.Location = new Point(56, 259);
            box_nomb_Anim.Name = "box_nomb_Anim";
            box_nomb_Anim.Size = new Size(114, 23);
            box_nomb_Anim.TabIndex = 4;
            box_nomb_Anim.TextChanged += textBox1_TextChanged;
            // 
            // FichaAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 429);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(box_comi_Anim);
            Controls.Add(box_esp_Anim);
            Controls.Add(box_nomb_Anim);
            Controls.Add(btn_agregar);
            Controls.Add(dataGrid_ambos);
            Controls.Add(btn_FichaAnim_salir);
            Controls.Add(label1);
            Name = "FichaAnimal";
            Text = "FichaAnimal";
            ((System.ComponentModel.ISupportInitialize)dataGrid_ambos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_FichaAnim_salir;
        private DataGridView dataGrid_ambos;
        private Button btn_agregar;
        private TextBox box_esp_Anim;
        private TextBox box_comi_Anim;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox box_nomb_Anim;
    }
}