using GCommon;

namespace COW;

public class MapConfigData : CSVBaseData
{
	public const uint DEFAULT_MAP_ID = 1u;

	public uint ConfigID;

	public ResourceID[] MapConfigDepAbs;

	public const uint PRE_STUDY_MODE_ID_MIN = 230u;

	public const uint PRE_STUDY_MODE_ID_MAX = 255u;

	public string OpeningSoundID;

	public ResourceID[] ModeDepConfigResIDs;

	public string MapBgSpriteName;

	public string[] ModeDepAbFakeResArrayString;

	public string MapName;

	public float MapStartPosZ;

	public ResourceID ShowPositionResourceID;

	public ResourceID BigMapBgResourceID;

	public float MapHeight;

	public uint MapID;

	public uint LevelVisualStyle;

	public uint DownloadOptionalReDefId;

	public float MapWidth;

	public ResourceID ModeMapResourceID;

	public ResourceID mapab_tex_ref;

	public float MapStartPosX;

	public uint ModeID;

	public uint DLCDownloadOptionalReDefId;

	public ResourceID MapResourceID;

	public bool IsNoSafeZone;

	public bool IsNoJumping;

	public bool IsUseSplitMiniMap;

	public bool DisableUGCSwitchScene;

	public bool ModeNeedCheck;

	public bool IsCraftland;

	public ResourceID MapABTexRefInfoID => default(ResourceID);

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override bool AfterParseData()
	{
		return false;
	}

	public override void PostDeserializeData()
	{
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public static uint MakeConfigID(uint map_id, uint mode_id)
	{
		return 0u;
	}

	public static uint GetMapIDFromConfigID(uint configID)
	{
		return 0u;
	}

	public static uint GetModeIDFromConfigID(uint configID)
	{
		return 0u;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_AfterParseData()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
	{
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
