using System;

namespace COW.GamePlay.UGCRuntime;

[Serializable]
public class U2V_LOG
{
	private string _003CGraphID_003Ek__BackingField;

	private uint _003CLogType_003Ek__BackingField;

	private string _003CContent_003Ek__BackingField;

	public string GraphID
	{
		get
		{
			return _003CGraphID_003Ek__BackingField;
		}
		set
		{
			_003CGraphID_003Ek__BackingField = value;
		}
	}

	public uint LogType
	{
		get
		{
			return _003CLogType_003Ek__BackingField;
		}
		set
		{
			_003CLogType_003Ek__BackingField = value;
		}
	}

	public string Content
	{
		get
		{
			return _003CContent_003Ek__BackingField;
		}
		set
		{
			_003CContent_003Ek__BackingField = value;
		}
	}
}
