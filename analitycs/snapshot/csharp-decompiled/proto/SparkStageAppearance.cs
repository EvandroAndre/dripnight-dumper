using ProtoBuf;

namespace proto;

public class SparkStageAppearance : IMessage
{
	public uint stage_id;

	public uint[] appearance_item_ids;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
