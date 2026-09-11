using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class MapLayerSpecialConfigManager : SingletonModule<MapLayerSpecialConfigManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<MapLayerSpecialConfig, uint> _003C_003E9__3_0;

		internal uint _003COnInit_003Eb__3_0(MapLayerSpecialConfig record)
		{
			return 0u;
		}
	}

	private CSVAsyncDataMap<uint, MapLayerSpecialConfig> m_Data;

	private Dictionary<uint, Dictionary<string, string>> m_MapNamePosOverrideData;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public MapLayerSpecialConfig GetConfigByMapIDAndLayerID(uint mapID, uint layerID)
	{
		return null;
	}

	public Dictionary<string, string> GetMapNamePosOverrideData(uint mapID, uint layerID)
	{
		return null;
	}
}
