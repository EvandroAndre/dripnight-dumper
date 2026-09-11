using GCommon;

namespace COW;

public class VehicleSkinData : CSVBaseData
{
	public static bool LocIdxSerialized;

	public uint nameId;

	public string PropertyDescription;

	public uint iID;

	public uint VehicleID;

	public uint sortId;

	public uint basedConfigID;

	public ResourceID previewRes;

	public ResourceID inGameRes;

	public ResourceID inGameWithEffectRes;

	public ResourceID previewAnim;

	public bool IsWithEffect;

	public uint NewMatType;

	public ResourceID HorseMoveEffect;

	public ResourceID PreviewHorseMoveEffect;

	public ResourceID OverdriveSkin;

	public ResourceID PreviewOverdriveSkin;

	public ResourceID OverdriveSkinSound2D;

	public ResourceID OverdriveSkinSound3D;

	public ResourceID HorseMoveStartSound;

	public ResourceID HorseMoveEndSound;

	public string name => null;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public bool IsNewMatType()
	{
		return false;
	}

	public override bool AfterParseData()
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public bool _003C_003EiFixBaseProxy_AfterParseData()
	{
		return false;
	}
}
