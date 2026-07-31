namespace EncenderLedArduino
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Text.ASCIIEncoding asciiEncodingSealed1 = new System.Text.ASCIIEncoding();
            System.Text.DecoderReplacementFallback decoderReplacementFallback1 = new System.Text.DecoderReplacementFallback();
            System.Text.EncoderReplacementFallback encoderReplacementFallback1 = new System.Text.EncoderReplacementFallback();
            lblTitulo = new Label();
            lblPuerto = new Label();
            cmbPuertos = new ComboBox();
            btnConectar = new Button();
            btnEncender = new Button();
            btnApagar = new Button();
            lblEstado = new Label();
            serialPort1 = new System.IO.Ports.SerialPort(components);
            lblStatusConexion = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(206, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(409, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Control de LED con Arduino";
            // 
            // lblPuerto
            // 
            lblPuerto.AutoSize = true;
            lblPuerto.Font = new Font("Segoe UI", 10F);
            lblPuerto.Location = new Point(46, 107);
            lblPuerto.Name = "lblPuerto";
            lblPuerto.Size = new Size(109, 23);
            lblPuerto.TabIndex = 1;
            lblPuerto.Text = "Puerto COM:";
            // 
            // cmbPuertos
            // 
            cmbPuertos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPuertos.Font = new Font("Segoe UI", 10F);
            cmbPuertos.Location = new Point(171, 103);
            cmbPuertos.Margin = new Padding(3, 4, 3, 4);
            cmbPuertos.Name = "cmbPuertos";
            cmbPuertos.Size = new Size(171, 31);
            cmbPuertos.TabIndex = 2;
            // 
            // btnConectar
            // 
            btnConectar.BackColor = Color.FromArgb(0, 122, 204);
            btnConectar.FlatStyle = FlatStyle.Flat;
            btnConectar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConectar.ForeColor = Color.White;
            btnConectar.Location = new Point(366, 100);
            btnConectar.Margin = new Padding(3, 4, 3, 4);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(137, 43);
            btnConectar.TabIndex = 3;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnEncender
            // 
            btnEncender.BackColor = Color.FromArgb(40, 167, 69);
            btnEncender.Enabled = false;
            btnEncender.FlatStyle = FlatStyle.Flat;
            btnEncender.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnEncender.ForeColor = Color.White;
            btnEncender.Location = new Point(114, 213);
            btnEncender.Margin = new Padding(3, 4, 3, 4);
            btnEncender.Name = "btnEncender";
            btnEncender.Size = new Size(229, 107);
            btnEncender.TabIndex = 4;
            btnEncender.Text = "ENCENDER";
            btnEncender.UseVisualStyleBackColor = false;
            btnEncender.Click += btnEncender_Click;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.FromArgb(220, 53, 69);
            btnApagar.Enabled = false;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnApagar.ForeColor = Color.White;
            btnApagar.Location = new Point(389, 213);
            btnApagar.Margin = new Padding(3, 4, 3, 4);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(229, 107);
            btnApagar.TabIndex = 5;
            btnApagar.Text = "APAGAR";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEstado.ForeColor = Color.Gray;
            lblEstado.Location = new Point(286, 360);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(156, 28);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "LED: APAGADO";
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // serialPort1
            // 
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.DiscardNull = false;
            serialPort1.DtrEnable = false;
            asciiEncodingSealed1.DecoderFallback = decoderReplacementFallback1;
            asciiEncodingSealed1.EncoderFallback = encoderReplacementFallback1;
            serialPort1.Encoding = asciiEncodingSealed1;
            serialPort1.Handshake = System.IO.Ports.Handshake.None;
            serialPort1.NewLine = "\n";
            serialPort1.Parity = System.IO.Ports.Parity.None;
            serialPort1.ParityReplace = 63;
            serialPort1.PortName = "COM1";
            serialPort1.ReadBufferSize = 4096;
            serialPort1.ReadTimeout = -1;
            serialPort1.ReceivedBytesThreshold = 1;
            serialPort1.RtsEnable = false;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            serialPort1.WriteBufferSize = 2048;
            serialPort1.WriteTimeout = -1;
            // 
            // lblStatusConexion
            // 
            lblStatusConexion.AutoSize = true;
            lblStatusConexion.Font = new Font("Segoe UI", 9F);
            lblStatusConexion.ForeColor = Color.Red;
            lblStatusConexion.Location = new Point(526, 109);
            lblStatusConexion.Name = "lblStatusConexion";
            lblStatusConexion.Size = new Size(104, 20);
            lblStatusConexion.TabIndex = 7;
            lblStatusConexion.Text = "Desconectado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(731, 440);
            Controls.Add(lblTitulo);
            Controls.Add(lblPuerto);
            Controls.Add(cmbPuertos);
            Controls.Add(btnConectar);
            Controls.Add(btnEncender);
            Controls.Add(btnApagar);
            Controls.Add(lblEstado);
            Controls.Add(lblStatusConexion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "<z";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblPuerto;
        private ComboBox cmbPuertos;
        private Button btnConectar;
        private Button btnEncender;
        private Button btnApagar;
        private Label lblEstado;
        private System.IO.Ports.SerialPort serialPort1;
        private Label lblStatusConexion;
    }
}
