using System;

namespace COW.OpSysExt;

public class SafeOnAnyThreadAttribute : Attribute
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

	public SafeOnAnyThreadAttribute(string reason)
	{
	}
}
