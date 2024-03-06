namespace GerarAssertion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var configs = new LerESalvarConfiguracoes().LerConfiguracoes();

            if (configs != null)
            {
                this.txt_clientId.Text = configs.clientId;
                this.txt_urlsso.Text = configs.Url;
                this.txt_file.Text = configs.PathArquivo;
                this.txt_scope.Text = configs.Scopes;
            }

            this.Refresh();
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pem|*.pem";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_file.Text = dlg.FileName;
            }
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                var clientId = this.txt_clientId.Text;
                var url = this.txt_urlsso.Text;
                var arquivo = this.txt_file.Text;
                var scopes = this.txt_scope.Text;

                if (string.IsNullOrEmpty(clientId))
                {
                    MessageBox.Show("Informe o ClientId", "Erro", MessageBoxButtons.OK);
                    return;
                }

                if (string.IsNullOrEmpty(url))
                {
                    MessageBox.Show("Informe o Url SSO", "Erro", MessageBoxButtons.OK);
                    return;
                }

                if (string.IsNullOrEmpty(arquivo))
                {
                    MessageBox.Show("Selecione o Arquivo", "Erro", MessageBoxButtons.OK);
                    return;
                }

                var assertionToken = GerarTokenAssertion.GetAssertionToken(clientId, url, arquivo);

                this.txt_assertion_token.Text = assertionToken;
                this.Refresh();

                if (string.IsNullOrEmpty(scopes))
                {
                    MessageBox.Show("Informe o(s) Scope(s)", "Erro", MessageBoxButtons.OK);
                }
                else
                {
                    if (!string.IsNullOrEmpty(assertionToken))
                    {
                        var token = GerarToken.GerarClientToken(clientId, assertionToken, scopes, url);
                        this.txt_token.Text = token;
                    }

                    new LerESalvarConfiguracoes().GravarConfiguracoes(new ConfiguracoesDto()
                    {
                        clientId = clientId,
                        PathArquivo = arquivo,
                        Url = url,
                        Scopes = scopes
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
            this.Cursor = Cursors.Default;

            this.Refresh();
        }
    }
}
