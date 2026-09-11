using ProtoBuf;

namespace tcp;

public class ExternalIconInfo : IMessage
{
	public string external_icon;

	public EExternalIcon.Status status;

	public EExternalIcon.ShowType show_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
