using tcp;

namespace GCommon;

public static class TCPParameters
{
	public delegate EAccount.Proto KickByServerMsgDeserializer(TCPMsgPacket packet);

	public static double DEFAULT_DEACTIVE_TIME;

	public static double BACKGROUND_DEACTIVE_TIME;

	public static double KEEP_ALIVE_INTERVAL_TIME;

	public static byte DEFAULT_REGION;

	public static int JOIN_TIMEOUT;

	public static byte KICK_BY_SERVER_MSG_CMD;

	public static KickByServerMsgDeserializer KICK_BY_SERVER_MSG_DESERIALIZER;

	public static EProtoDataType PROTO_DATA_TYPE;

	public static int TCP_MTU;

	public static bool ReuseStreamWriter;

	public static bool PERFRAME_HANDLE_ONEMSG;
}
