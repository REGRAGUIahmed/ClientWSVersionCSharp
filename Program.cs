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
			SR1.BanqueServiceClient stub = new SR1.BanqueServiceClient();
			Console.WriteLine(stub.ConversionEuroToDH(80));
			SR1.compte cp = stub.getCompte(5);
			Console.WriteLine(cp.code);
			Console.WriteLine(cp.solde);
			SR1.compte[] cmptes = stub.listCompte();
			foreach (var c in cmptes)
			{
				Console.WriteLine("-----------------------");
				Console.WriteLine(c.code);
				Console.WriteLine(c.solde);
			}
			Console.ReadLine();

		}
	}
}
