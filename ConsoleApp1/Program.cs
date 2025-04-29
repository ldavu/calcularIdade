bool continuar = true;
int querys = 1;

List<int> anosNascimento = new List<int>();
List<int> idades = new List<int>();

while (continuar == true)
{
    int anoNascimento = 0;

    bool entradavalida = false;

    while (!entradavalida)
    {
        Console.WriteLine($"[{querys}] - Digite o Ano de Nascimento:");

        string entrada = Console.ReadLine().Trim();

        if (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("Digite números válidos nesse campo!");
        }
        else if (!int.TryParse(entrada, out anoNascimento))
        {
            Console.WriteLine("Digite um valor correto!");
        }
        else if (int.Parse(entrada) < 1900 || int.Parse(entrada) == 2025) 
        {
            Console.WriteLine($"Digite uma data válida, data informada: {entrada}");
        }
        else
        {
            entradavalida = true;
        }
    }
    
    int idade = 2025-anoNascimento; //calcular idade nascimento
  
    anosNascimento.Add(anoNascimento); // adiciona o ano na tabela
    idades.Add(idade); // adiciona a idade na tabela

    Console.WriteLine($"Você tem: {idade} anos!");

    entradavalida = false;

    while (!entradavalida)
    {
        Console.WriteLine("Deseja continuar o programa? S/N");

        string entrada = Console.ReadLine().Trim().ToUpper();

        if (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("Coloque um Valor!");
        }
        else if (entrada == "S")
        {
            entradavalida = true;
            continuar = true;
            querys++;
        }
        else if (entrada == "N")
        {
            entradavalida = true;
            continuar = false;
        }
        else
        {
            Console.WriteLine("Digite uma entrada válida, S para sim e N para Não!");
            entradavalida = false;

        }
    }
}
Console.Clear();

Console.WriteLine("Programa Encerrado!");
Console.WriteLine("Ano referência: [2025]!");
Console.WriteLine($"Números de requisições apos o término da execução do programa: {querys} pedidos.");
continuar = false;

for (int i = 0; i < anosNascimento.Count; i++)
{
    Console.WriteLine($"[Query {i+1}]Ano: {anosNascimento[i]} - Idade: {idades[i]}");
}