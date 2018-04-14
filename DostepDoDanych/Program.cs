using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace DostepDoDanych
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form2());
            Kontroler kontroler = new Kontroler();

            int kontrolka2 = 0;
            int kontrolka3 = 0;

            do
            {
                Console.WriteLine("-----Menu-----\nWybierz tabele:\n 1: Aktorzy\n 2: Filmy\n 3: Miejsca\n 4: Wytwornie\n 0:zakoncz program\n______________");
                kontrolka2 = int.Parse(Console.ReadLine());
                switch (kontrolka2)
                {
                    case 1:
                        do
                        {


                            Console.WriteLine("---Aktorzy---\nWybierz Operacje \n1: Wyświetl dane \n2: Dodaj element \n3: Usun element\n4: Eytuj element \n0: Powrot");
                            kontrolka3 = int.Parse(Console.ReadLine());



                            switch (kontrolka3)
                            {
                                case 1:
                                    kontroler.WyswietlAktorow();
                                    break;
                                case 2:
                                    kontroler.DodaAktora();
                                    break;
                                case 3:
                                    kontroler.UsunAktora();
                                    break;
                                case 4:
                                    kontroler.EdytujAktora();
                                    break;
                                default:
                                    break;
                            }
                        } while (kontrolka3 != 0);
                        break;
                    case 2:
                        do
                        {

                            Console.WriteLine("---Filmy---\nWybierz Operacje \n1: Wyświetl dane \n2: Dodaj element \n3: Usun element\n4: Eytuj element \n0: Powrot");
                            kontrolka3 = int.Parse(Console.ReadLine());



                            switch (kontrolka3)
                            {
                                case 1:
                                    kontroler.WyswietlFilmy();
                                    break;
                                case 2:
                                    kontroler.DodajFilm();
                                    break;
                                case 3:
                                    kontroler.UsunFilm();
                                    break;

                                default:
                                    break;
                            }
                        } while (kontrolka3 != 0);

                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("---Miejsca---\nWybierz Operacje \n1: Wyświetl dane \n2: Dodaj element \n3: Usun element\n4: Eytuj element \n0: Powrot");
                            kontrolka3 = int.Parse(Console.ReadLine());



                            switch (kontrolka3)
                            {
                                case 1:
                                    kontroler.WyswietlMiejsca();
                                    break;
                                case 2:
                                    kontroler.DodajMiejsce();
                                    break;
                                case 3:
                                    kontroler.UsunMiejsce();
                                    break;
                                case 4:
                                    kontroler.EdytujMiejsce();
                                    break;
                                default:
                                    break;
                            }
                        } while (kontrolka3 != 0);
                        break;
                    case 4:
                        do
                        {
                            Console.WriteLine("---Wytwornie---\nWybierz Operacje \n1: Wyświetl dane \n2: Dodaj element \n3: Usun element\n4: Eytuj element \n0: Powrot");
                            kontrolka3 = int.Parse(Console.ReadLine());



                            switch (kontrolka3)
                            {
                                case 1:
                                    kontroler.WyswietlWytwornie();
                                    break;
                                case 2:
                                    kontroler.DodajWytwornie();
                                    break;
                                case 3:
                                    kontroler.UsunWytwornie();
                                    break;

                                default:
                                    break;
                            }
                        } while (kontrolka3 != 0);
                        break;
                    default:
                        break;

                }




            } while (kontrolka2 != 0);



            Console.ReadKey();
        }
    }
}
