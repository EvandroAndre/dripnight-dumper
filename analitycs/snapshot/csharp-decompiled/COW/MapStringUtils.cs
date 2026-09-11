using System.Collections.Generic;
using message;
using proto;

namespace COW;

public static class MapStringUtils
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public List<int> difficult;

		internal bool _003CGetGameModeName_003Eb__0(WorkshopUGCOpeningInfoDesc infoDesc)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public List<int> difficulty;

		internal bool _003CGetUGCCMapModeName_003Eb__0(WorkshopUGCOpeningInfoDesc infoDesc)
		{
			return false;
		}
	}

	public static string GetDownloadUseMapName(uint mapId, uint gameMode)
	{
		return null;
	}

	public static string GetMapNameByMapId(uint mapId, uint matchMode = 0u)
	{
		return null;
	}

	public static string GetModeNameByModeId(uint modeId)
	{
		return null;
	}

	public static string GetModeNameKeyByModeId(uint modeId)
	{
		return null;
	}

	public static string GetModeSelectIconByModeID(uint modeID)
	{
		return null;
	}

	public static string GetGroupNameByGroupId(uint groupdMode)
	{
		return null;
	}

	private static UGCTemplateNameConfigData GetUGCTemplateNameConfigDataData(string key)
	{
		return null;
	}

	public static string GetUGCCustomTemplateTypeNameById(int id)
	{
		return null;
	}

	public static string GetUGCCustomTemplateTypeNameKeyById(int id)
	{
		return null;
	}

	public static void GetMapSpriteByMapId(uint mapId, UISprite spirte = null)
	{
	}

	public static string GetHGDifficultyString(uint eDiff)
	{
		return null;
	}

	public static string GetClimateString(uint visiblityStyle)
	{
		return null;
	}

	public static string GetClimateSpriteByClimateType(EGameClimateType climate)
	{
		return null;
	}

	public static string GetMapModeNameByMapConfigId(uint id)
	{
		return null;
	}

	public static string GetInvitationRankModeName(uint matchMode, uint gameMode, List<int> difficultys = null)
	{
		return null;
	}

	public static string GetGameModeName(uint matchMode, uint gameMode, List<int> difficult = null, bool inGameModeMain = false)
	{
		return null;
	}

	public static string GetMapModeName(uint matchMode, uint gameMode, uint mapId, bool forceSpecifiedMapIds = false)
	{
		return null;
	}

	public static string GetUGCCMapModeName(List<int> difficulty)
	{
		return null;
	}

	public static string GetMapModeName(uint matchMode, uint gameMode, uint[] mapIds, bool forceSpecifiedMapIds = false)
	{
		return null;
	}

	public static string GetGameModeText(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode, uint rank, bool isAlive, UGCMatchStats ugcMatchStats = null, string customMapName = "", uint totalPlayerCnt = 1u, uint mapID = 0u)
	{
		return null;
	}

	public static string GetGroupModeIconSpriteName(uint groupmode)
	{
		return null;
	}

	public static bool IsValidWorkshopShareCode(string code)
	{
		return false;
	}

	public static bool IsSearchWorkshopShareCode(string code)
	{
		return false;
	}

	public static string GenWorkshopShareCode(string code, bool add)
	{
		return null;
	}

	public static string TrimAllSpace(string code)
	{
		return null;
	}

	public static string GenWorkshopNumTxt(ulong num)
	{
		return null;
	}

	public static string GenWorkshopNumTxtNoDecimal(ulong num)
	{
		return null;
	}

	public static bool MapInString(string mapSeq, uint mapId)
	{
		return false;
	}

	public static bool IsUGCMode(uint mode)
	{
		return false;
	}
}
