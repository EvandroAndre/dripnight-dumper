using ProtoBuf;

namespace proto;

public class ClientStoreDesc : IMessage
{
	public bool revoke_iap_pending_switch;

	public uint revoke_iap_pending_cd;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
