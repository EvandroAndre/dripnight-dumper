namespace COW.Gameplay.UGC;

public class UGCRSP_PersonalInfoRes
{
	private string _003Cstatus_003Ek__BackingField;

	private string _003Cmsg_003Ek__BackingField;

	private UGCRSP_PersonalInfoResInner _003Cdata_003Ek__BackingField;

	private int _003Ccode_003Ek__BackingField;

	public string status
	{
		get
		{
			return _003Cstatus_003Ek__BackingField;
		}
		set
		{
			_003Cstatus_003Ek__BackingField = value;
		}
	}

	public string msg
	{
		get
		{
			return _003Cmsg_003Ek__BackingField;
		}
		set
		{
			_003Cmsg_003Ek__BackingField = value;
		}
	}

	public UGCRSP_PersonalInfoResInner data
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

	public int code
	{
		get
		{
			return _003Ccode_003Ek__BackingField;
		}
		set
		{
			_003Ccode_003Ek__BackingField = value;
		}
	}
}
