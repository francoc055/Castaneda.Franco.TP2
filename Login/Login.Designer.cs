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
            labelAdvertenciaLogin = new Label();
            btnRellenar = new Button();
            label2 = new Label();
            label1 = new Label();
            btnIngresar = new Button();
            txtContra = new TextBox();
            txtUsuario = new TextBox();
            btnRegistrarse = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            labelCamposVacios = new Label();
            labelAdvertenciaNombreUser = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtContraR = new TextBox();
            txtNombreUserR = new TextBox();
            txtNombreR = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelAdvertenciaLogin);
            groupBox1.Controls.Add(btnRellenar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnIngresar);
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
            // labelAdvertenciaLogin
            // 
            labelAdvertenciaLogin.AutoSize = true;
            labelAdvertenciaLogin.BackColor = Color.Salmon;
            labelAdvertenciaLogin.ForeColor = Color.Red;
            labelAdvertenciaLogin.Location = new Point(6, 133);
            labelAdvertenciaLogin.Name = "labelAdvertenciaLogin";
            labelAdvertenciaLogin.Size = new Size(32, 15);
            labelAdvertenciaLogin.TabIndex = 6;
            labelAdvertenciaLogin.Text = "label";
            labelAdvertenciaLogin.Visible = false;
            // 
            // btnRellenar
            // 
            btnRellenar.Location = new Point(68, 161);
            btnRellenar.Name = "btnRellenar";
            btnRellenar.Size = new Size(75, 23);
            btnRellenar.TabIndex = 5;
            btnRellenar.Text = "Rellenar";
            btnRellenar.UseVisualStyleBackColor = true;
            btnRellenar.Click += btnRellenar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 102);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 46);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // btnIngresar
            // 
            btnIngresar.BackgroundImage = (Image)resources.GetObject("btnIngresar.BackgroundImage");
            btnIngresar.BackgroundImageLayout = ImageLayout.Center;
            btnIngresar.Location = new Point(166, 161);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(65, 23);
            btnIngresar.TabIndex = 2;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
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
            // btnRegistrarse
            // 
            btnRegistrarse.BackgroundImage = (Image)resources.GetObject("btnRegistrarse.BackgroundImage");
            btnRegistrarse.BackgroundImageLayout = ImageLayout.Center;
            btnRegistrarse.Location = new Point(208, 161);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(39, 26);
            btnRegistrarse.TabIndex = 1;
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(245, 18);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 2;
            label3.Text = "La escoba de 15";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(396, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 33);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelCamposVacios);
            groupBox2.Controls.Add(labelAdvertenciaNombreUser);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtContraR);
            groupBox2.Controls.Add(txtNombreUserR);
            groupBox2.Controls.Add(txtNombreR);
            groupBox2.Controls.Add(btnRegistrarse);
            groupBox2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(373, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(269, 205);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registrarse";
            // 
            // labelCamposVacios
            // 
            labelCamposVacios.AutoSize = true;
            labelCamposVacios.ForeColor = Color.Red;
            labelCamposVacios.Location = new Point(6, 18);
            labelCamposVacios.Name = "labelCamposVacios";
            labelCamposVacios.Size = new Size(38, 15);
            labelCamposVacios.TabIndex = 9;
            labelCamposVacios.Text = "label7";
            labelCamposVacios.Visible = false;
            // 
            // labelAdvertenciaNombreUser
            // 
            labelAdvertenciaNombreUser.AutoSize = true;
            labelAdvertenciaNombreUser.ForeColor = Color.Red;
            labelAdvertenciaNombreUser.Location = new Point(6, 108);
            labelAdvertenciaNombreUser.Name = "labelAdvertenciaNombreUser";
            labelAdvertenciaNombreUser.Size = new Size(38, 15);
            labelAdvertenciaNombreUser.TabIndex = 8;
            labelAdvertenciaNombreUser.Text = "label7";
            labelAdvertenciaNombreUser.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 136);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 7;
            label6.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 90);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 6;
            label5.Text = "Nombre de usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 47);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 5;
            label4.Text = "Nombre";
            // 
            // txtContraR
            // 
            txtContraR.Location = new Point(133, 133);
            txtContraR.Name = "txtContraR";
            txtContraR.Size = new Size(114, 22);
            txtContraR.TabIndex = 4;
            // 
            // txtNombreUserR
            // 
            txtNombreUserR.Location = new Point(133, 87);
            txtNombreUserR.Name = "txtNombreUserR";
            txtNombreUserR.Size = new Size(114, 22);
            txtNombreUserR.TabIndex = 3;
            // 
            // txtNombreR
            // 
            txtNombreR.Location = new Point(133, 44);
            txtNombreR.Name = "txtNombreR";
            txtNombreR.Size = new Size(114, 22);
            txtNombreR.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(677, 343);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnIngresar;
        private TextBox txtContra;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
        private Button btnRegistrarse;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnRellenar;
        private GroupBox groupBox2;
        private Label labelAdvertenciaNombreUser;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtContraR;
        private TextBox txtNombreUserR;
        private TextBox txtNombreR;
        private Label labelAdvertenciaLogin;
        private Label labelCamposVacios;
    }
}