using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCVMDebugCodeParamQueryResult
{
	private List<string> _003CVarValueList_003Ek__BackingField;

	private List<sbyte> _003CVarTypeList_003Ek__BackingField;

	private List<string> _003CVarCodeIDList_003Ek__BackingField;

	private List<string> _003CCallStackIDs_003Ek__BackingField;

	public List<string> VarValueList
	{
		get
		{
			return _003CVarValueList_003Ek__BackingField;
		}
		set
		{
			_003CVarValueList_003Ek__BackingField = value;
		}
	}

	public List<sbyte> VarTypeList
	{
		get
		{
			return _003CVarTypeList_003Ek__BackingField;
		}
		set
		{
			_003CVarTypeList_003Ek__BackingField = value;
		}
	}

	public List<string> VarCodeIDList
	{
		get
		{
			return _003CVarCodeIDList_003Ek__BackingField;
		}
		set
		{
			_003CVarCodeIDList_003Ek__BackingField = value;
		}
	}

	public List<string> CallStackIDs
	{
		get
		{
			return _003CCallStackIDs_003Ek__BackingField;
		}
		set
		{
			_003CCallStackIDs_003Ek__BackingField = value;
		}
	}
}
