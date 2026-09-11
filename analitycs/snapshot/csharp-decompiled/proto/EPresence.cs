namespace proto;

public class EPresence
{
	public enum AccountPresence
	{
		AccountPresence_NONE,
		AccountPresence_ONLINE,
		AccountPresence_INGROUP,
		AccountPresence_INGAME,
		AccountPresence_INROOM,
		AccountPresence_INTRAINING,
		AccountPresence_INSOCIALAREA,
		AccountPresence_INMATCHMAKING,
		AccountPresence_INSPECTATING
	}

	public enum AccountSocialStatus
	{
		AccountSocialStatus_NONE,
		AccountSocialStatus_OPEN_TO_GROUP,
		AccountSocialStatus_DO_NOT_DISTURB
	}

	public enum SocialPresence
	{
		AccountSocialPresence_NONE,
		AccountSocialPresence_INTRAININGISLAND,
		AccountSocialPresence_INSOCIALISLAND,
		AccountSocialPresence_INSOCIALHALL
	}

	public enum AccountCraftLandEditStatus
	{
		AccountCraftLandEditStatus_NONE,
		AccountCraftLandEditStatus_EDITING
	}
}
