namespace proto;

public class MessageNotify
{
	public ulong account_id;

	public uint protocol;

	public uint ret;

	public uint cmd;

	public byte[] content;

	public object UnSerializeContent;
}
