// See https://aka.ms/new-console-template for more information
namespace pessoa{

class Program {
public static void Main (string[] args) {
  Console.WriteLine("Olá");
  pessoa p = new pessoa();
  Console.WriteLine("Digite O Nome Da Pessoa: ");
  p.nome = Console.ReadLine();
  Console.WriteLine("Digite A Idade Da Pessoa: ");
  p.idade = int.Parse(Console.ReadLine());
  Console.WriteLine("O Nome Da Pessoa É {0} E A Idade É {1} ", p.nome, p.idade);
  Console.WriteLine(p);
}
}
public class pessoa{
  public int idade;
  public string nome;
}
}