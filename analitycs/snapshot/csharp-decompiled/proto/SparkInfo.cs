using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class SparkInfo : IMessage
{
	public EFriend.SparkState state;

	public uint level;

	public ulong exp;

	public uint login_streak_days;

	public uint temper;

	public uint[] appearance_item_ids;

	public uint dormant_recover_progress;

	public uint extinguished_recover_progress;

	public uint appearance_stage;

	public List<SparkStageAppearance> stage_appearance_items;

	public uint color_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
