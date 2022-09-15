using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1;
using static ClassLibrary1.Class1;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("1.Add by Playername 2.Remove by PlayerID 3.Get Player by ID 4.Get Player by Name 5.Get All Players");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                there:
                    OneDayTeam T = new OneDayTeam();
                    if (OneDayTeam.Oneday.Count != OneDayTeam.Oneday.Capacity)
                    {
                        Console.Write("Enter the Player Id:");
                        T.PlayerId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Player Name:");
                        T.PlayerName = Console.ReadLine();
                        Console.Write("Enter the  Player Age:");
                        T.PlayerAge = Convert.ToInt32(Console.ReadLine());

                        T.Add(T);
                    }
                    else
                    {
                        Console.WriteLine(" You cannot add players capacity is full");
                        goto Start;
                    }
                    Console.WriteLine("Do you want to continue?.Press YES");
                    string S = Console.ReadLine();
                    if (S == "YES")
                    {
                        goto there;
                    }
                    break;
                case 2:
                    OneDayTeam s = new OneDayTeam();
                    Console.Write("Enter the Player Id you want to  remove:");
                    int i = Convert.ToInt32(Console.ReadLine());
                    s.Remove(i);
                    break;
                case 3:
                    OneDayTeam s1 = new OneDayTeam();
                    Console.Write("Enter the  Player Id you want to search:");
                    int i1 = Convert.ToInt32(Console.ReadLine());
                    Player p = s1.GetPlayerById(i1);
                    Console.WriteLine($"{p.PlayerId} {p.PlayerName} {p.PlayerAge}");
                    break;
                case 4:
                    OneDayTeam s2 = new OneDayTeam();
                    Console.Write("Enter Player Name to search:");
                    string i2 = Console.ReadLine();
                    Player p1 = s2.GetPlayerByName(i2);
                    Console.WriteLine($"{p1.PlayerId} {p1.PlayerName} {p1.PlayerAge}");
                    break;
                case 5:
                    Console.WriteLine("List all players");
                    List<Player> PP = new List<Player>();
                    OneDayTeam G = new OneDayTeam();
                    PP = G.GetAllPlayers();
                    foreach (var item in PP)
                    {
                        Console.WriteLine($"{item.PlayerId} {item.PlayerName} {item.PlayerAge}");
                    }
                    break;


            }
            Console.WriteLine("Do you want to go to start? Enter YES");
            string ji = Console.ReadLine();
            if (ji == "YES")
            {
                goto Start;
            }
            Console.ReadLine();
        }

    }
    }

