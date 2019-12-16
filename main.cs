using System;
using System.Globalization;

class MainClass {
  public static void Main (string[] args) {
    Produto P;


    Console.WriteLine ("Digite os dados do produto: ");
    Console.WriteLine ("Nome: ");
    string nome = Console.ReadLine();
    Console.Write ("Preço: ");
    double preco = double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);
    Console.Write ("Quantidade em estoque: ");
    int quantidade = int.Parse (Console.ReadLine());

    P = new Produto (nome,preco,quantidade);


    Console.WriteLine (P.getNome() + " , " + P.getPreco() + " , " + P.getquantidadeEmEstoque());
    

    Console.WriteLine (P.getNome());
  }
}