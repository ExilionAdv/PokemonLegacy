/*
 * Created by SharpDevelop.
 * User: Peter
 * Date: 13/06/2012
 * Time: 3:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Pokemon_Legacy
{
	//<summary>
	/// Description of BattleMech.
	///</summary>
	public class DmgCalc
	{

		public	int HitDmg(int trueDmg, int def, int acc)
		{
			Random Rand=new Random();
			int i = Rand.Next() % 100;
			int NetDmg = trueDmg-def;
			if(NetDmg<=0)
				NetDmg=1;
			if(i>acc)
			{
				NetDmg=0;
				Console.Write("The attack missed...");
			}
			return NetDmg;
		}
		
	}
}
