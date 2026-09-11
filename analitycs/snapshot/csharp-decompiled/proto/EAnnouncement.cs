namespace proto;

public class EAnnouncement
{
	public enum NavigationType
	{
		NavigationType_NONE = 0,
		NavigationType_PROFILE = 1,
		NavigationType_GROUP = 2,
		NavigationType_MALL = 3,
		NavigationType_VAULT = 4,
		NavigationType_CLAN = 5,
		NavigationType_RECHARGE = 6,
		NavigationType_ACTIVITY = 7,
		NavigationType_FRIENDS = 8,
		NavigationType_LOADOUTS = 9,
		NavigationType_SETTING = 10,
		NavigationType_TUTORIAL = 11,
		NavigationType_MONTHCARD = 12,
		NavigationType_AVATARPROFILE = 13,
		NavigationType_ELITEPASS_MAIN = 114,
		NavigationType_ELITEPASS_CHALLENGE = 214,
		NavigationType_GACHA = 15,
		NavigationType_INGAME_DROP = 23
	}

	public enum BroadcastSwitchType
	{
		BroadcastSwitchType_NONE,
		BroadcastSwitchType_MAIN,
		BroadcastSwitchType_SILENCE
	}

	public enum Platform
	{
		Platform_GENERAL,
		Platform_IOS,
		Platform_GOOGLEPLAY,
		Platform_HUAWEI,
		Platform_XIAOMI,
		Platform_TRIAL
	}

	public enum Os
	{
		Os_DEFAULT,
		Os_IOS,
		Os_ANDROID
	}

	public enum AndroidChannel
	{
		AndroidChannel_DEFAULT,
		AndroidChannel_GOOGLEPLAY,
		AndroidChannel_HUAWEI,
		AndroidChannel_XIAOMI,
		AndroidChannel_TRIAL
	}

	public enum PhoneQuality
	{
		PhoneQuality_DEFAULT,
		PhoneQuality_WHITELIST,
		PhoneQuality_HIGH,
		PhoneQuality_MID,
		PhoneQuality_LOW
	}

	public enum AboutMax
	{
		AboutMax_ALL,
		AboutMax_NOTMAX,
		AboutMax_MAX,
		AboutMax_FFI,
		AboutMax_HPE,
		AboutMax_FFVN
	}

	public enum UserType
	{
		UserType_DEFAULT,
		UserType_VETERAN
	}
}
