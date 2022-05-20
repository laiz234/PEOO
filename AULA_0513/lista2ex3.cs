using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite a primeira nota do bimestre: ");
    string a = Console.ReadLine();
    Console.WriteLine("Digite sua segunda nota do bimestre: ");
    string b = Console.ReadLine();
    int c = int.Parse(a);
    int d = int.Parse(b);

    int media = (c * 2 + d * 3) / 5 ;
    Console.WriteLine("Média Parcial: " + media);    
  }
}
