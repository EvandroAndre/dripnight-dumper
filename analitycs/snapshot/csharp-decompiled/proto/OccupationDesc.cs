using ProtoBuf;

namespace proto;

public class OccupationDesc : IMessage
{
	public uint occupation_id;

	public string name;

	public string icon;

	public string desc;

	public uint[] proficiency_inherit_point_formers;

	public uint[] proficiency_inherit_point_afters;

	public uint loadout_entry_id;

	public string jump_url;

	public string share_text;

	public uint elite_level;

	public string elite_icon;

	public string elite_name;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
