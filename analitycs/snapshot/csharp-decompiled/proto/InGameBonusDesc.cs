using ProtoBuf;

namespace proto;

public class InGameBonusDesc : IMessage
{
	public uint id;

	public uint bonus_num;

	public string res_id;

	public string virtual_res_id;

	public string preview_res_id;

	public string bonus_icon;

	public string change_time1;

	public uint change_item_id1;

	public string change_time2;

	public uint change_item_id2;

	public string change_time3;

	public uint change_item_id3;

	public uint type;

	public string sound_res_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
