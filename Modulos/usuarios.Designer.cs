
namespace MDPV
{
    partial class usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bBuscar = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.agregar = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Eli = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.guardadCambios = new System.Windows.Forms.Button();
            this.lbl_idusu = new System.Windows.Forms.Label();
            this.bguardar = new System.Windows.Forms.Button();
            this.bregresar = new System.Windows.Forms.Button();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.texUsuario = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.texContraseña = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bBuscar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(79)))), ((int)(((byte)(139)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 48);
            this.panel1.TabIndex = 0;
            // 
            // cerrar
            // 
            this.cerrar.AutoSize = true;
            this.cerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cerrar.BackColor = System.Drawing.Color.Red;
            this.cerrar.Depth = 0;
            this.cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.cerrar.Font = new System.Drawing.Font("Metropolis Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cerrar.Location = new System.Drawing.Point(854, 0);
            this.cerrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.cerrar.Name = "cerrar";
            this.cerrar.Primary = false;
            this.cerrar.Size = new System.Drawing.Size(21, 44);
            this.cerrar.TabIndex = 1;
            this.cerrar.Text = "X";
            this.cerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cerrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Metropolis Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buscar);
            this.panel2.Controls.Add(this.bBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 58);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buscar
            // 
            this.buscar.Depth = 0;
            this.buscar.Hint = "";
            this.buscar.Location = new System.Drawing.Point(130, 17);
            this.buscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscar.Name = "buscar";
            this.buscar.PasswordChar = '\0';
            this.buscar.SelectedText = "";
            this.buscar.SelectionLength = 0;
            this.buscar.SelectionStart = 0;
            this.buscar.Size = new System.Drawing.Size(296, 23);
            this.buscar.TabIndex = 2;
            this.buscar.UseSystemPasswordChar = false;
            this.buscar.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.White;
            this.bBuscar.Dock = System.Windows.Forms.DockStyle.None;
            this.bBuscar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.bBuscar.Location = new System.Drawing.Point(66, 17);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(36, 24);
            this.bBuscar.TabIndex = 1;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.agregar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(789, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 488);
            this.panel3.TabIndex = 2;
            // 
            // agregar
            // 
            this.agregar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("agregar.ErrorImage")));
            this.agregar.ImageLocation = "CENTER";
            this.agregar.Location = new System.Drawing.Point(0, 32);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(90, 88);
            this.agregar.TabIndex = 0;
            this.agregar.TabStop = false;
            this.agregar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eli});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(789, 488);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Eli
            // 
            this.Eli.HeaderText = "";
            this.Eli.Image = ((System.Drawing.Image)(resources.GetObject("Eli.Image")));
            this.Eli.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eli.Name = "Eli";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Font = new System.Drawing.Font("Metropolis Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(28, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(687, 386);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.guardadCambios);
            this.panel5.Controls.Add(this.lbl_idusu);
            this.panel5.Controls.Add(this.bguardar);
            this.panel5.Controls.Add(this.bregresar);
            this.panel5.Controls.Add(this.comboRol);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.textBox5);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.texUsuario);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.texContraseña);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.texNombre);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(12, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(662, 326);
            this.panel5.TabIndex = 5;
            // 
            // guardadCambios
            // 
            this.guardadCambios.Image = ((System.Drawing.Image)(resources.GetObject("guardadCambios.Image")));
            this.guardadCambios.Location = new System.Drawing.Point(166, 246);
            this.guardadCambios.Name = "guardadCambios";
            this.guardadCambios.Size = new System.Drawing.Size(115, 69);
            this.guardadCambios.TabIndex = 16;
            this.guardadCambios.Text = "Guardar";
            this.guardadCambios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardadCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.guardadCambios.UseVisualStyleBackColor = true;
            this.guardadCambios.Click += new System.EventHandler(this.guardadCambios_Click);
            // 
            // lbl_idusu
            // 
            this.lbl_idusu.AutoSize = true;
            this.lbl_idusu.Location = new System.Drawing.Point(15, 171);
            this.lbl_idusu.Name = "lbl_idusu";
            this.lbl_idusu.Size = new System.Drawing.Size(54, 16);
            this.lbl_idusu.TabIndex = 15;
            this.lbl_idusu.Text = "label7";
            // 
            // bguardar
            // 
            this.bguardar.Image = ((System.Drawing.Image)(resources.GetObject("bguardar.Image")));
            this.bguardar.Location = new System.Drawing.Point(123, 246);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(115, 69);
            this.bguardar.TabIndex = 14;
            this.bguardar.Text = "Guardar";
            this.bguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // bregresar
            // 
            this.bregresar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.bregresar.Image = ((System.Drawing.Image)(resources.GetObject("bregresar.Image")));
            this.bregresar.Location = new System.Drawing.Point(499, 246);
            this.bregresar.Name = "bregresar";
            this.bregresar.Size = new System.Drawing.Size(122, 69);
            this.bregresar.TabIndex = 13;
            this.bregresar.Text = "Volver";
            this.bregresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bregresar.UseVisualStyleBackColor = true;
            this.bregresar.Click += new System.EventHandler(this.bregresar_Click);
            // 
            // comboRol
            // 
            this.comboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Items.AddRange(new object[] {
            "FACTURISTA",
            "ALMACÉN",
            "GERENCIA",
            "COBRANZA",
            "PAGOS",
            "VENTAS ",
            "COMPRAS"});
            this.comboRol.Location = new System.Drawing.Point(181, 138);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(159, 24);
            this.comboRol.TabIndex = 11;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel10.Location = new System.Drawing.Point(181, 128);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(449, 1);
            this.panel10.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(185, 110);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(436, 16);
            this.textBox5.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel9.Location = new System.Drawing.Point(181, 59);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(449, 1);
            this.panel9.TabIndex = 10;
            // 
            // texUsuario
            // 
            this.texUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texUsuario.Location = new System.Drawing.Point(185, 41);
            this.texUsuario.Name = "texUsuario";
            this.texUsuario.Size = new System.Drawing.Size(436, 16);
            this.texUsuario.TabIndex = 9;
            this.texUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel8.Location = new System.Drawing.Point(182, 91);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(449, 1);
            this.panel8.TabIndex = 10;
            // 
            // texContraseña
            // 
            this.texContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texContraseña.Location = new System.Drawing.Point(189, 73);
            this.texContraseña.Name = "texContraseña";
            this.texContraseña.Size = new System.Drawing.Size(436, 16);
            this.texContraseña.TabIndex = 9;
            this.texContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Location = new System.Drawing.Point(181, 23);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(449, 1);
            this.panel6.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel7.Location = new System.Drawing.Point(0, 29);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(449, 1);
            this.panel7.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(4, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(436, 16);
            this.textBox2.TabIndex = 7;
            // 
            // texNombre
            // 
            this.texNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texNombre.Location = new System.Drawing.Point(185, 5);
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(436, 16);
            this.texNombre.TabIndex = 5;
            this.texNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Rol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Correo electronico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Metropolis Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(112, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Metropolis Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre y Apellidos";
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(879, 594);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.bBuscar;
            this.Name = "usuarios";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bBuscar.ResumeLayout(false);
            this.bBuscar.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip bBuscar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialSingleLineTextField buscar;
        private MaterialSkin.Controls.MaterialFlatButton cerrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox texUsuario;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox texContraseña;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox texNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bregresar;
        private System.Windows.Forms.DataGridViewImageColumn Eli;
        private System.Windows.Forms.Label lbl_idusu;
        private System.Windows.Forms.Button guardadCambios;
    }
}

