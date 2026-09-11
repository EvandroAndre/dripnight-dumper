using ProtoBuf;

namespace proto;

public class OccupationSettingDesc : IMessage
{
	public bool enable;

	public bool show_enable;

	public uint show_limit_percent;

	public uint show_limit_games;

	public uint[] rank_sort_ids;

	public float[] rank_proficiency_fixs;

	public uint auto_select_level;

	public uint[] show_weapon_types;

	public uint history_save_length;

	public uint recruit_limit_scores;

	public bool elite_show_enable;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
