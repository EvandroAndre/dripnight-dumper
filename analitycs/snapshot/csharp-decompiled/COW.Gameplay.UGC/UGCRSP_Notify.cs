namespace COW.Gameplay.UGC;

public class UGCRSP_Notify
{
	private int _003Cevent_type_003Ek__BackingField;

	private string _003Cpayload_003Ek__BackingField;

	public int event_type
	{
		get
		{
			return _003Cevent_type_003Ek__BackingField;
		}
		set
		{
			_003Cevent_type_003Ek__BackingField = value;
		}
	}

	public string payload
	{
		get
		{
			return _003Cpayload_003Ek__BackingField;
		}
		set
		{
			_003Cpayload_003Ek__BackingField = value;
		}
	}
}
