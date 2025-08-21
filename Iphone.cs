namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} via AppStore...");
        }

        public override string ToString()
        {
            return $"DADOS DO SEU APARELHO: \nNumero: {Numero}\nModelo: {Modelo}\nIMEI: {IMEI}\nMemoria: {Memoria}";
        }
    }
}