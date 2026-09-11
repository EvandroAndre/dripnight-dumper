using System.Collections.Generic;
using UnityEngine;
using proto;

namespace COW;

public class ProfileCustomModuleData
{
	public int Row;

	public int Col;

	public object Data;

	public ulong ExpireTime;

	public uint SerialNumber;

	public UIModelProfileCustom.EDataSource DataSource;

	public ProfileCollectionItemTemplate ItemTemplate;

	public Vector2Int CellSize;

	public int ModuleID;

	public ProfileCustomModuleData Clone()
	{
		return null;
	}

	public void SetPositionOnlyForGrid(int row, int col)
	{
	}

	private ProfileCustomModuleData()
	{
	}

	public static ProfileCustomModuleData CreateNone()
	{
		return null;
	}

	public static ProfileCustomModuleData CreateVault(CSSharedItemData data, uint serialNumber)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateLoadingCard(CSSharedItemData data, uint serialNumber)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateWeaponSkin(WeaponSkinBaseInfo data)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateAchievement(AchievementProfileItemData data)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateAchievementPoint(AchievementPointData data)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateTitle(TitleInfo data, ulong expireTime)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateLeaderBoard(RankingPlayerTitleInfo data, ulong expireTime)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateLeaderBoard(CSPeakPlayerTitleInfo data, ulong expireTime)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateLeaderBoard(WeaponPowerPlayerTitleInfo data, ulong expireTime)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateWeaponProficiency(ProfileCustomWeaponProficiencyData data)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateBigEventCollection(ProfileCustomBigEventEquippedData data)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateBP(List<BasicEPInfo> data)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateBattleCard(BattleCardStatsInfo data)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateCSPeakBattleCard(BattleCardStatsInfo data)
	{
		return null;
	}

	public static ProfileCustomModuleData CreatePrivilegeIcon(ProfileCustomPrivilegeIconData data)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateSignature(string data)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateCloseFriend(ProfileCustomCloseFriendData data)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateClanInfo(ClanInfo data)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateClanLeaderBoard(GuildWarPlayerTitleInfo data, ulong expireTime)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateClanHistoryLeaderBoard(ProfileCustomClanHistoryLeaderBoardData data)
	{
		return null;
	}

	public static ProfileCustomModuleData CreateSocialMedia(ProfileCustomSocialMediaData data)
	{
		return null;
	}
}
