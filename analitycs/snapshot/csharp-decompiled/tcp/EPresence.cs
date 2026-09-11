namespace tcp;

public class EPresence
{
	public enum Proto
	{
		Proto_NONE,
		Proto_PRESENCELIST,
		Proto_CHANGESOCIALSTATUS,
		Proto_CHANGESOCIALSTATUS_SUCCESS_NTF,
		Proto_CHANGECRAFTLANDEDITMAPSTATUS
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}

	public enum PresenceListType
	{
		PresenceListType_NONE,
		PresenceListType_FRIEND,
		PresenceListType_CLAN
	}
}
