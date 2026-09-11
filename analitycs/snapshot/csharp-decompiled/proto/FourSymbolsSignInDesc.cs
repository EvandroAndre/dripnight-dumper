using System.Collections.Generic;

namespace proto;

public class FourSymbolsSignInDesc
{
	public uint id;

	public uint start_time;

	public uint end_time;

	public uint[] weight;

	public List<AwardDesc> awards;
}
