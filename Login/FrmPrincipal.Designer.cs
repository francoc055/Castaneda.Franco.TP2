namespace Forms
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            groupBox1 = new GroupBox();
            button1 = new Button();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            btnCrearPartida = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbJugadorOponente = new ComboBox();
            cbJugadorUser = new ComboBox();
            groupBox3 = new GroupBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(2, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Partidas";
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(284, 22);
            button1.Name = "button1";
            button1.Size = new Size(93, 27);
            button1.TabIndex = 1;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.WhiteSmoke;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(17, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(243, 99);
            listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.BackgroundImageLayout = ImageLayout.Center;
            groupBox2.Controls.Add(btnCrearPartida);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cbJugadorOponente);
            groupBox2.Controls.Add(cbJugadorUser);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(241, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(342, 188);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Crear Partida";
            // 
            // btnCrearPartida
            // 
            btnCrearPartida.BackColor = Color.WhiteSmoke;
            btnCrearPartida.BackgroundImageLayout = ImageLayout.Center;
            btnCrearPartida.FlatAppearance.BorderColor = Color.Black;
            btnCrearPartida.FlatStyle = FlatStyle.Flat;
            btnCrearPartida.Location = new Point(121, 142);
            btnCrearPartida.Name = "btnCrearPartida";
            btnCrearPartida.Size = new Size(107, 29);
            btnCrearPartida.TabIndex = 5;
            btnCrearPartida.Text = "Crear";
            btnCrearPartida.UseVisualStyleBackColor = false;
            btnCrearPartida.Click += btnCrearPartida_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 39);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 4;
            label3.Text = "Oponente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 39);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 3;
            label2.Text = "Tu Jugador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(155, 70);
            label1.Name = "label1";
            label1.Size = new Size(28, 22);
            label1.TabIndex = 2;
            label1.Text = "vs";
            // 
            // cbJugadorOponente
            // 
            cbJugadorOponente.FormattingEnabled = true;
            cbJugadorOponente.Location = new Point(199, 66);
            cbJugadorOponente.Name = "cbJugadorOponente";
            cbJugadorOponente.Size = new Size(121, 27);
            cbJugadorOponente.TabIndex = 1;
            // 
            // cbJugadorUser
            // 
            cbJugadorUser.FormattingEnabled = true;
            cbJugadorUser.Location = new Point(17, 65);
            cbJugadorUser.Name = "cbJugadorUser";
            cbJugadorUser.Size = new Size(121, 27);
            cbJugadorUser.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(410, 48);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(402, 143);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Historial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(296, 9);
            label4.Name = "label4";
            label4.Size = new Size(203, 32);
            label4.TabIndex = 3;
            label4.Text = "La escoba de 15";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(505, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 30);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(818, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private Button btnCrearPartida;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbJugadorOponente;
        private ComboBox cbJugadorUser;
        private GroupBox groupBox3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}