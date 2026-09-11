using ProtoBuf;

namespace proto;

public class AIAssistantSuggestedQuestionsTableDesc : IMessage
{
	public uint id;

	public uint scene_id;

	public string input;

	public string note;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
