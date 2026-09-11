using GCommon;
using ProtoBuf;

namespace proto;

public class TreasureBoxShowData : CSVBaseData, IMessage
{
	public int Index;

	public uint award_id;

	public bool is_preview;

	public uint preview_avatar;

	public bool is_big_reward;

	public uint award_num;

	public EInventory.AwardType award_type;

	public string icon;

	public uint reward_level;

	public bool compose_icon;

	public uint award_time;

	public bool is_preview_probability;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public static TreasureBoxShowData DeserializeOptimizedData(byte[] data, int offset)
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void ParseFrom(ProtoReader reader)
	{
	}
}
