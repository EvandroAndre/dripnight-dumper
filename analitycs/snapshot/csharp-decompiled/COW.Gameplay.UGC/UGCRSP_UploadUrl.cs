namespace COW.Gameplay.UGC;

public class UGCRSP_UploadUrl
{
	private string _003Cobject_key_003Ek__BackingField;

	private string _003Cupload_url_003Ek__BackingField;

	private string _003Ccdn_url_003Ek__BackingField;

	private int _003Cobject_size_003Ek__BackingField;

	public string object_key
	{
		get
		{
			return _003Cobject_key_003Ek__BackingField;
		}
		set
		{
			_003Cobject_key_003Ek__BackingField = value;
		}
	}

	public string upload_url
	{
		get
		{
			return _003Cupload_url_003Ek__BackingField;
		}
		set
		{
			_003Cupload_url_003Ek__BackingField = value;
		}
	}

	public string cdn_url
	{
		get
		{
			return _003Ccdn_url_003Ek__BackingField;
		}
		set
		{
			_003Ccdn_url_003Ek__BackingField = value;
		}
	}

	public int object_size
	{
		get
		{
			return _003Cobject_size_003Ek__BackingField;
		}
		set
		{
			_003Cobject_size_003Ek__BackingField = value;
		}
	}
}
