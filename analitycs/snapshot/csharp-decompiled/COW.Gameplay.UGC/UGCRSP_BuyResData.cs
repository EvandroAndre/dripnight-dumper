namespace COW.Gameplay.UGC;

public class UGCRSP_BuyResData
{
	private ulong _003Cresource_id_003Ek__BackingField;

	private string _003Ccl_url_003Ek__BackingField;

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

	public string cl_url
	{
		get
		{
			return _003Ccl_url_003Ek__BackingField;
		}
		set
		{
			_003Ccl_url_003Ek__BackingField = value;
		}
	}
}
