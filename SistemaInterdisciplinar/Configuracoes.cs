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

        public static string codEstoque = System.Configuration.ConfigurationManager.AppSettings["codEstoque"];
        public static string codFornecedores = System.Configuration.ConfigurationManager.AppSettings["codFornecedores"];
        public static string codReceita = System.Configuration.ConfigurationManager.AppSettings["codReceita"];
        public static string codCMV = System.Configuration.ConfigurationManager.AppSettings["codCMV"];
        public static string codCaixa = System.Configuration.ConfigurationManager.AppSettings["codCaixa"];

        public static string nAtivo = System.Configuration.ConfigurationManager.AppSettings["nAtivo"];
        public static string nPassivo = System.Configuration.ConfigurationManager.AppSettings["nPassivo"];
        public static string nPatrimonio = System.Configuration.ConfigurationManager.AppSettings["nPatrimonio"];
        public static string nReceitas = System.Configuration.ConfigurationManager.AppSettings["nReceitas"];
        public static string nCustos = System.Configuration.ConfigurationManager.AppSettings["nCustos"];


        //reseta as configurações para o padrão
        public static void reset()
        {
            mascaraInterna = "9-9-99-99-99";
            mascaraImpressao = "9-9-99-99-99";
            nomeEmpresa = "EJS LTDA";
            codFornecedores = "2-1-01";
            codEstoque = "1-1-03";
            codReceita = "4-1";
            codCMV = "5-1";
            codCaixa = "1-1-02";

            nAtivo = "1";
            nPassivo = "2";
            nPatrimonio = "3";
            nReceitas = "4";
            nCustos = "5";
            update();
        }

        public static void update()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["mascaraInterna"].Value = mascaraInterna;
            configuration.AppSettings.Settings["mascaraImpressao"].Value = mascaraImpressao;
            configuration.AppSettings.Settings["nomeEmpresa"].Value = nomeEmpresa;

            configuration.AppSettings.Settings["codFornecedores"].Value = codFornecedores;
            configuration.AppSettings.Settings["codReceita"].Value = codReceita;
            configuration.AppSettings.Settings["codCMV"].Value = codCMV;
            configuration.AppSettings.Settings["codCaixa"].Value = codCaixa;

            configuration.AppSettings.Settings["nAtivo"].Value = nAtivo;
            configuration.AppSettings.Settings["nPassivo"].Value = nPassivo;
            configuration.AppSettings.Settings["nPatrimonio"].Value = nPatrimonio;
            configuration.AppSettings.Settings["nReceitas"].Value = nReceitas;
            configuration.AppSettings.Settings["nCustos"].Value = nCustos;

            configuration.Save(ConfigurationSaveMode.Modified);


            System.Configuration.ConfigurationManager.RefreshSection("appSettings");

        }
    }
}
