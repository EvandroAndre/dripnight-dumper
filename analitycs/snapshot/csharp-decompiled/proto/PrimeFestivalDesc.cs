using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class PrimeFestivalDesc : IMessage
{
	public uint festival_id;

	public string festival_name;

	public string festival_icon;

	public long start_time;

	public long end_time;

	public uint festival_type;

	public List<string> festival_regions;

	public uint birthday_range;

	public uint start_year;

	public uint end_year;

	public bool coming_soon;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
