using System.Collections.Generic;

namespace proto;

public class Diwali25BAccountInfo
{
	public class Rangoli
	{
		public uint pattern_type;

		public uint id;
	}

	public List<Rangoli> rangoli_list;

	public uint apply_rangoli_id;
}
