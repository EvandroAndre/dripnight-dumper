using ProtoBuf;

namespace tcp;

public class MatchClientInfo : IMessage
{
	public string tpsdk_str;

	public uint start_time;

	public byte[] file_exception;

	public byte[] lib_result;

	public uint exception_count;

	public uint scan_count;

	public byte[] native_result;

	public string client_version;

	public uint channel_type;

	public uint architecture_type;

	public byte[] gin_check_data;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
