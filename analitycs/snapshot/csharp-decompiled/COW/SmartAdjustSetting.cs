using GCommon;

namespace COW;

public class SmartAdjustSetting : CSVBaseData, IGetId
{
	public string[] TrackedHudNames;

	public uint SmartHudAdjustType;

	public uint MaxDrawPointCnt;

	public float NoiseThresholdMultiplier;

	public uint MaxMatchFilesPerPreset;

	public uint MinClickCountForAdjust;

	public uint MinMatchCountForAdjust;

	public uint MaxClickRecords;

	public uint Level;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
