namespace tcp;

public class EWorkshop
{
	public enum Proto
	{
		Proto_NONE,
		Proto_FREE_ROOM_TIMES_CHANGE_NTF,
		Proto_SUBMIT_WORKSHOP_MATCHSTATS_NTF,
		Proto_SLOT_REVIEWING_FINISHED,
		Proto_VIP_UPDATE,
		Proto_RESOURCE_STORE
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}
}
