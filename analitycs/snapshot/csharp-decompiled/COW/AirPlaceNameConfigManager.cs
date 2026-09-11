using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class AirPlaceNameConfigManager : SingletonModule<AirPlaceNameConfigManager>
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public int mapID;

		internal bool _003CGetConfigByMapID_003Eb__0(GILFNHENLJF e)
		{
			return false;
		}
	}

	private List<GILFNHENLJF> m_AirPlaceNameConfigs;

	private Dictionary<ResourceID, List<DLOGLJCCJPJ>> m_PlaceNameDataCache;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public GILFNHENLJF GetConfigByMapID(int mapID)
	{
		return null;
	}

	public void PreloadMapData(int mapID)
	{
	}

	public List<DLOGLJCCJPJ> GetPlaceNameDatas(ResourceID resID)
	{
		return null;
	}
}
