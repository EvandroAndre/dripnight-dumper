namespace proto;

public class Flame25BPropDesc
{
	public enum ShowType
	{
		ShowTypeNone,
		ShowTypeSolo,
		ShowTypeGroup
	}

	public uint prop_id;

	public uint br_point;

	public uint cs_point;

	public uint br_rank_point;

	public uint cs_rank_point;

	public uint min_value;

	public uint default_game_mode;

	public string prop_name_key;

	public uint show_type;

	public bool is_mul_value;

	public bool is_need_record;

	public uint cs_peak_point;
}
