namespace ElFormulario
{
    partial class fmElFormulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmElFormulario));
            this.labeLBienvenida = new System.Windows.Forms.Label();
            this.laMover = new System.Windows.Forms.Label();
            this.laTamanyo = new System.Windows.Forms.Label();
            this.btArriba = new System.Windows.Forms.Button();
            this.btIzquierda = new System.Windows.Forms.Button();
            this.btAbajo = new System.Windows.Forms.Button();
            this.btDerecha = new System.Windows.Forms.Button();
            this.btBotones = new System.Windows.Forms.Panel();
            this.btAcerca = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btPanel = new System.Windows.Forms.Button();
            this.btControles = new System.Windows.Forms.Button();
            this.btDetrás = new System.Windows.Forms.Button();
            this.btDelante = new System.Windows.Forms.Button();
            this.btDisminuye = new System.Windows.Forms.Button();
            this.btAumenta = new System.Windows.Forms.Button();
            this.btVisible = new System.Windows.Forms.Button();
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btTres = new System.Windows.Forms.Button();
            this.btDos = new System.Windows.Forms.Button();
            this.btUno = new System.Windows.Forms.Button();
            this.btBotones.SuspendLayout();
            this.gbBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeLBienvenida
            // 
            this.labeLBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labeLBienvenida.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeLBienvenida.ForeColor = System.Drawing.Color.Blue;
            this.labeLBienvenida.Image = global::ElFormulario.Properties.Resources.AYUDA;
            this.labeLBienvenida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labeLBienvenida.Location = new System.Drawing.Point(0, 0);
            this.labeLBienvenida.Name = "labeLBienvenida";
            this.labeLBienvenida.Size = new System.Drawing.Size(1043, 16);
            this.labeLBienvenida.TabIndex = 0;
            this.labeLBienvenida.Text = "Bienvenido al sistema";
            this.labeLBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labeLBienvenida.Click += new System.EventHandler(this.fmElFormulario_Click);
            // 
            // laMover
            // 
            this.laMover.AutoSize = true;
            this.laMover.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.laMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laMover.ForeColor = System.Drawing.SystemColors.Info;
            this.laMover.Location = new System.Drawing.Point(488, 109);
            this.laMover.Name = "laMover";
            this.laMover.Size = new System.Drawing.Size(90, 32);
            this.laMover.TabIndex = 1;
            this.laMover.Text = "XXXX";
            // 
            // laTamanyo
            // 
            this.laTamanyo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.laTamanyo.AutoSize = true;
            this.laTamanyo.ForeColor = System.Drawing.Color.Red;
            this.laTamanyo.Location = new System.Drawing.Point(37, 348);
            this.laTamanyo.Name = "laTamanyo";
            this.laTamanyo.Size = new System.Drawing.Size(21, 16);
            this.laTamanyo.TabIndex = 2;
            this.laTamanyo.Text = "16";
            // 
            // btArriba
            // 
            this.btArriba.Location = new System.Drawing.Point(149, 119);
            this.btArriba.Name = "btArriba";
            this.btArriba.Size = new System.Drawing.Size(75, 23);
            this.btArriba.TabIndex = 3;
            this.btArriba.Text = "Arriba";
            this.btArriba.UseVisualStyleBackColor = true;
            this.btArriba.Click += new System.EventHandler(this.btArriba_Click);
            // 
            // btIzquierda
            // 
            this.btIzquierda.Location = new System.Drawing.Point(77, 167);
            this.btIzquierda.Name = "btIzquierda";
            this.btIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btIzquierda.TabIndex = 2;
            this.btIzquierda.Text = "Izquierda";
            this.btIzquierda.UseVisualStyleBackColor = true;
            this.btIzquierda.Click += new System.EventHandler(this.btIzquierda_Click);
            // 
            // btAbajo
            // 
            this.btAbajo.Location = new System.Drawing.Point(149, 215);
            this.btAbajo.Name = "btAbajo";
            this.btAbajo.Size = new System.Drawing.Size(75, 23);
            this.btAbajo.TabIndex = 3;
            this.btAbajo.Text = "Abajo";
            this.btAbajo.UseVisualStyleBackColor = true;
            this.btAbajo.Click += new System.EventHandler(this.btAbajo_Click);
            // 
            // btDerecha
            // 
            this.btDerecha.Location = new System.Drawing.Point(222, 167);
            this.btDerecha.Name = "btDerecha";
            this.btDerecha.Size = new System.Drawing.Size(75, 23);
            this.btDerecha.TabIndex = 4;
            this.btDerecha.Text = "Derecha";
            this.btDerecha.UseVisualStyleBackColor = true;
            this.btDerecha.Click += new System.EventHandler(this.btDerecha_Click);
            // 
            // btBotones
            // 
            this.btBotones.Controls.Add(this.btAcerca);
            this.btBotones.Controls.Add(this.btSalir);
            this.btBotones.Controls.Add(this.btPanel);
            this.btBotones.Controls.Add(this.btControles);
            this.btBotones.Controls.Add(this.btDetrás);
            this.btBotones.Controls.Add(this.btDelante);
            this.btBotones.Controls.Add(this.btDisminuye);
            this.btBotones.Controls.Add(this.btAumenta);
            this.btBotones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btBotones.Location = new System.Drawing.Point(0, 390);
            this.btBotones.Name = "btBotones";
            this.btBotones.Size = new System.Drawing.Size(1043, 90);
            this.btBotones.TabIndex = 7;
            // 
            // btAcerca
            // 
            this.btAcerca.Location = new System.Drawing.Point(903, 37);
            this.btAcerca.Name = "btAcerca";
            this.btAcerca.Size = new System.Drawing.Size(100, 34);
            this.btAcerca.TabIndex = 7;
            this.btAcerca.Text = "Acerca de";
            this.btAcerca.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(797, 37);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(87, 34);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // btPanel
            // 
            this.btPanel.Location = new System.Drawing.Point(664, 37);
            this.btPanel.Name = "btPanel";
            this.btPanel.Size = new System.Drawing.Size(118, 34);
            this.btPanel.TabIndex = 5;
            this.btPanel.Text = "Controles Panel";
            this.btPanel.UseVisualStyleBackColor = true;
            // 
            // btControles
            // 
            this.btControles.Location = new System.Drawing.Point(517, 37);
            this.btControles.Name = "btControles";
            this.btControles.Size = new System.Drawing.Size(130, 34);
            this.btControles.TabIndex = 4;
            this.btControles.Text = "Controles Form";
            this.btControles.UseVisualStyleBackColor = true;
            // 
            // btDetrás
            // 
            this.btDetrás.Location = new System.Drawing.Point(401, 37);
            this.btDetrás.Name = "btDetrás";
            this.btDetrás.Size = new System.Drawing.Size(100, 34);
            this.btDetrás.TabIndex = 3;
            this.btDetrás.Text = "Detrás";
            this.btDetrás.UseVisualStyleBackColor = true;
            this.btDetrás.Click += new System.EventHandler(this.btDetrás_Click);
            // 
            // btDelante
            // 
            this.btDelante.Location = new System.Drawing.Point(281, 37);
            this.btDelante.Name = "btDelante";
            this.btDelante.Size = new System.Drawing.Size(102, 34);
            this.btDelante.TabIndex = 2;
            this.btDelante.Text = "Delante";
            this.btDelante.UseVisualStyleBackColor = true;
            this.btDelante.Click += new System.EventHandler(this.btDelante_Click);
            // 
            // btDisminuye
            // 
            this.btDisminuye.Location = new System.Drawing.Point(175, 37);
            this.btDisminuye.Name = "btDisminuye";
            this.btDisminuye.Size = new System.Drawing.Size(91, 34);
            this.btDisminuye.TabIndex = 1;
            this.btDisminuye.Text = "Disminuye";
            this.btDisminuye.UseVisualStyleBackColor = true;
            this.btDisminuye.Click += new System.EventHandler(this.btDisminuye_Click);
            // 
            // btAumenta
            // 
            this.btAumenta.Location = new System.Drawing.Point(54, 37);
            this.btAumenta.Name = "btAumenta";
            this.btAumenta.Size = new System.Drawing.Size(98, 34);
            this.btAumenta.TabIndex = 0;
            this.btAumenta.Text = "Aumenta";
            this.btAumenta.UseVisualStyleBackColor = true;
            this.btAumenta.Click += new System.EventHandler(this.btAumenta_Click);
            // 
            // btVisible
            // 
            this.btVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btVisible.Location = new System.Drawing.Point(851, 330);
            this.btVisible.Name = "btVisible";
            this.btVisible.Size = new System.Drawing.Size(131, 34);
            this.btVisible.TabIndex = 8;
            this.btVisible.Text = "No visible";
            this.btVisible.UseVisualStyleBackColor = true;
            this.btVisible.Click += new System.EventHandler(this.btVisible_Click);
            // 
            // gbBotones
            // 
            this.gbBotones.Controls.Add(this.btTres);
            this.gbBotones.Controls.Add(this.btDos);
            this.gbBotones.Controls.Add(this.btUno);
            this.gbBotones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbBotones.Location = new System.Drawing.Point(730, 109);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(200, 100);
            this.gbBotones.TabIndex = 9;
            this.gbBotones.TabStop = false;
            this.gbBotones.Text = "Prueba de Sender";
            // 
            // btTres
            // 
            this.btTres.Location = new System.Drawing.Point(135, 41);
            this.btTres.Name = "btTres";
            this.btTres.Size = new System.Drawing.Size(59, 40);
            this.btTres.TabIndex = 2;
            this.btTres.Text = "Tres";
            this.btTres.UseVisualStyleBackColor = true;
            this.btTres.Click += new System.EventHandler(this.btUno_Click);
            // 
            // btDos
            // 
            this.btDos.Location = new System.Drawing.Point(77, 41);
            this.btDos.Name = "btDos";
            this.btDos.Size = new System.Drawing.Size(52, 40);
            this.btDos.TabIndex = 1;
            this.btDos.Text = "Dos";
            this.btDos.UseVisualStyleBackColor = true;
            this.btDos.Click += new System.EventHandler(this.btUno_Click);
            // 
            // btUno
            // 
            this.btUno.Location = new System.Drawing.Point(6, 41);
            this.btUno.Name = "btUno";
            this.btUno.Size = new System.Drawing.Size(65, 40);
            this.btUno.TabIndex = 0;
            this.btUno.Text = "Uno";
            this.btUno.UseVisualStyleBackColor = true;
            this.btUno.Click += new System.EventHandler(this.btUno_Click);
            // 
            // fmElFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1043, 480);
            this.Controls.Add(this.gbBotones);
            this.Controls.Add(this.btVisible);
            this.Controls.Add(this.btBotones);
            this.Controls.Add(this.btDerecha);
            this.Controls.Add(this.btAbajo);
            this.Controls.Add(this.btIzquierda);
            this.Controls.Add(this.btArriba);
            this.Controls.Add(this.laTamanyo);
            this.Controls.Add(this.laMover);
            this.Controls.Add(this.labeLBienvenida);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmElFormulario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmElFormulario_Load);
            this.Click += new System.EventHandler(this.fmElFormulario_Click);
            this.btBotones.ResumeLayout(false);
            this.gbBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeLBienvenida;
        private System.Windows.Forms.Label laMover;
        private System.Windows.Forms.Label laTamanyo;
        private System.Windows.Forms.Button btArriba;
        private System.Windows.Forms.Button btIzquierda;
        private System.Windows.Forms.Button btAbajo;
        private System.Windows.Forms.Button btDerecha;
        private System.Windows.Forms.Panel btBotones;
        private System.Windows.Forms.Button btAumenta;
        private System.Windows.Forms.Button btDetrás;
        private System.Windows.Forms.Button btDelante;
        private System.Windows.Forms.Button btDisminuye;
        private System.Windows.Forms.Button btAcerca;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btPanel;
        private System.Windows.Forms.Button btControles;
        private System.Windows.Forms.Button btVisible;
        private System.Windows.Forms.GroupBox gbBotones;
        private System.Windows.Forms.Button btTres;
        private System.Windows.Forms.Button btDos;
        private System.Windows.Forms.Button btUno;
    }
}

