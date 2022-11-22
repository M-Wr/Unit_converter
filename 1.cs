using System;
namespace game {


namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      void input = Console.WriteLine();
      var kilo = Int32.Parse(input);
      var stone = kilo / 6.35;  
      Console.WriteLine(stone);
      var stoneDec = stone % 1;
      
      Console.WriteLine(stoneDec);

      var pound = stoneDec * 14;
      stone = Math.Truncate(stone);
      pound = Math.Truncate(pound);

      Console.WriteLine(pound);

      var endp = $" {kilo} Kg, is equivilent to: {stone}st and {pound}lbs";
      Console.WriteLine(endp);

    }
  }
}





}

