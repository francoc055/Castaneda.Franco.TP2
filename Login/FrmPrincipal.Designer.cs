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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            label5 = new Label();
            dataGridViewPartidas = new DataGridView();
            groupBox2 = new GroupBox();
            btnCrearPartida = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbJugadorOponente = new ComboBox();
            cbJugadorUser = new ComboBox();
            groupBox3 = new GroupBox();
            dataGridViewHistorial = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnGuardarPartida = new Button();
            Id = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartidas).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dataGridViewPartidas);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(2, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 196);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Partidas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 22);
            label5.Name = "label5";
            label5.Size = new Size(331, 19);
            label5.TabIndex = 3;
            label5.Text = "Hacer click sobre la partida para obtener informacion";
            // 
            // dataGridViewPartidas
            // 
            dataGridViewPartidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPartidas.BackgroundColor = Color.WhiteSmoke;
            dataGridViewPartidas.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewPartidas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPartidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartidas.Columns.AddRange(new DataGridViewColumn[] { Id, Column6, Estado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPartidas.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPartidas.EnableHeadersVisualStyles = false;
            dataGridViewPartidas.Location = new Point(10, 43);
            dataGridViewPartidas.Name = "dataGridViewPartidas";
            dataGridViewPartidas.RowHeadersVisible = false;
            dataGridViewPartidas.RowTemplate.Height = 25;
            dataGridViewPartidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPartidas.Size = new Size(386, 147);
            dataGridViewPartidas.TabIndex = 2;
            dataGridViewPartidas.CellClick += dataGridViewPartidas_CellClick;
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
            groupBox2.Location = new Point(19, 250);
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
            groupBox3.Controls.Add(dataGridViewHistorial);
            groupBox3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(410, 48);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(402, 290);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Historial";
            // 
            // dataGridViewHistorial
            // 
            dataGridViewHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistorial.BackgroundColor = Color.WhiteSmoke;
            dataGridViewHistorial.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewHistorial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gray;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistorial.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewHistorial.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewHistorial.Dock = DockStyle.Fill;
            dataGridViewHistorial.EnableHeadersVisualStyles = false;
            dataGridViewHistorial.Location = new Point(3, 22);
            dataGridViewHistorial.Name = "dataGridViewHistorial";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewHistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewHistorial.RowHeadersVisible = false;
            dataGridViewHistorial.RowTemplate.Height = 25;
            dataGridViewHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHistorial.Size = new Size(396, 265);
            dataGridViewHistorial.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre usuario";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Nombre oponente";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Ganador";
            Column4.Name = "Column4";
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
            // btnGuardarPartida
            // 
            btnGuardarPartida.Location = new Point(544, 360);
            btnGuardarPartida.Name = "btnGuardarPartida";
            btnGuardarPartida.Size = new Size(128, 23);
            btnGuardarPartida.TabIndex = 5;
            btnGuardarPartida.Text = "Guardar partidas";
            btnGuardarPartida.UseVisualStyleBackColor = true;
            btnGuardarPartida.Click += btnGuardarPartida_Click;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Column6
            // 
            Column6.HeaderText = "Nombre";
            Column6.Name = "Column6";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(818, 450);
            Controls.Add(btnGuardarPartida);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            FormClosed += FrmPrincipal_FormClosed;
            Load += FrmPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartidas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
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
        private DataGridView dataGridViewHistorial;
        private Button btnGuardarPartida;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridView dataGridViewPartidas;
        private Label label5;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Estado;
    }
}