using System.Collections.Generic;

namespace proto;

public class ReceivedRedEnvelope
{
	public uint boss_id;

	public string boss_name;

	public uint coins;

	public uint gems;

	public List<Item> items;

	public bool is_lucky;
}
