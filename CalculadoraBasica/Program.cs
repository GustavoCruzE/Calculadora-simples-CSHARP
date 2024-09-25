double num1 = 0;
double num2 = 0;
double resultado = 0;
String tipoConta;


Console.WriteLine("----- CALCULADORA -----");
Console.WriteLine(num1);

Console.WriteLine();
Console.Write("Digite o 1º número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine(num1);

do
{
    Console.WriteLine();
    Console.WriteLine("----- OPÇÕES -----");
    Console.WriteLine("+   Adição");
    Console.WriteLine("-   Subtração");
    Console.WriteLine("*   Multiplicação");
    Console.WriteLine("/   Divisão");
    Console.WriteLine("A   Apagar");
    Console.WriteLine("F   Finalizar aplicação");
    tipoConta = Console.ReadLine();
    tipoConta = tipoConta.ToUpper();
    if (tipoConta == "A")
    {
        num1 = 0;
        Console.WriteLine();
        Console.WriteLine("----- CALCULADORA -----");
        Console.WriteLine(num1);

        Console.WriteLine();
        Console.Write("Digite o 1º número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine(num1);
    }
    else if (tipoConta == "F")
    {
    }
    else
    {


        Console.WriteLine();
        Console.WriteLine("----- CALCULADORA -----");
        Console.WriteLine(num1 + " " + tipoConta);

        Console.WriteLine();
        Console.Write("Digite o 2º número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        switch (tipoConta)
        {
            case "+":
                resultado = num1 + num2;
                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "*":
                resultado = num1 * num2;
                break;
            case "/":
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
        num1 = resultado;

        Console.WriteLine();
        Console.WriteLine("----- CALCULADORA -----");
        Console.WriteLine(num1);
    }
} while (tipoConta != "F");
Console.WriteLine("Aplicação finalizada!");
