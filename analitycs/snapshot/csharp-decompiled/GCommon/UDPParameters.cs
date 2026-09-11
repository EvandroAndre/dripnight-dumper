using System;

namespace GCommon;

public static class UDPParameters
{
	public static int MAX_RESEND_COUNT;

	public static double RESEND_TIMEOUT;

	public static double FIRST_RESEND_TIMEOUT;

	public static double HELLO_RESEND_TIMEOUT;

	public static int HELLO_MAX_RESEND_COUNT;

	public static double MAX_RESEND_TIMEOUT;

	public static double DEFAULT_DEACTIVE_TIME;

	public static int MTU_LIMIT;

	public static int MTU_LIMIT_C2S;

	public static int UDP_HEAD_AND_ENCRY_SIZE;

	public static int MAX_SPLIT_MSG_COUNT;

	public static byte[] SECRET_KEY;

	public static int[] HEAD_SECRET;

	public static byte[] SECRET_KEY_PROXY;

	public static int[] HEAD_SECRET_PROXY;

	public static int MSG_KEY_MIN;

	public static int MSG_KEY_MID;

	public static int MSG_KEY_MAX;

	public static int JOIN_TIMEOUT;

	public static double RECONNECT_DELAY;

	public static bool RUDP_C2S_ACK_ENC_ENABLE;

	public static int MIN_RECV_SLEEP_TIME;

	public static double FLUSH_RESEND_DEACTIVVE_TIME;

	public static double FLUSH_RESEND_DELTA_TIME;

	public static double FLUSH_RESEND_INTERVAL_TIME;

	public static bool ENABLE_PACKAGE_POOL;

	public static bool ENABLE_MESSAGE_POOL;

	public static float FORCE_RECONNECT_TIMEOUT;

	public static bool ENABEL_MESSAGE_POOL_OPTIMIZATION;

	public static bool ENABLE_RUDP_FAST_RESEND;

	public static int RUDP_FAST_RESEND_TIMEOUT_MAX_STEP_COUNT;

	public static double RUDP_FAST_RESEND_TIMEOUT_STEP_INTERVAL;

	public static int UDPMESSAGE_HEADER_PROXY_SIZE;

	public static int RUDP_MAX_ACK_MASK_LEN;

	public static Random m_Random;

	public static bool IsValidMsgKey(int msgKey)
	{
		return false;
	}

	public static bool IsMsgKeyRUDP(int msgKey)
	{
		return false;
	}

	public static byte GenMsgKey(ushort cmd, byte sendOption)
	{
		return 0;
	}
}
