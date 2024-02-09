namespace PrimeraApp
{
    partial class Inicio
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
            components = new System.ComponentModel.Container();
            Menu = new ContextMenuStrip(components);
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            menuUsuarioToolStripMenuItem = new ToolStripMenuItem();
            equipoToolStripMenuItem = new ToolStripMenuItem();
            mercadoToolStripMenuItem = new ToolStripMenuItem();
            rankingToolStripMenuItem = new ToolStripMenuItem();
            ligasToolStripMenuItem = new ToolStripMenuItem();
            resultadoJornadaToolStripMenuItem = new ToolStripMenuItem();
            tiendaToolStripMenuItem = new ToolStripMenuItem();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.Control;
            Menu.Items.AddRange(new ToolStripItem[] { ayudaToolStripMenuItem, inicioToolStripMenuItem, menuUsuarioToolStripMenuItem, equipoToolStripMenuItem, mercadoToolStripMenuItem, rankingToolStripMenuItem, ligasToolStripMenuItem, resultadoJornadaToolStripMenuItem, tiendaToolStripMenuItem, configuraciónToolStripMenuItem });
            Menu.Name = "contextMenuStrip1";
            Menu.Size = new Size(171, 224);
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(170, 22);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(170, 22);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // menuUsuarioToolStripMenuItem
            // 
            menuUsuarioToolStripMenuItem.Name = "menuUsuarioToolStripMenuItem";
            menuUsuarioToolStripMenuItem.Size = new Size(170, 22);
            menuUsuarioToolStripMenuItem.Text = "Menu Usuario";
            // 
            // equipoToolStripMenuItem
            // 
            equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            equipoToolStripMenuItem.Size = new Size(170, 22);
            equipoToolStripMenuItem.Text = "Equipo";
            // 
            // mercadoToolStripMenuItem
            // 
            mercadoToolStripMenuItem.Name = "mercadoToolStripMenuItem";
            mercadoToolStripMenuItem.Size = new Size(170, 22);
            mercadoToolStripMenuItem.Text = "Mercado";
            // 
            // rankingToolStripMenuItem
            // 
            rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            rankingToolStripMenuItem.Size = new Size(170, 22);
            rankingToolStripMenuItem.Text = "Ranking";
            // 
            // ligasToolStripMenuItem
            // 
            ligasToolStripMenuItem.Name = "ligasToolStripMenuItem";
            ligasToolStripMenuItem.Size = new Size(170, 22);
            ligasToolStripMenuItem.Text = "Ligas";
            // 
            // resultadoJornadaToolStripMenuItem
            // 
            resultadoJornadaToolStripMenuItem.Name = "resultadoJornadaToolStripMenuItem";
            resultadoJornadaToolStripMenuItem.Size = new Size(170, 22);
            resultadoJornadaToolStripMenuItem.Text = "Resultado Jornada";
            // 
            // tiendaToolStripMenuItem
            // 
            tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            tiendaToolStripMenuItem.Size = new Size(170, 22);
            tiendaToolStripMenuItem.Text = "Tienda";
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new Size(170, 22);
            configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(179, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(496, 246);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            ForeColor = Color.FromArgb(224, 224, 224);
            Name = "Inicio";
            Text = "Inicio";
            Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip Menu;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem menuUsuarioToolStripMenuItem;
        private ToolStripMenuItem equipoToolStripMenuItem;
        private ToolStripMenuItem mercadoToolStripMenuItem;
        private ToolStripMenuItem rankingToolStripMenuItem;
        private ToolStripMenuItem ligasToolStripMenuItem;
        private ToolStripMenuItem resultadoJornadaToolStripMenuItem;
        private ToolStripMenuItem tiendaToolStripMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}