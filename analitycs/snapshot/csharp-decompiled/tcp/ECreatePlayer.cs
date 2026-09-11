namespace tcp;

public class ECreatePlayer
{
	public enum ErrCode
	{
		ErrCode_NORMAL,
		ErrCode_NEGATIVE_GEMS,
		ErrCode_CSRANKING_BANNED,
		ErrCode_RANKING_BANNED,
		ErrCode_GROUP_BANNED,
		ErrCode_HIPPO_IN_GAMESERVER,
		ErrCode_HIPPO_BAG_CAPACITY,
		ErrCode_CS_PEAK_HACKER_BANNED
	}
}
