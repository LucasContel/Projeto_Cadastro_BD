namespace Projeto_Cadastro_BD
{
    partial class FormCursos
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
            tabControlCadastros = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            tabPageConsulta = new TabPage();
            tabControlCadastros.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastros
            // 
            tabControlCadastros.Controls.Add(tabPageCadastro);
            tabControlCadastros.Controls.Add(tabPageConsulta);
            tabControlCadastros.Depth = 0;
            tabControlCadastros.Dock = DockStyle.Fill;
            tabControlCadastros.Location = new Point(3, 64);
            tabControlCadastros.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlCadastros.Multiline = true;
            tabControlCadastros.Name = "tabControlCadastros";
            tabControlCadastros.SelectedIndex = 0;
            tabControlCadastros.Size = new Size(794, 383);
            tabControlCadastros.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Location = new Point(4, 29);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(786, 350);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Location = new Point(4, 29);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(242, 92);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // FormCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlCadastros);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tabControlCadastros;
            IsMdiContainer = true;
            Name = "FormCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCursos";
            tabControlCadastros.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabControlCadastros;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
    }
}