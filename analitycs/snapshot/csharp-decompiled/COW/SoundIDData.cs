using System.Collections.Generic;
using GCommon;

namespace COW;

public class SoundIDData : CSVBaseData, IGetId
{
	public ResourceID SoundID;

	public float Volume;

	public ESoundType Type;

	public ResourceID ThreeDSetting;

	public int Bus;

	public static readonly Dictionary<int, ResourceID> m_ThreeDSettingMappingDict;

	public static readonly Dictionary<int, int> m_BusMappingDict;

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	private int ReadBus(string fieldName, string[] headers, string[] values)
	{
		return 0;
	}

	private ResourceID ReadThreeDSetting(string fieldName, string[] headers, string[] values)
	{
		return default(ResourceID);
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
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
}
