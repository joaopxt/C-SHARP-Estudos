// See https://aka.ms/new-console-template for more information
using Udemy_sec5;

Console.Write("Quantos quartos vão ser alugados: ");
int tam = int.Parse(Console.ReadLine());

Quartos[] hotel = new Quartos[10];

for (int i = 0; i < tam; i++)
{ 

}

    for (int i = 0; i < tam; i++)
{
    Console.WriteLine($"Reserva #{i+1}");

    Console.Write("Nome: ");
    string nam = Console.ReadLine();
    Console.Write("Email: ");
    string eml = Console.ReadLine();
    Console.Write("Quarto: ");
    int room = int.Parse(Console.ReadLine());

    hotel[room] = new Quartos{ Numero= room, Hospede= nam, Email = eml};
}

Console.WriteLine("Quartos ocupados: ");

for(int i = 0; i < hotel.Length; i++)
{
    if (hotel[i] != null)
    {
        hotel[i].ViewDados();
    }
}


























/*
int tam = 0;

Console.Write("Qual o tamanho do array? ");
tam = int.Parse(Console.ReadLine());

double[] array = new double[tam];
for (int i = 0; i < tam; i++)
{
    Console.Write($"Altura n°{i+1}: ");
    double alt = double.Parse(Console.ReadLine());
    array[i] = alt;
}

for (int i = 0; i < tam; i++)
{
    Console.WriteLine(array[i]);
}

double soma = 0;
for(int i = 0; i < tam; i++)
{
     soma += array[i]; 
}



double media = soma / tam;

Console.Write($"A média das alturas informadas é: {media.ToString("F2")}");*/



























/*

Console.Write("Digite o número da conta: ");
int num = int.Parse(Console.ReadLine());

Console.Write("Digite o nome do titular da conta: ");
string name = Console.ReadLine();

double saldo = 0;
Console.Write("Haverá depósito inicial? (s/n) ");
string checker = Console.ReadLine(); 

if(checker == "s" || checker == "S")
{
    Console.Write("Digite o valor a ser depositado inicialmente: ");
    saldo = double.Parse(Console.ReadLine());

}

Conta c1 = new Conta(name, num, saldo);

Console.WriteLine();
Console.WriteLine("Dados da conta: ");
c1.ViewDados();

Console.Write("Entre um valor para ser depositado: ");
double dep = double.Parse(Console.ReadLine());
c1.Deposito(dep);

Console.WriteLine();
Console.WriteLine("Dados atualizados: ");
c1.ViewDados();

Console.Write("Entre um valor para ser sacado: ");
double saq = double.Parse(Console.ReadLine());
c1.Saque(saq);

Console.WriteLine();
Console.WriteLine("Dados atualizados: ");
c1.ViewDados();*/

























/*

Conta p1 = new Conta("Celular", 2000.00, 5);

Console.WriteLine(p1.Nome);

p1.Nome = "Celular Smartphone";

Console.WriteLine(p1.Nome);

Console.WriteLine(p1.Preco);

Console.WriteLine(p1.Quantidade);*/


























/*
Console.WriteLine("Entre os dados do produto: ");

Console.WriteLine("Nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Preco: ");
double preco = double.Parse(Console.ReadLine());

Console.WriteLine("Quantidade: ");
int quantidade = int.Parse(Console.ReadLine());

Produto p1 = new Produto(nome, preco);

Produto p2 = new Produto();

Console.WriteLine($"Dados do produto: {p1.Nome}, ${p1.Preco}, {p1.Quantidade}, Total: ${p1.ValorTotalEmEstoque()}");

Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
int add = int.Parse(Console.ReadLine());
p1.AdicionarProdutos(add);

Console.WriteLine($"Dados atualizados: {p1.Nome}, ${p1.Preco}, {p1.Quantidade}, Total: ${p1.ValorTotalEmEstoque()}");

Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");
int rmv = int.Parse(Console.ReadLine());
p1.RemoverProdutos(rmv);

Console.WriteLine($"Dados atualizados: {p1.Nome}, ${p1.Preco}, {p1.Quantidade}, Total: ${p1.ValorTotalEmEstoque()}");*/
