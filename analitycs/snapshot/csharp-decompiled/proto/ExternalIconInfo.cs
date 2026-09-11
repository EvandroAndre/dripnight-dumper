using ProtoBuf;

namespace proto;

public class ExternalIconInfo : IMessage
{
	public string external_icon;

	public EAccount.ExternalIconStatus status;

	public EAccount.ExternalIconShowType show_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
