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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new Label();
            this.lblPuerto = new Label();
            this.cmbPuertos = new ComboBox();
            this.btnConectar = new Button();
            this.btnEncender = new Button();
            this.btnApagar = new Button();
            this.lblEstado = new Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblStatusConexion = new Label();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            this.lblTitulo.Location = new Point(180, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(320, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Control de LED con Arduino";
            //
            // lblPuerto
            //
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Font = new Font("Segoe UI", 10F);
            this.lblPuerto.Location = new Point(40, 80);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new Size(100, 19);
            this.lblPuerto.TabIndex = 1;
            this.lblPuerto.Text = "Puerto COM:";
            //
            // cmbPuertos
            //
            this.cmbPuertos.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPuertos.Font = new Font("Segoe UI", 10F);
            this.cmbPuertos.Location = new Point(150, 77);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.Size = new Size(150, 27);
            this.cmbPuertos.TabIndex = 2;
            //
            // btnConectar
            //
            this.btnConectar.BackColor = Color.FromArgb(0, 122, 204);
            this.btnConectar.FlatStyle = FlatStyle.Flat;
            this.btnConectar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnConectar.ForeColor = Color.White;
            this.btnConectar.Location = new Point(320, 75);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new Size(120, 32);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new EventHandler(this.btnConectar_Click);
            //
            // btnEncender
            //
            this.btnEncender.BackColor = Color.FromArgb(40, 167, 69);
            this.btnEncender.Enabled = false;
            this.btnEncender.FlatStyle = FlatStyle.Flat;
            this.btnEncender.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.btnEncender.ForeColor = Color.White;
            this.btnEncender.Location = new Point(100, 160);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new Size(200, 80);
            this.btnEncender.TabIndex = 4;
            this.btnEncender.Text = "ENCENDER";
            this.btnEncender.UseVisualStyleBackColor = false;
            this.btnEncender.Click += new EventHandler(this.btnEncender_Click);
            //
            // btnApagar
            //
            this.btnApagar.BackColor = Color.FromArgb(220, 53, 69);
            this.btnApagar.Enabled = false;
            this.btnApagar.FlatStyle = FlatStyle.Flat;
            this.btnApagar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.btnApagar.ForeColor = Color.White;
            this.btnApagar.Location = new Point(340, 160);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new Size(200, 80);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new EventHandler(this.btnApagar_Click);
            //
            // lblEstado
            //
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblEstado.ForeColor = Color.Gray;
            this.lblEstado.Location = new Point(250, 270);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new Size(180, 21);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "LED: APAGADO";
            this.lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblStatusConexion
            //
            this.lblStatusConexion.AutoSize = true;
            this.lblStatusConexion.Font = new Font("Segoe UI", 9F);
            this.lblStatusConexion.ForeColor = Color.Red;
            this.lblStatusConexion.Location = new Point(460, 82);
            this.lblStatusConexion.Name = "lblStatusConexion";
            this.lblStatusConexion.Size = new Size(120, 15);
            this.lblStatusConexion.TabIndex = 7;
            this.lblStatusConexion.Text = "Desconectado";
            //
            // serialPort1
            //
            this.serialPort1.BaudRate = 9600;
            //
            // Form1
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.ClientSize = new Size(640, 330);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.cmbPuertos);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblStatusConexion);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Control LED Arduino";
            this.Load += new EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
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
