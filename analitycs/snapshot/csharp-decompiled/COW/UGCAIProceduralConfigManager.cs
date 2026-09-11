using System.Collections.Generic;
using GCommon;

namespace COW;

public class UGCAIProceduralConfigManager : SingletonModule<UGCAIProceduralConfigManager>
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public int id;

		internal bool _003CGetThemeDataByID_003Eb__0(UGCAI_Procedural_ThemeInfo data)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public int id;

		internal bool _003CGetRaceThemeDataByID_003Eb__0(UGCAI_Procedural_Racing_Info data)
		{
			return false;
		}
	}

	private List<UGCAI_Procedural_ThemeInfo> m_ThemeDataList;

	private List<UGCAI_Procedural_Racing_Info> m_RaceThemeDataList;

	private Dictionary<int, UGCAI_Procedural_ItemTag> m_ItemDataDic;

	public int FirstCloudItemID;

	protected override void OnInit()
	{
	}

	public List<UGCAI_Procedural_ThemeInfo> GetAllThemesData()
	{
		return null;
	}

	public List<UGCAI_Procedural_Racing_Info> GetAllRaceThemesData()
	{
		return null;
	}

	public Dictionary<int, UGCAI_Procedural_ItemTag> GetAllAvailableItems()
	{
		return null;
	}

	public UGCAI_Procedural_ThemeInfo GetThemeDataByID(int id)
	{
		return null;
	}

	public UGCAI_Procedural_Racing_Info GetRaceThemeDataByID(int id)
	{
		return null;
	}

	public bool IsItemAvailable(int itemID)
	{
		return false;
	}

	protected override void OnCleanup()
	{
	}
}
