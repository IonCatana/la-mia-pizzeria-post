using la_mia_pizzeria_model.Models;

namespace la_mia_pizzeria_model.Utilities
{
    public class PizzeData
    {
        private static List<Pizze> pizze;


        public static List<Pizze> GetPizze()
        {
            if (PizzeData.pizze != null)
            {
                return PizzeData.pizze;
            }
            List<Pizze> nuovaListaPizze = new List<Pizze>();

            for (int i = 0; i < 5; i++)
            {
                Pizze NuovaPizza = new Pizze("https://picsum.photos/id/" + i + "237/200/300", "Titolo Pizza : " + i, "Lorem ipsum arga ers tua mono cols ergom", "prezzo");
                nuovaListaPizze.Add(NuovaPizza);
            }
            PizzeData.pizze = nuovaListaPizze;
            return PizzeData.pizze;
        }
    }
}
