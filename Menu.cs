namespace StopWatch
{
   public class Menu
   {
      public static void ShowMenu()
      {
         Console.Clear();
         Console.WriteLine("Informações sobre o cronômetro.");
         Console.WriteLine("0 - Fechar cronômetro.");
         Console.WriteLine("S - Segundos => 13s = 13 segundos");
         Console.WriteLine("M - Minutos => 1m = 1 minuto");
         Console.WriteLine("");
         Console.WriteLine("Informe o tempo que deseja cronometrar.");

         string data = Console.ReadLine()!.ToLower();
         char type = char.Parse(data.Substring(data.Length - 1, 1));
         if (string.IsNullOrEmpty(data) || !char.IsLetter(data[data.Length - 1]) || !int.TryParse(data.Substring(0, data.Length - 1), out int time))
         {
            Console.WriteLine("Entrada inválida. Informe o time e o tipo.");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            ShowMenu();
            return;
         }

         int multiplier = 1;

         if (type == 'm')
            multiplier = 60;

         if (time == 0)
            Environment.Exit(0);

         StartWatch.PreStart(time * multiplier);
      }
   }
}