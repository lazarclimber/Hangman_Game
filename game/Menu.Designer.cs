namespace game
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dotaHeroes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.animals = new System.Windows.Forms.Button();
            this.countries = new System.Windows.Forms.Button();
            this.actors = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 183);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::game.Properties.Resources.istockphoto_1196954772_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(697, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hangman";
            // 
            // dotaHeroes
            // 
            this.dotaHeroes.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotaHeroes.Location = new System.Drawing.Point(24, 128);
            this.dotaHeroes.Name = "dotaHeroes";
            this.dotaHeroes.Size = new System.Drawing.Size(452, 57);
            this.dotaHeroes.TabIndex = 1;
            this.dotaHeroes.Text = "DotA Heroes";
            this.dotaHeroes.UseVisualStyleBackColor = true;
            this.dotaHeroes.Click += new System.EventHandler(this.dotaHeroes_Click);
            this.dotaHeroes.MouseEnter += new System.EventHandler(this.dotaHeroes_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 61);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select A Topic";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.animals);
            this.panel2.Controls.Add(this.countries);
            this.panel2.Controls.Add(this.actors);
            this.panel2.Controls.Add(this.dotaHeroes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(241, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 441);
            this.panel2.TabIndex = 1;
            // 
            // animals
            // 
            this.animals.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animals.Location = new System.Drawing.Point(24, 318);
            this.animals.Name = "animals";
            this.animals.Size = new System.Drawing.Size(452, 57);
            this.animals.TabIndex = 5;
            this.animals.Text = "Animals";
            this.animals.UseVisualStyleBackColor = true;
            this.animals.Click += new System.EventHandler(this.animals_Click);
            this.animals.MouseEnter += new System.EventHandler(this.animals_MouseEnter);
            // 
            // countries
            // 
            this.countries.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countries.Location = new System.Drawing.Point(23, 255);
            this.countries.Name = "countries";
            this.countries.Size = new System.Drawing.Size(452, 57);
            this.countries.TabIndex = 4;
            this.countries.Text = "Europe Countries";
            this.countries.UseVisualStyleBackColor = true;
            this.countries.Click += new System.EventHandler(this.countries_Click);
            this.countries.MouseEnter += new System.EventHandler(this.countries_MouseEnter);
            // 
            // actors
            // 
            this.actors.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actors.Location = new System.Drawing.Point(23, 192);
            this.actors.Name = "actors";
            this.actors.Size = new System.Drawing.Size(452, 57);
            this.actors.TabIndex = 3;
            this.actors.Text = "Hollywood Actors";
            this.actors.UseVisualStyleBackColor = true;
            this.actors.Click += new System.EventHandler(this.actors_Click);
            this.actors.MouseEnter += new System.EventHandler(this.actors_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(761, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "By Lazar Ćirić";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 657);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dotaHeroes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button animals;
        private System.Windows.Forms.Button countries;
        private System.Windows.Forms.Button actors;
        private System.Windows.Forms.Label label3;
    }
}