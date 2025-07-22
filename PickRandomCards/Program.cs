namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Entre com o número de cartas para pegar ou digite qualquer outra tecla para sair: ");
                string line = Console.ReadLine();
            
                if (int.TryParse(line, out int numbersOfCards))
                {
                    string[] cards = CardPicker.PickSomeCards(numbersOfCards);
                    foreach (string card in cards)
                    {
                        Console.WriteLine(card);
                    }
                }
                else
                {
                    Environment.Exit(0);
                }
            }

        }
    }
}
