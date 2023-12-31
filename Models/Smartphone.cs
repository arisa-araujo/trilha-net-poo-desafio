namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        protected List<string> AppsInstalados;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            AppsInstalados = new List<string>();
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void ListarAppsInstalados()
        {
            if (AppsInstalados.Count == 0)
            {
                Console.WriteLine("Não há aplicativos instalados nesse smartphone");
            }
            else
            {
                Console.WriteLine("Aplicativos instalados:");
                foreach(var app in AppsInstalados)
                {
                    Console.WriteLine($"- {app}");
                }
            }
        }
    }
}