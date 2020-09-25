using System.Drawing;
using System.Windows.Forms;

namespace YPF.GUI
{
    partial class SesionIniciada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SesionIniciada));
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnMadrugada = new System.Windows.Forms.Button();
            this.btnTarde = new System.Windows.Forms.Button();
            this.btnNoche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(344, 257);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(149, 33);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "lblApellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(344, 187);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(149, 33);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "lblNombre";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.White;
            this.lblDNI.Location = new System.Drawing.Point(344, 125);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(95, 33);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "lblDNI";
            // 
            // btnMadrugada
            // 
            this.btnMadrugada.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMadrugada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMadrugada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMadrugada.Image = global::YPF.Properties.Resources.salida_del_sol64;
            this.btnMadrugada.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMadrugada.Location = new System.Drawing.Point(80, 417);
            this.btnMadrugada.Name = "btnMadrugada";
            this.btnMadrugada.Size = new System.Drawing.Size(213, 128);
            this.btnMadrugada.TabIndex = 3;
            this.btnMadrugada.Text = "          Mañana              (06:00 a 14:00)";
            this.btnMadrugada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMadrugada.UseMnemonic = false;
            this.btnMadrugada.UseVisualStyleBackColor = false;
            this.btnMadrugada.Click += new System.EventHandler(this.btnMadrugada_Click);
            // 
            // btnTarde
            // 
            this.btnTarde.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTarde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarde.Image = ((System.Drawing.Image)(resources.GetObject("btnTarde.Image")));
            this.btnTarde.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTarde.Location = new System.Drawing.Point(350, 417);
            this.btnTarde.Name = "btnTarde";
            this.btnTarde.Size = new System.Drawing.Size(213, 128);
            this.btnTarde.TabIndex = 4;
            this.btnTarde.Text = "          Tarde              (14:00 a 22:00)";
            this.btnTarde.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTarde.UseVisualStyleBackColor = false;
            this.btnTarde.Click += new System.EventHandler(this.btnTarde_Click);
            // 
            // btnNoche
            // 
            this.btnNoche.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNoche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoche.Image = ((System.Drawing.Image)(resources.GetObject("btnNoche.Image")));
            this.btnNoche.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNoche.Location = new System.Drawing.Point(608, 417);
            this.btnNoche.Name = "btnNoche";
            this.btnNoche.Size = new System.Drawing.Size(213, 128);
            this.btnNoche.TabIndex = 5;
            this.btnNoche.Text = "         Noche              (22:00 a 06:00)";
            this.btnNoche.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNoche.UseVisualStyleBackColor = false;
            this.btnNoche.Click += new System.EventHandler(this.btnNoche_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero de DNI : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(147, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(451, 55);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seleccione el turno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(621, 73);
            this.label8.TabIndex = 13;
            this.label8.Text = "Datos del empleado.";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtras.Image = global::YPF.Properties.Resources.return64;
            this.btnAtras.Location = new System.Drawing.Point(24, 640);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(111, 75);
            this.btnAtras.TabIndex = 14;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // SesionIniciada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YPF.Properties.Resources.YPF;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 727);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNoche);
            this.Controls.Add(this.btnTarde);
            this.Controls.Add(this.btnMadrugada);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SesionIniciada";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SesionIniciada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnMadrugada;
        private System.Windows.Forms.Button btnTarde;
        private System.Windows.Forms.Button btnNoche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Label label8;
        private Button btnAtras;
    }
}