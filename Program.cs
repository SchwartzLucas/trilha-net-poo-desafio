using System.Collections;
using System.Diagnostics;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

while (true){

    Console.WriteLine("Nokia - 1");
    Console.WriteLine("Iphone - 2");
    Console.WriteLine("Sair - 0");

    int resposta = int.Parse(Console.ReadLine());
    switch (resposta)
    {
        case 1:
        {
            Console.WriteLine("Qual o modelo do seu Nokia?");
            string modelo = Console.ReadLine();
            Console.WriteLine("Qual o seu numero?");
            string numero = Console.ReadLine();
            Console.WriteLine("Qual o seu IMEI?");
            string imei = Console.ReadLine();
            Console.WriteLine("Quanto de memoria tem o seu celular?");
            int memoria = int.Parse(Console.ReadLine());

            Smartphone nokia = new Nokia(numero, modelo, imei, memoria);
            Console.WriteLine(nokia);

            Console.WriteLine("Que aplicativo deseja instalar?");
            string App = Console.ReadLine();

            nokia.InstalarAplicativo(App);
            break;
        }
        case 2:
        {
            Console.WriteLine("Qual o modelo do seu Iphone?");
            string modelo = Console.ReadLine();
            Console.WriteLine("Qual o seu numero?");
            string numero = Console.ReadLine();
            Console.WriteLine("Qual o seu IMEI?");
            string imei = Console.ReadLine();
            Console.WriteLine("Quanto de memoria tem o seu celular?");
            int memoria = int.Parse(Console.ReadLine());

            Smartphone iphone = new Iphone(numero, modelo, imei, memoria);
            Console.WriteLine(iphone);

            Console.WriteLine("Que aplicativo deseja instalar?");
            string App = Console.ReadLine();

            iphone.InstalarAplicativo(App);
            break;
        }
        case 0:
        Console.WriteLine("Saindo do programa...");
        return;

    default:
        Console.WriteLine("Opção inválida!");
        break;
    }
}