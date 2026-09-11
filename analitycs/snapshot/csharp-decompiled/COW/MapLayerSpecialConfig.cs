using GCommon;

namespace COW;

public class MapLayerSpecialConfig : CSVBaseData
{
	public uint MapID;

	public uint LayerID;

	public bool SpecialWaiting;

	public string BRMiniMapRes;

	public string AreaNameRes;

	public string MapNamePosOverrideData;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
