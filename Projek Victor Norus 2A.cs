using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Czy chcesz zaczac gre?");
            bool czy = true;
            while (czy)
            {
                Console.WriteLine("Tak - a \t Nie - b");
                string inp = Console.ReadLine();
                if (inp == "a")
                {
                    Console.WriteLine("Czy masz przynajmniej 18 lat?");
                    Console.WriteLine("Tak - a \t Nie - b");
                    string inp32 = Console.ReadLine();
                    if (inp32 == "a")
                    {
                        Console.WriteLine("Supe! Zaczynajmy.");
                        czy = false;
                    }
                    else if (inp32 == "b")
                    {
                        Console.WriteLine("Idz lepiej smerfy ogladac gnoju");
                        return;
                    }
                }
                else if (inp == "b")
                {
                    Console.WriteLine("To zdecyduj sie a nie mi dupe zawracasz");
                    return;
                }
                else
                {
                    Console.WriteLine("Wlacz gre na nowo");
                    Console.WriteLine("---------------------------------------------------");
                    return;
                }
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Jest rok 2032. Wybuchla III wojna swiatowa, twoja rodzina umarla na twoich oczach podczas wybuchu bomby atomowej ty cudem przezyles. wlasciwie to dalej nie wiesz jakim cudem nie zabralo cie na druga strone. Twoim glownym celem jest wykonczyc wszystkich odpowiedzialnych za to co zrobili twojej rodznie. Ale to teraz nie wazne, jestes aktualnie przed starym domem. Jednym z nielicznych ktory zachowal sie w takim stanie. Jestes glodny i nie masz jedzenia ani picia.Wytrzymasz maksymalnie tydzien z takim stanem. Ten dom to jedyne miejsce w okolicy w ktorym moze sie cos do jedzenia ustalo. Musisz miec jednak na uwadze fakt ze jezeli dom jest w takim stanie to jest szansa ze ktos lub cos tam jeszcze jest i nie wiesz jakie ma zamiary. Wchodzisz do domu?");
                Console.WriteLine("Tak - a \t Nie - b");
                string inp1 = Console.ReadLine();
                bool czy1 = true;
                while (czy1)    
                {

                    if (inp1 == "a")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Wchodzisz do srodka");
                        czy1 = false;
                    }
                    else if (inp1 == "b")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Idziesz dalej ale glod jest tak silny ze postanawiasz wrocic");
                        czy1 = false;
                    }
                    else
                    {
                        Console.WriteLine("Musisz cos wybrac");
                        Console.WriteLine("Tak - a \t Nie - b");
                        inp1 = Console.ReadLine();
                    }
                }
                Console.WriteLine("W domu sa 4 pomiszczenia. Ktore wybierasz?");
                Console.WriteLine("Kuchnia - a \t Garaz - b \t Piwnica - c \t Strych - d");
                string inp2 = Console.ReadLine();
                bool czy2 = true;
                while (czy2)
                {

                    if (inp2 == "a")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Wchodzisz do Kuchnia");
                        Console.WriteLine("Wchodzac spostrzegasz pizze jest jeszcze ciepla. Z glodu rzucasz sie na nia. Jesz, jesz i jesz. Jako iz jestes ignoranem i niedoceniasz kunsztu pracy kucharza zostawiasz ranty");
                        Console.WriteLine("Zaczynasz się dusic, nie wiesz co sie dzieje. Przewracasz sie o kszeslo prubojac zlapac powietrze. Kiedy umierasz na podlodze caly siny spostrzegasz na lodowce napis Glodne dzieci z afrki gloduja a ty nie jesz. Pierw pomyslales ze dobrze im tak ale po tym zrozumiales ze to antidtum. Znajduje sie ono w rantach.");
                        Console.WriteLine("Podbiegles ostatkiem sil do stolu. Niestety byles za wolny, pewnie od tej pizzy. Umierasz.");
                        czy2 = false;
                    }
                    else if (inp2 == "b")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Wchodzisz do Garaz");
                        Console.WriteLine("Rozgladajac sie po garaszu zauwazyles chlopca na srodku pod lampa. Bylo cale zakrwawione w rannach i siniakach. Po chwili cos mocno stuklo z mroku za chlopcem. Wyszeptal ci tylko zaplkanym glosem wyszeptal tylko uciekaaaaj i cos go wciagnelo do mroku. Prubojac uciec zamknely sie drzwi tkore otwierales wchodzac. Z mroku wylonila sie macki ktorych igly wbijajc sie w skore wyzwalaly silne toksyny ktore na miejscu czlowieka zabijaly. ");
                        Console.WriteLine("Juz nic wiec nie zrobisz. Dosiegaja cie macki stwora. Po minucie tortur, umierasz.");
                        czy2 = false;
                    }
                    else if (inp2 == "c")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Wchodzisz do Piwnicy");
                        Console.WriteLine("W piwnicy stoi stary fortepian oraz kilkadziesiat sloikow z ogorkami");
                        Console.WriteLine("Masz niesamowia ochote wziac jeden sloik otworzyc aby sprobowac.");
                        Console.WriteLine("Gdy probiujesz odkrecic sloik na twoja reke wbiega wielki pajak upuszczasz sloik i go rozbijasz. Postanawiasz oddalic sie od  miejsca zbrodni");
                        czy2 = false;
                    }
                    else if (inp2 == "d")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Wchodzisz na Strych");
                        Console.WriteLine("Wchodzac na strych opetany stary dziad odrabal ci glowe siekiera");
                        Console.WriteLine("Wykrwawiasz sie na smierc");
                        czy2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Wybierz jeszcze raz");
                        inp2 = Console.ReadLine();
                    }
                }
                Console.WriteLine("Umierasz");
                Console.WriteLine("Koniec gry. Dziekuje za przejscie.");
                Console.WriteLine("---------------------------------------------------");;
                string inp3 = Console.ReadLine();
                bool czy3 = true;
                while (czy3)
                {

                    if (inp3 == "a")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Dziekuje i dowidzenia");
                        czy3 = false;
                    }
                    else if (inp3 == "b")
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Popraw odpoowiedz");
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Dam ci 2 szanse.");
                    }
                }

            }
            Console.ReadKey();
        }
    }
}