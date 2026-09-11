using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class WorkshopMapFeatureData : CSVBaseData, IGetId
{
	public uint FeatureID;

	public uint ParamID;

	public string ParamName;

	public string FeatureValue;

	public bool IsOpened;

	private static Dictionary<uint, UGCRoomParamsItem> m_UGCRoomParams;

	public MHJLOKOOGNB ValueType => MHJLOKOOGNB.Object;

	public uint GetId()
	{
		return 0u;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public bool IsEqual(ModeVariable variable)
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

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
