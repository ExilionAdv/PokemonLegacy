/*
 * Created by SharpDevelop.
 * User: Peter
 * Date: 13/06/2012
 * Time: 2:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Pokemon_Legacy
{
	class Program
	{
		public static void Main(string[] args)
		{
			DmgCalc dmg = new DmgCalc();
			int damage = dmg.HitDmg(5,4,100);
			Console.WriteLine("Hello World!");
			Console.WriteLine(damage);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}