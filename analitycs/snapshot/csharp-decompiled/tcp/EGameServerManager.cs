namespace tcp;

public class EGameServerManager
{
	public enum Proto
	{
		Proto_NONE,
		Proto_UGC_DEBUG_START,
		Proto_UGC_DEBUG_SUSS_NTF
	}

	public enum ErrCode
	{
		ErrCode_SUSS,
		ErrCode_GAMESERVER_DEBUG_ROOMS_LIMIT
	}
}
