namespace COW.Gameplay.UGC;

public class UGCRSP_NotityAuditResult
{
	private ulong _003Cresource_id_003Ek__BackingField;

	private string _003Cresource_code_003Ek__BackingField;

	private int _003Cstatus_003Ek__BackingField;

	public ulong resource_id
	{
		get
		{
			return _003Cresource_id_003Ek__BackingField;
		}
		set
		{
			_003Cresource_id_003Ek__BackingField = value;
		}
	}

	public string resource_code
	{
		get
		{
			return _003Cresource_code_003Ek__BackingField;
		}
		set
		{
			_003Cresource_code_003Ek__BackingField = value;
		}
	}

	public int status
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
}
