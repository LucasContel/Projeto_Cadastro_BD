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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCursos));
            tabControlCadastros = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            txtArea = new ReaLTaiizor.Controls.MaterialComboBox();
            txtPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDuracao = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            dataGridViewCurso = new DataGridView();
            imageList1 = new ImageList(components);
            tabControlCadastros.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCurso).BeginInit();
            SuspendLayout();
            // 
            // tabControlCadastros
            // 
            tabControlCadastros.Controls.Add(tabPageCadastro);
            tabControlCadastros.Controls.Add(tabPageConsulta);
            tabControlCadastros.Depth = 0;
            tabControlCadastros.Dock = DockStyle.Fill;
            tabControlCadastros.ImageList = imageList1;
            tabControlCadastros.Location = new Point(3, 48);
            tabControlCadastros.Margin = new Padding(3, 2, 3, 2);
            tabControlCadastros.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlCadastros.Multiline = true;
            tabControlCadastros.Name = "tabControlCadastros";
            tabControlCadastros.SelectedIndex = 0;
            tabControlCadastros.Size = new Size(618, 315);
            tabControlCadastros.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.Controls.Add(txtArea);
            tabPageCadastro.Controls.Add(txtPeriodo);
            tabPageCadastro.Controls.Add(txtDuracao);
            tabPageCadastro.Controls.Add(txtNivel);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtCodigo);
            tabPageCadastro.ImageKey = "form.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Margin = new Padding(3, 2, 3, 2);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3, 2, 3, 2);
            tabPageCadastro.Size = new Size(610, 280);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(28, 27);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(86, 48);
            txtId.TabIndex = 8;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = false;
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(374, 218);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(100, 35);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = false;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(107, 218);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(100, 35);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtArea
            // 
            txtArea.AutoResize = false;
            txtArea.BackColor = Color.FromArgb(255, 255, 255);
            txtArea.Depth = 0;
            txtArea.DrawMode = DrawMode.OwnerDrawVariable;
            txtArea.DropDownHeight = 174;
            txtArea.DropDownStyle = ComboBoxStyle.DropDownList;
            txtArea.DropDownWidth = 121;
            txtArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtArea.FormattingEnabled = true;
            txtArea.Hint = "Área";
            txtArea.IntegralHeight = false;
            txtArea.ItemHeight = 43;
            txtArea.Items.AddRange(new object[] { "Licenciatura", "Informática", "Indústria", "Administração" });
            txtArea.Location = new Point(298, 161);
            txtArea.MaxDropDownItems = 4;
            txtArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(250, 49);
            txtArea.StartIndex = 0;
            txtArea.TabIndex = 5;
            // 
            // txtPeriodo
            // 
            txtPeriodo.AutoResize = false;
            txtPeriodo.BackColor = Color.FromArgb(255, 255, 255);
            txtPeriodo.Depth = 0;
            txtPeriodo.DrawMode = DrawMode.OwnerDrawVariable;
            txtPeriodo.DropDownHeight = 174;
            txtPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPeriodo.DropDownWidth = 121;
            txtPeriodo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtPeriodo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtPeriodo.FormattingEnabled = true;
            txtPeriodo.Hint = "Período";
            txtPeriodo.IntegralHeight = false;
            txtPeriodo.ItemHeight = 43;
            txtPeriodo.Items.AddRange(new object[] { "Matutino", "Vespetino", "Noturno", "Integral" });
            txtPeriodo.Location = new Point(28, 161);
            txtPeriodo.MaxDropDownItems = 4;
            txtPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.Size = new Size(250, 49);
            txtPeriodo.StartIndex = 0;
            txtPeriodo.TabIndex = 4;
            // 
            // txtDuracao
            // 
            txtDuracao.AutoResize = false;
            txtDuracao.BackColor = Color.FromArgb(255, 255, 255);
            txtDuracao.Depth = 0;
            txtDuracao.DrawMode = DrawMode.OwnerDrawVariable;
            txtDuracao.DropDownHeight = 174;
            txtDuracao.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDuracao.DropDownWidth = 121;
            txtDuracao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtDuracao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtDuracao.FormattingEnabled = true;
            txtDuracao.Hint = "Duração em Semestres";
            txtDuracao.IntegralHeight = false;
            txtDuracao.ItemHeight = 43;
            txtDuracao.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            txtDuracao.Location = new Point(298, 94);
            txtDuracao.MaxDropDownItems = 4;
            txtDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDuracao.Name = "txtDuracao";
            txtDuracao.Size = new Size(250, 49);
            txtDuracao.StartIndex = 0;
            txtDuracao.TabIndex = 3;
            // 
            // txtNivel
            // 
            txtNivel.AutoResize = false;
            txtNivel.BackColor = Color.FromArgb(255, 255, 255);
            txtNivel.Depth = 0;
            txtNivel.DrawMode = DrawMode.OwnerDrawVariable;
            txtNivel.DropDownHeight = 174;
            txtNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            txtNivel.DropDownWidth = 121;
            txtNivel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtNivel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtNivel.FormattingEnabled = true;
            txtNivel.Hint = "Nível";
            txtNivel.IntegralHeight = false;
            txtNivel.ItemHeight = 43;
            txtNivel.Items.AddRange(new object[] { "Técnico", "Superior" });
            txtNivel.Location = new Point(28, 94);
            txtNivel.MaxDropDownItems = 4;
            txtNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(250, 49);
            txtNivel.StartIndex = 0;
            txtNivel.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(319, 27);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(229, 48);
            txtNome.TabIndex = 1;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtCodigo
            // 
            txtCodigo.AnimateReadOnly = false;
            txtCodigo.AutoCompleteMode = AutoCompleteMode.None;
            txtCodigo.AutoCompleteSource = AutoCompleteSource.None;
            txtCodigo.BackgroundImageLayout = ImageLayout.None;
            txtCodigo.CharacterCasing = CharacterCasing.Normal;
            txtCodigo.Depth = 0;
            txtCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigo.HideSelection = true;
            txtCodigo.Hint = "Código do Curso";
            txtCodigo.LeadingIcon = null;
            txtCodigo.Location = new Point(120, 27);
            txtCodigo.MaxLength = 32767;
            txtCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.PrefixSuffixText = null;
            txtCodigo.ReadOnly = false;
            txtCodigo.RightToLeft = RightToLeft.No;
            txtCodigo.SelectedText = "";
            txtCodigo.SelectionLength = 0;
            txtCodigo.SelectionStart = 0;
            txtCodigo.ShortcutsEnabled = true;
            txtCodigo.Size = new Size(193, 48);
            txtCodigo.TabIndex = 0;
            txtCodigo.TabStop = false;
            txtCodigo.TextAlign = HorizontalAlignment.Left;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.Controls.Add(dataGridViewCurso);
            tabPageConsulta.ImageKey = "search.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Margin = new Padding(3, 2, 3, 2);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3, 2, 3, 2);
            tabPageConsulta.Size = new Size(610, 280);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = false;
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(434, 237);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(85, 35);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSize = false;
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(327, 237);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(85, 35);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.AutoSize = false;
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(225, 237);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(85, 35);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // dataGridViewCurso
            // 
            dataGridViewCurso.AllowUserToAddRows = false;
            dataGridViewCurso.AllowUserToDeleteRows = false;
            dataGridViewCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCurso.Location = new Point(3, 5);
            dataGridViewCurso.Name = "dataGridViewCurso";
            dataGridViewCurso.ReadOnly = true;
            dataGridViewCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCurso.Size = new Size(560, 223);
            dataGridViewCurso.TabIndex = 1;
            dataGridViewCurso.CellDoubleClick += dataGridViewCurso_CellDoubleClick;
            dataGridViewCurso.Enter += dataGridViewCurso_Enter;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // FormCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 365);
            Controls.Add(tabControlCadastros);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tabControlCadastros;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCursos";
            Padding = new Padding(3, 48, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cursos";
            tabControlCadastros.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCurso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabControlCadastros;
        private TabPage tabPageConsulta;
        private ImageList imageList1;
        private TabPage tabPageCadastro;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialComboBox txtArea;
        private ReaLTaiizor.Controls.MaterialComboBox txtPeriodo;
        private ReaLTaiizor.Controls.MaterialComboBox txtDuracao;
        private ReaLTaiizor.Controls.MaterialComboBox txtNivel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigo;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private DataGridView dataGridViewCurso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}