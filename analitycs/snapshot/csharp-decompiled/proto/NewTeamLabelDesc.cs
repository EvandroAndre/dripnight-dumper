using ProtoBuf;

namespace proto;

public class NewTeamLabelDesc : IMessage
{
	public uint label_id;

	public string label_desc;

	public string label_icon;

	public bool is_default;

	public uint occupation_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
