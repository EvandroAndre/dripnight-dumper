using System.Collections.Generic;
using GCommon;

namespace COW;

public class MapLayerConfigDataManager : SingletonModule<MapLayerConfigDataManager>
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public uint mapId;

		public uint modeId;

		public uint layerId;

		internal bool _003CGetRealLayerNameByMapIdAndLayerId_003Eb__0(MapLayerConfigData item)
		{
			return false;
		}

		internal bool _003CGetRealLayerNameByMapIdAndLayerId_003Eb__1(MapLayer item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public uint mapId;

		public uint modeId;

		public uint layerId;

		internal bool _003CGetActivityLabel_003Eb__0(MapLayerConfigData item)
		{
			return false;
		}

		internal bool _003CGetActivityLabel_003Eb__1(MapLayer item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public uint mapID;

		public uint modeID;

		public string layerName;

		internal bool _003CGetLayerRealNames_003Eb__0(MapLayerConfigData item)
		{
			return false;
		}

		internal bool _003CGetLayerRealNames_003Eb__1(MapLayer item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public uint mapId;

		public uint modeId;

		public uint layerId;

		internal bool _003CGetLayerByMapIdAndLayerId_003Eb__0(MapLayerConfigData item)
		{
			return false;
		}

		internal bool _003CGetLayerByMapIdAndLayerId_003Eb__1(MapLayer item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public uint mapID;

		public uint modeID;

		public string layerName;

		internal bool _003CGetLayerIDByLayerName_003Eb__0(MapLayerConfigData item)
		{
			return false;
		}

		internal bool _003CGetLayerIDByLayerName_003Eb__1(MapLayer item)
		{
			return false;
		}
	}

	public List<MapLayerConfigData> MapLayerConfigDatas;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	private void LoadConfig()
	{
	}

	public List<string> GetRealLayerNameByMapIdAndLayerId(uint mapId, uint modeId, uint layerId)
	{
		return null;
	}

	public string GetActivityLabel(uint mapId, uint modeId, uint layerId)
	{
		return null;
	}

	public List<string> GetLayerRealNames(string layerName, uint modeID, uint mapID)
	{
		return null;
	}

	public MapLayer GetLayerByMapIdAndLayerId(uint mapId, uint modeId, uint layerId)
	{
		return null;
	}

	public uint GetLayerIDByLayerName(string layerName, uint modeID, uint mapID)
	{
		return 0u;
	}
}
