using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DostepDoDanych
{
    class Kontroler
    {
        BloggingContext db = new BloggingContext();

        public IQueryable<Miejsce> WyswietlMiejsca()
        {
            string zawartosc = "0";
            var query = from q in db.Miejsca
                        select q;
            foreach (var item in query)
            {
                //Console.Write("{0}, {1}, {2}", item.MiejsceID, item.Panstwo, item.Miasto);

                //Console.WriteLine();
                zawartosc += item.MiejsceID + ", " + item.Panstwo + ", " + item.Miasto+"\n";

            }
            return query;
        }

        public void DodajMiejsce()
        {
            Console.WriteLine("Podaj Panstwo");
            string panstwo = Console.ReadLine();
            Console.WriteLine("Podaj Miasto");
            string miasto = Console.ReadLine();
            
            var miejsce = new Miejsce { Panstwo = panstwo, Miasto = miasto };
            db.Miejsca.Add(miejsce);
            db.SaveChanges();

        }

        public void UsunMiejsce()
        {
            Console.WriteLine("Podaj Id miejsca ktore chcesz usunąć.");
            int id = int.Parse(Console.ReadLine());
            

            var query = from q in db.Miejsca
                        where q.MiejsceID == id
                        select q;
            if (query.First().Aktorzy.Count == 0)
            {
                db.Miejsca.Remove(query.First());
                db.SaveChanges();
            }
            else Console.WriteLine("Nie można usunąć, element jest używany przez inny obiekt"); 
        }

        public void EdytujMiejsce()
        {
            Console.WriteLine("Podaj Id miejsca ktore chcesz edytować");
            int id = int.Parse(Console.ReadLine());
            

            int kontrolka = 0;
            var query = from q in db.Miejsca
                        where q.MiejsceID == id
                        select q;
            var obiekt = query.First();

            Console.WriteLine("1: Edytuj Państwo, 2: Edytuj Miasto");
            kontrolka = int.Parse(Console.ReadLine());
            switch (kontrolka)
            {
                case 1:
                    Console.WriteLine("Podaj nowe Państwo");
                    obiekt.Panstwo = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Podaj nowe Miasto");
                    obiekt.Miasto = Console.ReadLine();
                    break;
                default:
                    break;
            }
            db.SaveChanges();

        }

        public void DodaAktora()
        {
            Console.WriteLine("Podaj Imie");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj Nazwisko");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj rok, miesiac i dzien urodzenia aktora");

            int rok, miesiac, dzien;
            rok = int.Parse(Console.ReadLine());
            miesiac = int.Parse(Console.ReadLine());
            dzien = int.Parse(Console.ReadLine());
            DateTime data = new DateTime(rok, miesiac, dzien);

            
            var aktor = new Aktor { Imie = imie, Nazwisko = nazwisko, DataUrodzenia = data };
            db.Aktorzy.Add(aktor);
            db.SaveChanges();
            
            
            
            

        }

        void DodajMiejsceDlaAktora(int idAktora)
        {
            WyswietlMiejsca();
            Console.WriteLine("Podaj ID miejsca które chcesz wybrać");
            int idMiejsca = int.Parse(Console.ReadLine());
            


            var query = from q in db.Miejsca
                        where q.MiejsceID == idMiejsca
                        select q;
            var query2 = from q in db.Aktorzy
                         where q.AktorID == idAktora
                         select q;
            query.First().Aktorzy.Add(query2.First());

            db.SaveChanges();
        }

        void DodajFilmDlaAktora(int idAktora)
        {
            WyswietlFilmy();
            Console.WriteLine("Podaj ID filmu które chcesz wybrać");
            int idFilmu = int.Parse(Console.ReadLine());



            var query = from q in db.Filmy
                        where q.FilmID == idFilmu
                        select q;
            var query2 = from q in db.Aktorzy
                         where q.AktorID == idAktora
                         select q;
            query.First().Obsada.Add(query2.First());

            db.SaveChanges();
        }

        public void WyswietlAktorow()
        {
            
            var query = from q in db.Aktorzy
                        select q;
            foreach (var item in query)
            {
                Console.Write("{0}, {1}, {2}, {3}", item.AktorID, item.Imie, item.Nazwisko, item.DataUrodzenia.ToShortDateString());

                Console.WriteLine();

            }

        }

       
        public void UsunAktora()
        {
            Console.WriteLine("Podaj Id aktora ktorego chcesz usunąć.");
            int id = int.Parse(Console.ReadLine());


            var query = from q in db.Aktorzy
                        where q.AktorID == id
                        select q;
            
                db.Aktorzy.Remove(query.First());
                db.SaveChanges();
            
        }

        public void EdytujAktora()
        {
            WyswietlAktorow();
            Console.WriteLine("Podaj Id aktora ktorego chcesz edytować");
            int id = int.Parse(Console.ReadLine());


            int kontrolka = 0;
            var query = from q in db.Aktorzy
                        where q.AktorID == id
                        select q;
            var obiekt = query.First();

            Console.WriteLine("1: Edytuj Imie, 2: Edytuj Nazwisko, 3: Edytuj Date urodzenia, 4: dodaj miejsce zamieszkania 5: dodaj film" );
            kontrolka = int.Parse(Console.ReadLine());
            switch (kontrolka)
            {
                case 1:
                    Console.WriteLine("Podaj noweImie");
                    obiekt.Imie = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Podaj nowe Miasto");
                    obiekt.Nazwisko = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Podaj: rok, miesiac, dzien");
                    int rok, miesiac, dzien;
                    rok = int.Parse(Console.ReadLine());
                    miesiac = int.Parse(Console.ReadLine());
                    dzien = int.Parse(Console.ReadLine());
                    DateTime data = new DateTime(rok, miesiac, dzien);
                    obiekt.DataUrodzenia = data;
                    break;
                case 4:
                    DodajMiejsceDlaAktora(id);
                    break;
                case 5:
                    DodajFilmDlaAktora(id);
                    break;
                default:
                    break;
            }
            db.SaveChanges();

        }

        public void DodajFilm()
        {
            Console.WriteLine("Podaj Tytul");
            string tytul = Console.ReadLine();
            Console.WriteLine("Podaj Gatunek");
            string gatunek = Console.ReadLine();
            Console.WriteLine("Podaj rok, miesiac i dzien wydania filmu");

            int rok, miesiac, dzien;
            rok = int.Parse(Console.ReadLine());
            miesiac = int.Parse(Console.ReadLine());
            dzien = int.Parse(Console.ReadLine());
            DateTime data = new DateTime(rok, miesiac, dzien);

            Console.WriteLine("Podaj ocene filmu.");
            int ocena = int.Parse(Console.ReadLine());

            

            
            var film = new Film { Tytul = tytul, DataWydania = data, Gatunek = gatunek, Ocena = ocena };

            db.Filmy.Add(film);
            db.SaveChanges();

        }

        public void WyswietlFilmy()
        {
            
            var query = from q in db.Filmy
                        select q;
            foreach (var item in query)
            {
                Console.Write("{0}, {1}, {2}, {3}", item.Tytul, item.DataWydania.ToShortDateString(), item.Gatunek, item.Ocena);

                Console.WriteLine();

            }

        }

        public void UsunFilm()
        {
            WyswietlFilmy();
            Console.WriteLine("Podaj Id Filmu ktorego chcesz usunąć.");
            int id = int.Parse(Console.ReadLine());


            var query = from q in db.Filmy
                        where q.FilmID == id
                        select q;

            db.Filmy.Remove(query.First());
            db.SaveChanges();

        }

        public void DodajWytwornie()
        {
            Console.WriteLine("Podaj Nazwe");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Podaj Narodowosc");
            string narodowosc = Console.ReadLine();
            
            var wytwornia = new Wytwornia { Nazwa = nazwa, Narodowosc = narodowosc };
            db.Wytwornie.Add(wytwornia);
            db.SaveChanges();

        }

        public void WyswietlWytwornie()
        {
            
            var query = from q in db.Wytwornie
                        select q;
            foreach (var item in query)
            {
                Console.Write("{0}, {1}, {2}", item.WytworniaID, item.Nazwa, item.Narodowosc);

                Console.WriteLine();

            }

        }
        public void UsunWytwornie()
        {
            Console.WriteLine("Podaj Id wytworni ktorego chcesz usunąć.");
            int id = int.Parse(Console.ReadLine());


            var query = from q in db.Wytwornie
                        where q.WytworniaID == id
                        select q;

            db.Wytwornie.Remove(query.First());
            db.SaveChanges();
        }


    }
}

