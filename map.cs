/*
 * Created by SharpDevelop.
 * User: Peter
 * Date: 13/06/2012
 * Time: 2:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Pokemon_Legacy
{
	/// <summary>
	/// Description of map.
	/// </summary>
	public class map
	{
		public PokeRegion()
		{
			List<string> Region=new List<string>();
			Console.WriteLine("\nTotalRegion:{5}",Region.Capacity);
			Region.Add("Kanto");
			Region.Add("Orange Islands");
			Region.Add("Johto");
			Region.Add("Hoen");
			Region.Add("Sinoh");
			Region.Add("Unova");
		}
	}
}
