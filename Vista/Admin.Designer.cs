namespace Vista
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnTarifas = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Navy;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuarios.Location = new System.Drawing.Point(33, 73);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(189, 44);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnTarifas
            // 
            this.btnTarifas.BackColor = System.Drawing.Color.Navy;
            this.btnTarifas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTarifas.FlatAppearance.BorderSize = 0;
            this.btnTarifas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarifas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarifas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTarifas.Location = new System.Drawing.Point(262, 73);
            this.btnTarifas.Name = "btnTarifas";
            this.btnTarifas.Size = new System.Drawing.Size(189, 44);
            this.btnTarifas.TabIndex = 4;
            this.btnTarifas.Text = "Tarifas";
            this.btnTarifas.UseVisualStyleBackColor = false;
            this.btnTarifas.Click += new System.EventHandler(this.btnTarifas_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.Navy;
            this.btnTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicket.FlatAppearance.BorderSize = 0;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTicket.Location = new System.Drawing.Point(147, 143);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(189, 44);
            this.btnTicket.TabIndex = 5;
            this.btnTicket.Text = "Nuevo Ticket";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 208);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnTarifas);
            this.Controls.Add(this.btnUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnTarifas;
        private System.Windows.Forms.Button btnTicket;
    }
}