using ProtoBuf;

namespace proto;

public class AgePolicyPreCheckDesc : IMessage
{
	public string region;

	public string ip;

	public string minor_policy;

	public uint minimum_version_ios;

	public uint minimum_version_andriod;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
