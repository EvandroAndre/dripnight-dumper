using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class UGCResourceCSV : UGCResource
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public List<List<object>> data;

		internal void _003CGetCSVData_003Eb__0(bool succ, UGCResourceCSV resObj)
		{
		}
	}

	private List<List<object>> m_CSVData;

	public List<List<object>> CSVData => null;

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	public static List<List<object>> GetCSVData(string ffResNameOrUUID)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_LoadFromData(byte[] P0)
	{
		return false;
	}
}
