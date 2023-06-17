namespace Forms
{
    partial class FrmPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartida));
            groupBox1 = new GroupBox();
            label1 = new Label();
            listBoxPuntosUsuario = new ListBox();
            nombreUser = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            nombreOponente = new Label();
            listBoxPuntosOponente = new ListBox();
            labelGanador = new Label();
            btnRefrescar = new Button();
            label4 = new Label();
            button1 = new Button();
            btnCancelarPartida = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listBoxPuntosUsuario);
            groupBox1.Controls.Add(nombreUser);
            groupBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(25, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 285);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 68);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 2;
            label1.Text = "Cartas de puntos";
            // 
            // listBoxPuntosUsuario
            // 
            listBoxPuntosUsuario.BackColor = Color.WhiteSmoke;
            listBoxPuntosUsuario.FormattingEnabled = true;
            listBoxPuntosUsuario.ItemHeight = 21;
            listBoxPuntosUsuario.Location = new Point(44, 92);
            listBoxPuntosUsuario.Name = "listBoxPuntosUsuario";
            listBoxPuntosUsuario.Size = new Size(137, 172);
            listBoxPuntosUsuario.TabIndex = 1;
            // 
            // nombreUser
            // 
            nombreUser.AutoSize = true;
            nombreUser.Location = new Point(6, 34);
            nombreUser.Name = "nombreUser";
            nombreUser.Size = new Size(53, 21);
            nombreUser.TabIndex = 0;
            nombreUser.Text = "label1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(nombreOponente);
            groupBox2.Controls.Add(listBoxPuntosOponente);
            groupBox2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(323, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(268, 285);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Oponente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 68);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 4;
            label2.Text = "Cartas de puntos";
            // 
            // nombreOponente
            // 
            nombreOponente.AutoSize = true;
            nombreOponente.Location = new Point(6, 34);
            nombreOponente.Name = "nombreOponente";
            nombreOponente.Size = new Size(53, 21);
            nombreOponente.TabIndex = 0;
            nombreOponente.Text = "label2";
            // 
            // listBoxPuntosOponente
            // 
            listBoxPuntosOponente.BackColor = Color.WhiteSmoke;
            listBoxPuntosOponente.FormattingEnabled = true;
            listBoxPuntosOponente.ItemHeight = 21;
            listBoxPuntosOponente.Location = new Point(62, 92);
            listBoxPuntosOponente.Name = "listBoxPuntosOponente";
            listBoxPuntosOponente.Size = new Size(137, 172);
            listBoxPuntosOponente.TabIndex = 3;
            // 
            // labelGanador
            // 
            labelGanador.AutoSize = true;
            labelGanador.Font = new Font("Times New Roman", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelGanador.Location = new Point(25, 358);
            labelGanador.Name = "labelGanador";
            labelGanador.Size = new Size(343, 61);
            labelGanador.TabIndex = 2;
            labelGanador.Text = "El ganador es..";
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.Snow;
            btnRefrescar.BackgroundImage = (Image)resources.GetObject("btnRefrescar.BackgroundImage");
            btnRefrescar.BackgroundImageLayout = ImageLayout.Center;
            btnRefrescar.FlatAppearance.BorderColor = Color.Gray;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefrescar.Location = new Point(719, 245);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(35, 23);
            btnRefrescar.TabIndex = 3;
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(648, 248);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 4;
            label4.Text = "Refrescar";
            // 
            // button1
            // 
            button1.Location = new Point(648, 84);
            button1.Name = "button1";
            button1.Size = new Size(106, 26);
            button1.TabIndex = 5;
            button1.Text = "Cerrar Pestaña";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCancelarPartida
            // 
            btnCancelarPartida.Location = new Point(648, 166);
            btnCancelarPartida.Name = "btnCancelarPartida";
            btnCancelarPartida.Size = new Size(106, 26);
            btnCancelarPartida.TabIndex = 6;
            btnCancelarPartida.Text = "Cancelar partida";
            btnCancelarPartida.UseVisualStyleBackColor = true;
            btnCancelarPartida.Click += btnCancelarPartida_Click;
            // 
            // FrmPartida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelarPartida);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(btnRefrescar);
            Controls.Add(labelGanador);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPartida";
            Text = "FrmPartida";
            Load += FrmPartida_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBoxPuntosUsuario;
        private Label nombreUser;
        private GroupBox groupBox2;
        private Label nombreOponente;
        private Label label1;
        private Label label2;
        private ListBox listBoxPuntosOponente;
        private Label labelGanador;
        private Button btnRefrescar;
        private Label label4;
        private Button button1;
        private Button btnCancelarPartida;
    }
}