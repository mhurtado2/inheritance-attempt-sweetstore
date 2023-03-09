namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Step 1:
                    Create at least one instance of each kind of candy
             */



            /*
                Step 2:
                    Create at least one instance of each kind of baked good
             */
            Pie rhubarbPie = new Pie() {
                Name = "Rhubarb Pie",
                BakingTemperature = 100
            };
            Cake jelloCake = new Cake() {
                Name = "Jello Cake",
                BakingTemperature = 100
            };
            Macaroon pistacioMacaroon = new Macaroon() {
                Name = "Pistacio Macaroon",
                BakingTemperature = 100
            };
            Cookie raisinCookie = new Cookie() {
                Name = "Raisin Cookie",
                BakingTemperature = 100
            };

            List<BakedGood> displayCase = new List<BakedGood> {
                rhubarbPie,
                jelloCake,
                pistacioMacaroon,
                raisinCookie
            };

            /*
                Madi wants to see Name, Baking Temeprature and if it is Frosted
             */
            foreach (var baked in displayCase)
            {
                Console.WriteLine(baked.Name);
            }






            /*
                Step 3:
                    Create a List<> and add all baked goods to the list
             */

        }
    }
}
