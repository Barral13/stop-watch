namespace StopWatch
{
   public class StartWatch
   {
      public static void Start(int time)
      {
         int currentTime = 0;

         while (currentTime != time)
         {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
         }

         Console.WriteLine("Cronometragem finalizada! ✅");
         Thread.Sleep(2000);
         Console.WriteLine($"Tempo cronometrado: {time} segundos");
         ExitOrReturn();
      }
      public static void PreStart(int time)
      {
         Console.Clear();
         Console.WriteLine("Iniciando cronometragem em:");
         Thread.Sleep(1500);
         Console.WriteLine("TRÊS 3️⃣");
         Thread.Sleep(1000);
         Console.WriteLine("DOIS 2️⃣");
         Thread.Sleep(1000);
         Console.WriteLine("UM   1️⃣");
         Thread.Sleep(1000);
         Console.WriteLine("Cronometragem inicializada! 🚀");
         Thread.Sleep(1500);

         Start(time);
      }
      public static void ExitOrReturn()
      {
         Console.WriteLine("1 - Voltar ao menu. ⏰");
         Console.WriteLine("0 - Fechar cronômetro. ❌");
         short result = short.Parse(Console.ReadLine()!);

         if (result == 0)
         {
            Console.WriteLine("Sistema encerrado, até breve! 🤝");
            Environment.Exit(0);
         }
         else
            Menu.ShowMenu();
      }
   }
}