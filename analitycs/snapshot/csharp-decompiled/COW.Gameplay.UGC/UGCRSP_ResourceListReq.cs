namespace COW.Gameplay.UGC;

public class UGCRSP_ResourceListReq
{
	private int _003Cpage_003Ek__BackingField;

	private int _003Csize_003Ek__BackingField;

	private string _003Cq_003Ek__BackingField;

	private string _003Corder_by_003Ek__BackingField;

	private ulong _003Cresource_id_003Ek__BackingField;

	private int _003Cresource_type_003Ek__BackingField;

	private int _003Ccl_category_id_003Ek__BackingField;

	private int _003Ccl_main_category_id_003Ek__BackingField;

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

	public string order_by
	{
		get
		{
			return _003Corder_by_003Ek__BackingField;
		}
		set
		{
			_003Corder_by_003Ek__BackingField = value;
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

	public int resource_type
	{
		get
		{
			return _003Cresource_type_003Ek__BackingField;
		}
		set
		{
			_003Cresource_type_003Ek__BackingField = value;
		}
	}

	public int cl_category_id
	{
		get
		{
			return _003Ccl_category_id_003Ek__BackingField;
		}
		set
		{
			_003Ccl_category_id_003Ek__BackingField = value;
		}
	}

	public int cl_main_category_id
	{
		get
		{
			return _003Ccl_main_category_id_003Ek__BackingField;
		}
		set
		{
			_003Ccl_main_category_id_003Ek__BackingField = value;
		}
	}
}
