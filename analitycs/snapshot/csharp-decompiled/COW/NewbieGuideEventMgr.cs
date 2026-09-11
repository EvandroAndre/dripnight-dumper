namespace COW;

public static class NewbieGuideEventMgr
{
	public const string CommonKey = "SystemGuideKey_";

	public const string LoginDay = "First_Loign_Day";

	public const string Competion = "Competion_time";

	public const string Entrance = "RuKou";

	public const string NewRegistered = "NewRegisted_";

	public const string CompetitionKey = "CompetitionKey_";

	public const string CollectionKey = "CollectionKey_";

	public const string RankCompetitionKey = "RankCompetitionKey_";

	public const string ShopKey = "ShopKey_";

	public const string GachaKey = "GachaKey_";

	public const string ClanKey = "ClanKey_";

	public const string LoadoutKey = "LoadoutKey_";

	public const string BuildAvatarAndLoadoutKey = "BuildAvatarAndLoadoutKey_";

	public const string PetDisableBehaviourKey = "PET_DISABLE_BEHAVIOUR_GUIDE";

	public const string BuildPetAndLoadoutKey = "BuildPetAndLoadoutKey_";

	public const string LoadoutPresetKey = "LoadoutPresetKey_";

	public const string LoadoutPresetStepTwoKey = "LoadoutPresetEmptySkillGuide";

	public const string WeaponSkinCustomKey = "WeaponSkinCustomKey_";

	public const string QuickMessageGuide = "QuickMessageGuide";

	public const string GuildFirstKey = "ShowClanMainPageProgressBarGuide";

	public const string Key_Scene_Edit_UGC_Guide = "SCENE_EDIT_UGC_GUIDE";

	public static bool CheckLevelEqual(uint level)
	{
		return false;
	}

	public static bool CheckLevelOver(uint level)
	{
		return false;
	}

	public static bool CheckLevelLess(uint level)
	{
		return false;
	}

	public static bool CheckAvatarOver(int num)
	{
		return false;
	}

	public static bool CheckRedTips(NewbieGuideId newbieid, int open)
	{
		return false;
	}

	public static bool CheckLadderOver(int score)
	{
		return false;
	}

	public static bool CheckInClan(int open)
	{
		return false;
	}

	public static bool CheckfriendAccoutNum(int num)
	{
		return false;
	}

	public static bool CheckFirstDayLogin(int open)
	{
		return false;
	}

	public static bool CheckCompetitionNum(int compenum)
	{
		return false;
	}

	public static bool CheckAcccoutType(int open)
	{
		return false;
	}

	public static bool CheckClickNum(NewbieGuideId newbieid, int num)
	{
		return false;
	}

	public static bool CheckHasAvatar(uint avatarID)
	{
		return false;
	}

	public static bool CheckWeaponSkinNumOverTwo(uint weaponId)
	{
		return false;
	}

	private static int GetClickNum(NewbieGuideId newbieid)
	{
		return 0;
	}

	private static bool CheckHasRedTips(NewbieGuideId newbieid)
	{
		return false;
	}

	public static string GetRealGuideKey(NewbieGuideId newbieid)
	{
		return null;
	}

	public static bool GetOldPlayerPrefValue(NewbieGuideId newbieid)
	{
		return false;
	}
}
