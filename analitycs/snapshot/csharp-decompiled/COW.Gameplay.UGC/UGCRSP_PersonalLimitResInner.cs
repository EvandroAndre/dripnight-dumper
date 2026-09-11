namespace COW.Gameplay.UGC;

public class UGCRSP_PersonalLimitResInner
{
	private uint _003Cfree_resource_limit_003Ek__BackingField;

	private uint _003Ctotal_upload_limit_003Ek__BackingField;

	private uint _003Cmax_concurrent_upload_003Ek__BackingField;

	private ulong _003Cupload_unlock_time_003Ek__BackingField;

	public uint free_resource_limit
	{
		get
		{
			return _003Cfree_resource_limit_003Ek__BackingField;
		}
		set
		{
			_003Cfree_resource_limit_003Ek__BackingField = value;
		}
	}

	public uint total_upload_limit
	{
		get
		{
			return _003Ctotal_upload_limit_003Ek__BackingField;
		}
		set
		{
			_003Ctotal_upload_limit_003Ek__BackingField = value;
		}
	}

	public uint max_concurrent_upload
	{
		get
		{
			return _003Cmax_concurrent_upload_003Ek__BackingField;
		}
		set
		{
			_003Cmax_concurrent_upload_003Ek__BackingField = value;
		}
	}

	public ulong upload_unlock_time
	{
		get
		{
			return _003Cupload_unlock_time_003Ek__BackingField;
		}
		set
		{
			_003Cupload_unlock_time_003Ek__BackingField = value;
		}
	}
}
