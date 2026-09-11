using System;

namespace COW.OpSysExt;

public class OnlyOnUnityMainThreadAttribute : Attribute
{
	private string _003CReason_003Ek__BackingField;

	public string Reason
	{
		get
		{
			return _003CReason_003Ek__BackingField;
		}
		private set
		{
			_003CReason_003Ek__BackingField = value;
		}
	}

	public OnlyOnUnityMainThreadAttribute(string reason)
	{
	}
}
