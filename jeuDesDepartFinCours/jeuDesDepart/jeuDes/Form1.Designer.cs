namespace jeuDes
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
            lblDe1 = new Label();
            lblDe2 = new Label();
            lblDe3 = new Label();
            lblDe4 = new Label();
            lblDe5 = new Label();
            btnBrasser = new Button();
            btnJoueurSuivant = new Button();
            lblJoueur1 = new Label();
            lblJoueur2 = new Label();
            lblJoueur3 = new Label();
            lblPointsJ1 = new Label();
            lblPointsJ2 = new Label();
            lblPointsJ3 = new Label();
            SuspendLayout();
            // 
            // lblDe1
            // 
            lblDe1.BorderStyle = BorderStyle.FixedSingle;
            lblDe1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblDe1.Location = new Point(10, 7);
            lblDe1.Name = "lblDe1";
            lblDe1.Size = new Size(73, 60);
            lblDe1.TabIndex = 0;
            lblDe1.Text = "1";
            lblDe1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDe2
            // 
            lblDe2.BorderStyle = BorderStyle.FixedSingle;
            lblDe2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblDe2.Location = new Point(89, 7);
            lblDe2.Name = "lblDe2";
            lblDe2.Size = new Size(73, 60);
            lblDe2.TabIndex = 1;
            lblDe2.Text = "1";
            lblDe2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDe3
            // 
            lblDe3.BorderStyle = BorderStyle.FixedSingle;
            lblDe3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblDe3.Location = new Point(168, 7);
            lblDe3.Name = "lblDe3";
            lblDe3.Size = new Size(78, 60);
            lblDe3.TabIndex = 2;
            lblDe3.Text = "1";
            lblDe3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDe4
            // 
            lblDe4.BorderStyle = BorderStyle.FixedSingle;
            lblDe4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblDe4.Location = new Point(252, 7);
            lblDe4.Name = "lblDe4";
            lblDe4.Size = new Size(80, 60);
            lblDe4.TabIndex = 3;
            lblDe4.Text = "1";
            lblDe4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDe5
            // 
            lblDe5.BorderStyle = BorderStyle.FixedSingle;
            lblDe5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblDe5.Location = new Point(338, 7);
            lblDe5.Name = "lblDe5";
            lblDe5.Size = new Size(88, 60);
            lblDe5.TabIndex = 4;
            lblDe5.Text = "1";
            lblDe5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBrasser
            // 
            btnBrasser.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnBrasser.Location = new Point(10, 69);
            btnBrasser.Margin = new Padding(2, 2, 2, 2);
            btnBrasser.Name = "btnBrasser";
            btnBrasser.Size = new Size(387, 48);
            btnBrasser.TabIndex = 6;
            btnBrasser.Text = "Brasser";
            btnBrasser.UseVisualStyleBackColor = true;
            btnBrasser.Click += btnBrasser_Click;
            // 
            // btnJoueurSuivant
            // 
            btnJoueurSuivant.Enabled = false;
            btnJoueurSuivant.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnJoueurSuivant.Location = new Point(10, 122);
            btnJoueurSuivant.Margin = new Padding(2, 2, 2, 2);
            btnJoueurSuivant.Name = "btnJoueurSuivant";
            btnJoueurSuivant.Size = new Size(387, 48);
            btnJoueurSuivant.TabIndex = 7;
            btnJoueurSuivant.Text = "Joueur suivant";
            btnJoueurSuivant.UseVisualStyleBackColor = true;
            btnJoueurSuivant.Click += btnJoueurSuivant_Click;
            // 
            // lblJoueur1
            // 
            lblJoueur1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblJoueur1.Location = new Point(10, 172);
            lblJoueur1.Margin = new Padding(2, 0, 2, 0);
            lblJoueur1.Name = "lblJoueur1";
            lblJoueur1.Size = new Size(276, 52);
            lblJoueur1.TabIndex = 8;
            lblJoueur1.Text = "Joueur 1 :";
            lblJoueur1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblJoueur2
            // 
            lblJoueur2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblJoueur2.Location = new Point(10, 224);
            lblJoueur2.Margin = new Padding(2, 0, 2, 0);
            lblJoueur2.Name = "lblJoueur2";
            lblJoueur2.Size = new Size(276, 52);
            lblJoueur2.TabIndex = 9;
            lblJoueur2.Text = "Joueur 2 :";
            lblJoueur2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblJoueur3
            // 
            lblJoueur3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblJoueur3.Location = new Point(10, 276);
            lblJoueur3.Margin = new Padding(2, 0, 2, 0);
            lblJoueur3.Name = "lblJoueur3";
            lblJoueur3.Size = new Size(276, 52);
            lblJoueur3.TabIndex = 10;
            lblJoueur3.Text = "Joueur 3 :";
            lblJoueur3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPointsJ1
            // 
            lblPointsJ1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblPointsJ1.Location = new Point(291, 172);
            lblPointsJ1.Margin = new Padding(2, 0, 2, 0);
            lblPointsJ1.Name = "lblPointsJ1";
            lblPointsJ1.Size = new Size(106, 52);
            lblPointsJ1.TabIndex = 11;
            lblPointsJ1.Text = "0";
            lblPointsJ1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPointsJ2
            // 
            lblPointsJ2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblPointsJ2.Location = new Point(291, 224);
            lblPointsJ2.Margin = new Padding(2, 0, 2, 0);
            lblPointsJ2.Name = "lblPointsJ2";
            lblPointsJ2.Size = new Size(106, 52);
            lblPointsJ2.TabIndex = 12;
            lblPointsJ2.Text = "0";
            lblPointsJ2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPointsJ3
            // 
            lblPointsJ3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblPointsJ3.Location = new Point(291, 276);
            lblPointsJ3.Margin = new Padding(2, 0, 2, 0);
            lblPointsJ3.Name = "lblPointsJ3";
            lblPointsJ3.Size = new Size(106, 52);
            lblPointsJ3.TabIndex = 13;
            lblPointsJ3.Text = "0";
            lblPointsJ3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 342);
            Controls.Add(lblPointsJ3);
            Controls.Add(lblPointsJ2);
            Controls.Add(lblPointsJ1);
            Controls.Add(lblJoueur3);
            Controls.Add(lblJoueur2);
            Controls.Add(lblJoueur1);
            Controls.Add(btnJoueurSuivant);
            Controls.Add(btnBrasser);
            Controls.Add(lblDe5);
            Controls.Add(lblDe4);
            Controls.Add(lblDe3);
            Controls.Add(lblDe2);
            Controls.Add(lblDe1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblDe1;
        private Label lblDe2;
        private Label lblDe3;
        private Label lblDe4;
        private Label lblDe5;
        private Button btnBrasser;
        private Button btnJoueurSuivant;
        private Label lblJoueur1;
        private Label lblJoueur2;
        private Label lblJoueur3;
        private Label lblPointsJ1;
        private Label lblPointsJ2;
        private Label lblPointsJ3;
    }
}