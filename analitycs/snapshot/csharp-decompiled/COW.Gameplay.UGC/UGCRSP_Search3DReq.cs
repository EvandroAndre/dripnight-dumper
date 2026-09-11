namespace COW.Gameplay.UGC;

public class UGCRSP_Search3DReq
{
	private int _003Cpage_003Ek__BackingField;

	private int _003Csize_003Ek__BackingField;

	private string _003Cq_003Ek__BackingField;

	public int page
	{
		get
		{
			return _003Cpage_003Ek__BackingField;
		}
		set
		{
			_003Cpage_003Ek__BackingField = value;
		}
	}

	public int size
	{
		get
		{
			return _003Csize_003Ek__BackingField;
		}
		set
		{
			_003Csize_003Ek__BackingField = value;
		}
	}

	public string q
	{
		get
		{
			return _003Cq_003Ek__BackingField;
		}
		set
		{
			_003Cq_003Ek__BackingField = value;
		}
	}
}
