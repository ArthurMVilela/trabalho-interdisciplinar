using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SistemaInterdisciplinar
{
    public static class Configuracoes
    {
        public static string mascaraInterna = System.Configuration.ConfigurationManager.AppSettings["mascaraInterna"];
        public static string mascaraImpressao = System.Configuration.ConfigurationManager.AppSettings["mascaraImpressao"];
        public static string nomeEmpresa = System.Configuration.ConfigurationManager.AppSettings["nomeEmpresa"];
        
        //reseta as configurações para o padrão
        public static void reset()
        {
            mascaraInterna = "9-9-99-99-99";
            mascaraImpressao = "9-9-99-99-99";
            nomeEmpresa = "EJS LTDA";
            update();
        }

        public static void update()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["mascaraInterna"].Value = mascaraInterna;
            configuration.AppSettings.Settings["mascaraImpressao"].Value = mascaraImpressao;
            configuration.AppSettings.Settings["nomeEmpresa"].Value = nomeEmpresa;
            configuration.Save(ConfigurationSaveMode.Modified);


            System.Configuration.ConfigurationManager.RefreshSection("appSettings");

        }
    }
}
