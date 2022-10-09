using System.Security.Cryptography.X509Certificates;

namespace Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bil bil = new Bil(); // Vi skapar objekt av våra klasser
            Cykel cykel = new Cykel();
            Båt båt = new Båt();

            Fordon[] minArray = { bil, cykel, båt }; // Vi skapar en array av vår klass Fordon och lägger in bil, båt och cykel och det kan vi för alla ärver från Fordon.

            foreach (Fordon heh in minArray)
            {
                heh.Go();
            }
        }
    }

    class Fordon // Parent klassen
    {
        public virtual void Go() // Vi skapar en 'virtual' metod så att vi kan köra en overrida på våra metoder nedan.
        {
            // Vi behöver inte lägga någon kod här för vi kör en override på alla andra klasser 
        }
    }

    class Bil : Fordon // Child klasser som ärver från dess Parent 
    {
        public override void Go() // Vi kör en override på metoden så att den ändras för vår Bil-klass
        {
            Console.WriteLine("Bilen kör");
        }
    }

    class Cykel : Fordon
    {
        public override void Go()
        {
            Console.WriteLine("Cykeln kör");
        }
    }

    class Båt : Fordon
    {        public override void Go()
        {
            Console.WriteLine("Båten kör");
        }
    }



    public class Parent
    {
        public virtual void MakeSchedule() // vi lägger till 'vitual' för att kunna overrida denna metoden 
        {
            Console.WriteLine("Skapa ett schema för en förälder");
        }
    }


    public class Child : Parent // Child ärver från Parent klassen
    {
        public Child()
        {
            MakeSchedule();
            // Output : "Skapa ett schema för en förälder" - men vi vill skriva ut att det är för ett barn! Så då gör vi nedan kod
        }

        public override void MakeSchedule() // Vi kör en overide på metoden tack vare ett den är virtual och skriver in nedan hur den skall ändras
        {
            Console.WriteLine("Skapa ett schema för ett barn");
        }
    }
}