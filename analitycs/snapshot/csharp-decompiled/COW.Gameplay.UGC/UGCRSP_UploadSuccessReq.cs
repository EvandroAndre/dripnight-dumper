namespace COW.Gameplay.UGC;

public class UGCRSP_UploadSuccessReq
{
	private string _003Cupload_uuid_003Ek__BackingField;

	private ulong _003Cresource_id_003Ek__BackingField;

	private int _003Cob_version_003Ek__BackingField;

	private int _003Ccl_object_size_003Ek__BackingField;

	public string upload_uuid
	{
		get
		{
			return _003Cupload_uuid_003Ek__BackingField;
		}
		set
		{
			_003Cupload_uuid_003Ek__BackingField = value;
		}
	}

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

	public int ob_version
	{
		get
		{
			return _003Cob_version_003Ek__BackingField;
		}
		set
		{
			_003Cob_version_003Ek__BackingField = value;
		}
	}

	public int cl_object_size
	{
		get
		{
			return _003Ccl_object_size_003Ek__BackingField;
		}
		set
		{
			_003Ccl_object_size_003Ek__BackingField = value;
		}
	}
}
