namespace Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            txtContra = new TextBox();
            txtUsuario = new TextBox();
            button2 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtContra);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(59, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 205);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acceder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 102);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 46);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(166, 144);
            button1.Name = "button1";
            button1.Size = new Size(65, 23);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(117, 101);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(114, 22);
            txtContra.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(117, 46);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(114, 22);
            txtUsuario.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(225, 268);
            button2.Name = "button2";
            button2.Size = new Size(103, 23);
            button2.TabIndex = 1;
            button2.Text = "Registrarse";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(110, 22);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 2;
            label3.Text = "La escoba de 15";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(261, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 33);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(395, 343);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtContra;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
        private Button button2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}