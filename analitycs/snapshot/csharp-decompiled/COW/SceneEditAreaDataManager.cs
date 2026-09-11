using System.Collections.Generic;
using GCommon;

namespace COW;

public class SceneEditAreaDataManager : SingletonModule<SceneEditAreaDataManager>
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public uint areaID;

		internal bool _003CGetSceneDataByMapAndAreaID_003Eb__0(WorkShopEditAreaConfigData item)
		{
			return false;
		}
	}

	private Dictionary<uint, WorkshopSceneData> m_WorkshopMapDatas;

	private Dictionary<uint, List<WorkShopEditAreaConfigData>> m_MapCanEditAreaDic;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public bool CheckMapCanAreaEdit(uint mapID)
	{
		return false;
	}

	public bool CheckIsBigMapGlobalEdit(uint mapID, uint areaID)
	{
		return false;
	}

	public bool CheckIsBigMapAreaEdit(uint mapID, uint areaID)
	{
		return false;
	}

	public List<WorkShopEditAreaConfigData> GetMapCanEditAreas(uint mapID)
	{
		return null;
	}

	public WorkshopSceneData GetSceneDataByMapAndAreaID(uint mapID, uint areaID)
	{
		return null;
	}
}
