namespace COW.Gameplay.UGC;

public class UGCRSP_BuyReq
{
	private ulong _003Cresource_id_003Ek__BackingField;

	private string _003Cresource_code_003Ek__BackingField;

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
}
