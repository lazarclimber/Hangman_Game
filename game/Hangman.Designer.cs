namespace game
{
    partial class Hangman
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
            this.rightLeg = new System.Windows.Forms.PictureBox();
            this.leftLeg = new System.Windows.Forms.PictureBox();
            this.rightArm = new System.Windows.Forms.PictureBox();
            this.leftArm = new System.Windows.Forms.PictureBox();
            this.body = new System.Windows.Forms.PictureBox();
            this.head = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wordText = new System.Windows.Forms.Label();
            this.q = new System.Windows.Forms.Button();
            this.w = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.y = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.Button();
            this.o = new System.Windows.Forms.Button();
            this.i = new System.Windows.Forms.Button();
            this.u = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Button();
            this.h = new System.Windows.Forms.Button();
            this.g = new System.Windows.Forms.Button();
            this.f = new System.Windows.Forms.Button();
            this.k = new System.Windows.Forms.Button();
            this.j = new System.Windows.Forms.Button();
            this.p = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Button();
            this.m = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.v = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.Button();
            this.z = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.topicLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rightLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightLeg
            // 
            this.rightLeg.Image = global::game.Properties.Resources.right;
            this.rightLeg.Location = new System.Drawing.Point(320, 181);
            this.rightLeg.Name = "rightLeg";
            this.rightLeg.Size = new System.Drawing.Size(68, 62);
            this.rightLeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightLeg.TabIndex = 6;
            this.rightLeg.TabStop = false;
            this.rightLeg.Visible = false;
            // 
            // leftLeg
            // 
            this.leftLeg.Image = global::game.Properties.Resources.left;
            this.leftLeg.Location = new System.Drawing.Point(258, 181);
            this.leftLeg.Name = "leftLeg";
            this.leftLeg.Size = new System.Drawing.Size(66, 62);
            this.leftLeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftLeg.TabIndex = 5;
            this.leftLeg.TabStop = false;
            this.leftLeg.Visible = false;
            // 
            // rightArm
            // 
            this.rightArm.Image = global::game.Properties.Resources.right;
            this.rightArm.Location = new System.Drawing.Point(322, 115);
            this.rightArm.Name = "rightArm";
            this.rightArm.Size = new System.Drawing.Size(54, 48);
            this.rightArm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightArm.TabIndex = 4;
            this.rightArm.TabStop = false;
            this.rightArm.Visible = false;
            // 
            // leftArm
            // 
            this.leftArm.Image = global::game.Properties.Resources.left;
            this.leftArm.Location = new System.Drawing.Point(264, 114);
            this.leftArm.Name = "leftArm";
            this.leftArm.Size = new System.Drawing.Size(50, 49);
            this.leftArm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftArm.TabIndex = 3;
            this.leftArm.TabStop = false;
            this.leftArm.Visible = false;
            // 
            // body
            // 
            this.body.Image = global::game.Properties.Resources.body;
            this.body.Location = new System.Drawing.Point(314, 105);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(10, 82);
            this.body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.body.TabIndex = 2;
            this.body.TabStop = false;
            this.body.Visible = false;
            // 
            // head
            // 
            this.head.Image = global::game.Properties.Resources.head;
            this.head.Location = new System.Drawing.Point(282, 61);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(68, 47);
            this.head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.head.TabIndex = 1;
            this.head.TabStop = false;
            this.head.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::game.Properties.Resources.hang;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // wordText
            // 
            this.wordText.AutoSize = true;
            this.wordText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wordText.Location = new System.Drawing.Point(77, 46);
            this.wordText.Name = "wordText";
            this.wordText.Size = new System.Drawing.Size(0, 54);
            this.wordText.TabIndex = 8;
            // 
            // q
            // 
            this.q.BackColor = System.Drawing.Color.Gainsboro;
            this.q.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.q.Location = new System.Drawing.Point(255, 490);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(40, 40);
            this.q.TabIndex = 9;
            this.q.Text = "Q";
            this.q.UseVisualStyleBackColor = false;
            this.q.Click += new System.EventHandler(this.Button_Click);
            // 
            // w
            // 
            this.w.BackColor = System.Drawing.Color.Gainsboro;
            this.w.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.w.Location = new System.Drawing.Point(301, 490);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(40, 40);
            this.w.TabIndex = 10;
            this.w.Text = "W";
            this.w.UseVisualStyleBackColor = false;
            this.w.Click += new System.EventHandler(this.Button_Click);
            // 
            // e
            // 
            this.e.BackColor = System.Drawing.Color.Gainsboro;
            this.e.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e.Location = new System.Drawing.Point(347, 490);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(40, 40);
            this.e.TabIndex = 11;
            this.e.Text = "E";
            this.e.UseVisualStyleBackColor = false;
            this.e.Click += new System.EventHandler(this.Button_Click);
            // 
            // y
            // 
            this.y.BackColor = System.Drawing.Color.Gainsboro;
            this.y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.y.Location = new System.Drawing.Point(485, 490);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(40, 40);
            this.y.TabIndex = 14;
            this.y.Text = "Y";
            this.y.UseVisualStyleBackColor = false;
            this.y.Click += new System.EventHandler(this.Button_Click);
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.Color.Gainsboro;
            this.t.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.t.Location = new System.Drawing.Point(439, 490);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(40, 40);
            this.t.TabIndex = 13;
            this.t.Text = "T";
            this.t.UseVisualStyleBackColor = false;
            this.t.Click += new System.EventHandler(this.Button_Click);
            // 
            // r
            // 
            this.r.BackColor = System.Drawing.Color.Gainsboro;
            this.r.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r.Location = new System.Drawing.Point(393, 490);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(40, 40);
            this.r.TabIndex = 12;
            this.r.Text = "R";
            this.r.UseVisualStyleBackColor = false;
            this.r.Click += new System.EventHandler(this.Button_Click);
            // 
            // o
            // 
            this.o.BackColor = System.Drawing.Color.Gainsboro;
            this.o.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.o.Location = new System.Drawing.Point(623, 490);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(40, 40);
            this.o.TabIndex = 17;
            this.o.Text = "O";
            this.o.UseVisualStyleBackColor = false;
            this.o.Click += new System.EventHandler(this.Button_Click);
            // 
            // i
            // 
            this.i.BackColor = System.Drawing.Color.Gainsboro;
            this.i.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.i.Location = new System.Drawing.Point(577, 490);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(40, 40);
            this.i.TabIndex = 16;
            this.i.Text = "I";
            this.i.UseVisualStyleBackColor = false;
            this.i.Click += new System.EventHandler(this.Button_Click);
            // 
            // u
            // 
            this.u.BackColor = System.Drawing.Color.Gainsboro;
            this.u.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.u.Location = new System.Drawing.Point(531, 490);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(40, 40);
            this.u.TabIndex = 15;
            this.u.Text = "U";
            this.u.UseVisualStyleBackColor = false;
            this.u.Click += new System.EventHandler(this.Button_Click);
            // 
            // d
            // 
            this.d.BackColor = System.Drawing.Color.Gainsboro;
            this.d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d.Location = new System.Drawing.Point(361, 536);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(40, 40);
            this.d.TabIndex = 20;
            this.d.Text = "D";
            this.d.UseVisualStyleBackColor = false;
            this.d.Click += new System.EventHandler(this.Button_Click);
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.Color.Gainsboro;
            this.s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.s.Location = new System.Drawing.Point(315, 536);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(40, 40);
            this.s.TabIndex = 19;
            this.s.Text = "S";
            this.s.UseVisualStyleBackColor = false;
            this.s.Click += new System.EventHandler(this.Button_Click);
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Gainsboro;
            this.a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a.Location = new System.Drawing.Point(269, 536);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(40, 40);
            this.a.TabIndex = 18;
            this.a.Text = "A";
            this.a.UseVisualStyleBackColor = false;
            this.a.Click += new System.EventHandler(this.Button_Click);
            // 
            // h
            // 
            this.h.BackColor = System.Drawing.Color.Gainsboro;
            this.h.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.h.Location = new System.Drawing.Point(499, 536);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(40, 40);
            this.h.TabIndex = 23;
            this.h.Text = "H";
            this.h.UseVisualStyleBackColor = false;
            this.h.Click += new System.EventHandler(this.Button_Click);
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.Color.Gainsboro;
            this.g.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g.Location = new System.Drawing.Point(453, 536);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(40, 40);
            this.g.TabIndex = 22;
            this.g.Text = "G";
            this.g.UseVisualStyleBackColor = false;
            this.g.Click += new System.EventHandler(this.Button_Click);
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.Gainsboro;
            this.f.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f.Location = new System.Drawing.Point(407, 536);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(40, 40);
            this.f.TabIndex = 21;
            this.f.Text = "F";
            this.f.UseVisualStyleBackColor = false;
            this.f.Click += new System.EventHandler(this.Button_Click);
            // 
            // k
            // 
            this.k.BackColor = System.Drawing.Color.Gainsboro;
            this.k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.k.Location = new System.Drawing.Point(591, 536);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(40, 40);
            this.k.TabIndex = 25;
            this.k.Text = "K";
            this.k.UseVisualStyleBackColor = false;
            this.k.Click += new System.EventHandler(this.Button_Click);
            // 
            // j
            // 
            this.j.BackColor = System.Drawing.Color.Gainsboro;
            this.j.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.j.Location = new System.Drawing.Point(545, 536);
            this.j.Name = "j";
            this.j.Size = new System.Drawing.Size(40, 40);
            this.j.TabIndex = 24;
            this.j.Text = "J";
            this.j.UseVisualStyleBackColor = false;
            this.j.Click += new System.EventHandler(this.Button_Click);
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.Gainsboro;
            this.p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.p.Location = new System.Drawing.Point(669, 490);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(40, 40);
            this.p.TabIndex = 27;
            this.p.Text = "P";
            this.p.UseVisualStyleBackColor = false;
            this.p.Click += new System.EventHandler(this.Button_Click);
            // 
            // l
            // 
            this.l.BackColor = System.Drawing.Color.Gainsboro;
            this.l.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l.Location = new System.Drawing.Point(637, 536);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(40, 40);
            this.l.TabIndex = 28;
            this.l.Text = "L";
            this.l.UseVisualStyleBackColor = false;
            this.l.Click += new System.EventHandler(this.Button_Click);
            // 
            // m
            // 
            this.m.BackColor = System.Drawing.Color.Gainsboro;
            this.m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m.Location = new System.Drawing.Point(555, 582);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(40, 40);
            this.m.TabIndex = 35;
            this.m.Text = "M";
            this.m.UseVisualStyleBackColor = false;
            this.m.Click += new System.EventHandler(this.Button_Click);
            // 
            // n
            // 
            this.n.BackColor = System.Drawing.Color.Gainsboro;
            this.n.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n.Location = new System.Drawing.Point(509, 582);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(40, 40);
            this.n.TabIndex = 34;
            this.n.Text = "N";
            this.n.UseVisualStyleBackColor = false;
            this.n.Click += new System.EventHandler(this.Button_Click);
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.Gainsboro;
            this.b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b.Location = new System.Drawing.Point(463, 582);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(40, 40);
            this.b.TabIndex = 33;
            this.b.Text = "B";
            this.b.UseVisualStyleBackColor = false;
            this.b.Click += new System.EventHandler(this.Button_Click);
            // 
            // v
            // 
            this.v.BackColor = System.Drawing.Color.Gainsboro;
            this.v.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v.Location = new System.Drawing.Point(417, 582);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(40, 40);
            this.v.TabIndex = 32;
            this.v.Text = "V";
            this.v.UseVisualStyleBackColor = false;
            this.v.Click += new System.EventHandler(this.Button_Click);
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.Gainsboro;
            this.c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c.Location = new System.Drawing.Point(371, 582);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(40, 40);
            this.c.TabIndex = 31;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = false;
            this.c.Click += new System.EventHandler(this.Button_Click);
            // 
            // x
            // 
            this.x.BackColor = System.Drawing.Color.Gainsboro;
            this.x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x.Location = new System.Drawing.Point(325, 582);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(40, 40);
            this.x.TabIndex = 30;
            this.x.Text = "X";
            this.x.UseVisualStyleBackColor = false;
            this.x.Click += new System.EventHandler(this.Button_Click);
            // 
            // z
            // 
            this.z.BackColor = System.Drawing.Color.Gainsboro;
            this.z.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.z.Location = new System.Drawing.Point(279, 582);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(40, 40);
            this.z.TabIndex = 29;
            this.z.Text = "Z";
            this.z.UseVisualStyleBackColor = false;
            this.z.Click += new System.EventHandler(this.Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.wordText);
            this.panel1.Location = new System.Drawing.Point(0, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 160);
            this.panel1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 84);
            this.label1.TabIndex = 37;
            this.label1.Text = "SCORE:";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(541, 74);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(70, 84);
            this.score.TabIndex = 38;
            this.score.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(799, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 41);
            this.button1.TabIndex = 39;
            this.button1.Text = "Change Topic";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicLabel.Location = new System.Drawing.Point(455, 251);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(0, 47);
            this.topicLabel.TabIndex = 40;
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(965, 657);
            this.Controls.Add(this.topicLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m);
            this.Controls.Add(this.n);
            this.Controls.Add(this.b);
            this.Controls.Add(this.v);
            this.Controls.Add(this.c);
            this.Controls.Add(this.x);
            this.Controls.Add(this.z);
            this.Controls.Add(this.l);
            this.Controls.Add(this.p);
            this.Controls.Add(this.k);
            this.Controls.Add(this.j);
            this.Controls.Add(this.h);
            this.Controls.Add(this.g);
            this.Controls.Add(this.f);
            this.Controls.Add(this.d);
            this.Controls.Add(this.s);
            this.Controls.Add(this.a);
            this.Controls.Add(this.o);
            this.Controls.Add(this.i);
            this.Controls.Add(this.u);
            this.Controls.Add(this.y);
            this.Controls.Add(this.t);
            this.Controls.Add(this.r);
            this.Controls.Add(this.e);
            this.Controls.Add(this.w);
            this.Controls.Add(this.q);
            this.Controls.Add(this.rightLeg);
            this.Controls.Add(this.leftLeg);
            this.Controls.Add(this.rightArm);
            this.Controls.Add(this.leftArm);
            this.Controls.Add(this.body);
            this.Controls.Add(this.head);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Hangman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rightLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox head;
        private System.Windows.Forms.PictureBox body;
        private System.Windows.Forms.PictureBox leftArm;
        private System.Windows.Forms.PictureBox rightArm;
        private System.Windows.Forms.PictureBox leftLeg;
        private System.Windows.Forms.PictureBox rightLeg;
        private System.Windows.Forms.Label wordText;
        private System.Windows.Forms.Button q;
        private System.Windows.Forms.Button w;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button y;
        private System.Windows.Forms.Button t;
        private System.Windows.Forms.Button r;
        private System.Windows.Forms.Button o;
        private System.Windows.Forms.Button i;
        private System.Windows.Forms.Button u;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Button h;
        private System.Windows.Forms.Button g;
        private System.Windows.Forms.Button f;
        private System.Windows.Forms.Button k;
        private System.Windows.Forms.Button j;
        private System.Windows.Forms.Button p;
        private System.Windows.Forms.Button l;
        private System.Windows.Forms.Button m;
        private System.Windows.Forms.Button n;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button x;
        private System.Windows.Forms.Button z;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label topicLabel;
    }
}

