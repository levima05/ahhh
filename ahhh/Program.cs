using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahhh
{
	internal class Program
	{
		static void Main(string[] args)
		{
				List<int> szamok = new List<int>();

				Console.WriteLine("Számok hozzáadása (0 végjelig):");

				while (true)
				{
					Console.Write("Adjon meg egy számot: ");
					string input = Console.ReadLine();

					if (input == "0")
					{
						break;
					}

					if (int.TryParse(input, out int szam))
					{
						szamok.Add(szam);
					}
					else
					{
						Console.WriteLine("Érvénytelen szám. Kérem adjon meg egy érvényes számot.");
					}
				}

				if (szamok.Count > 0)
				{
					int legkisebbSzam = szamok.Min();
					Console.WriteLine("Legkisebb szám: " + legkisebbSzam);
				}
				else
				{
					Console.WriteLine("Nincs hozzáadott szám.");
				}

				if (szamok.Count > 0)
				{
					Console.WriteLine("Hozzáadott számok: " + string.Join(", ", szamok));
					int legnagyobbbSzam = szamok.Max();
					Console.WriteLine("Legkisebb szám: " + legnagyobbbSzam);
				}
				else
				{
					Console.WriteLine("Nincs hozzáadott szám.");
				}

			Console.ReadLine();
			}
		}

	}




