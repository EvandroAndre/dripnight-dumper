using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCVMDebugVariableQueryResult
{
	private List<string> _003CVarNameList_003Ek__BackingField;

	private List<string> _003CVarValueList_003Ek__BackingField;

	private List<sbyte> _003CVarTypeList_003Ek__BackingField;

	public List<string> VarNameList
	{
		get
		{
			return _003CVarNameList_003Ek__BackingField;
		}
		set
		{
			_003CVarNameList_003Ek__BackingField = value;
		}
	}

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
}
