using ProtoBuf;

namespace tcp;

public class AccountOccupationData : IMessage
{
	public uint season_id;

	public uint game_mode;

	public uint occupation_id;

	public uint proficient_lv;

	public bool is_select;

	public uint match_mode;

	public uint extend_val;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
