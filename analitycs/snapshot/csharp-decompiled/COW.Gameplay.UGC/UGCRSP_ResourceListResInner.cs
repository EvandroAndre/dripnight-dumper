using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class UGCRSP_ResourceListResInner
{
	private List<UGCRSP_ResourceData> _003Cdata_003Ek__BackingField;

	private List<ulong> _003Cai_data_003Ek__BackingField;

	public List<UGCRSP_ResourceData> data
	{
		get
		{
			return _003Cdata_003Ek__BackingField;
		}
		set
		{
			_003Cdata_003Ek__BackingField = value;
		}
	}

	public List<ulong> ai_data
	{
		get
		{
			return _003Cai_data_003Ek__BackingField;
		}
		set
		{
			_003Cai_data_003Ek__BackingField = value;
		}
	}
}
