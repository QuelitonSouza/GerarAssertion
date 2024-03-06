namespace GerarAssertion
{
    public class LerESalvarConfiguracoes
    {

        public void GravarConfiguracoes(ConfiguracoesDto dto)
        {
            var path = CreateFolder();
            var file = string.Format("{0}config.json", path);
            using (StreamWriter writer = new StreamWriter(file))
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(dto);
                writer.Write(json);
                writer.Close();
            }
        }

        public ConfiguracoesDto LerConfiguracoes()
        {
            ConfiguracoesDto result = null;
            var path = CreateFolder();
            var file = string.Format("{0}config.json", path);
            if (File.Exists(file))
            {
                using (StreamReader read = new StreamReader(file))
                {
                    string line;
                    while ((line = read.ReadLine()) != null)
                    {
                        result = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfiguracoesDto>(line);
                    }
                }
            }

            return result;
        }

        private string PathDefault()
        {
            return AppDomain.CurrentDomain.BaseDirectory.ToString();
        }

        private bool ValidPath(string folder)
        {
            var path = string.Format("{0}{1}", PathDefault(), folder);
            return Directory.Exists(path);
        }

        private string CreateFolder()
        {
            var path = PathDefault();
            if (!ValidPath(string.Empty))
            {
                Directory.CreateDirectory(path);
            }

            return path + "\\";
        }
    }


    public class ConfiguracoesDto
    {
        public string clientId { get; set; }
        public string Scopes { get; set; }
        public string PathArquivo { get; set; }
        public string Url { get; set; }
    }
}
