using System;

namespace ExerciciosPraticos;
class Program
{
    static void Main()
    {

        //Exercícios Práticos - Fundamentos C# da RocketSeat
        //Continuando o aprendizado e evoluindo a cada dia
        
        //Exercício 1
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");

        //Exercício2
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome:");
        string sobrenome = Console.ReadLine();

        Console.WriteLine(nome + " " + sobrenome);

        //Exercicio3
        Console.WriteLine("Digite dois numeros e veja algumas operações:");
        string numStr = Console.ReadLine();
        double num = Double.Parse(numStr);
        string numStr2 = Console.ReadLine();
        double num2 = Double.Parse(numStr2);

        Console.WriteLine($"A soma entre {num} e {num2} eh igual a: {num + num2}");
        Console.WriteLine($"A subtração entre {num} e {num2} eh igual a: {num - num2}");
        Console.WriteLine($"A multiplicação entre {num} e {num2} eh igual a: {num * num2}");
        if (num2 != 0)
        {
            Console.WriteLine($"A divisão entre {num} e {num2} eh igual a: {num / num2}");
        } else
        {
            Console.WriteLine($"Impossível fazer a divisão entre {num} e {num2}, pois o denominado eh igual a zero");
        }
        Console.WriteLine($"A média entre {num} e {num2} eh igual a: {(num + num2) / 2}");

        //Exercicio4
        Console.WriteLine("Digite uma palavra:");
        string palavra = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < palavra.Length; i++)
        {
            Console.WriteLine(palavra[i]);
            if (palavra[i].Equals(' '))
            {
                Console.WriteLine($"Caractere na posição {i} eh um espaço, portanto não estou somando!");
            } else { count++; }

        }
        Console.WriteLine($"A palavra: '{palavra}' tem {count} caracteres");


        //Exercicio5
        Console.WriteLine("Digite a placa do seu veículo:");
        string placa = Console.ReadLine();
        char[] placaArray = placa.ToCharArray();
        int count = 0;
        if (placa.Length == 7)
        {
            for (int i = 0; i < 3; i++) {
                if (Char.IsLetter(placaArray[i])) {
                    count++; }
            }
            for (int i = 3; i < 7; i++) {
                if (Char.IsDigit(placaArray[i])) {
                    count++; }
            }
            if (count == 7)
            {
                Console.WriteLine($"A placa '{placa}' está no padrão brasileiro!");
            }
            else { Console.WriteLine("A placa não está no padrão brasileiro!"); }
        } else {
            Console.WriteLine("Sua placa não está no padrão de 7  caracteres alfanumericos!\n Tente novamente!"); }

        //Exercicio6

        DateTime dataAtual = DateTime.Now;
        string formatoCompleto = dataAtual.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        Console.WriteLine($"Formato Completo: {formatoCompleto}");

        string apenasData = dataAtual.ToString("dd/MM/yyyy");
        Console.WriteLine($"Apenas a Data: {apenasData}");

        string apenasHora = dataAtual.ToString("HH:mm");
        Console.WriteLine($"Apenas a Hora: {apenasHora}");

        string dataComMesExtenso = dataAtual.ToString("dd 'de' MMMM 'de' yyyy");
        Console.WriteLine($"Data com Mês por Extenso: {dataComMesExtenso}");

    }
}