using System.Collections.Generic;
using proto;

namespace COW.Gameplay.UGC;

public class UGCRSP_ResourceData
{
	private ulong _003Cresource_id_003Ek__BackingField;

	private ulong _003Caccount_id_003Ek__BackingField;

	private string _003Cregion_003Ek__BackingField;

	private string _003Cresource_name_003Ek__BackingField;

	private int _003Cob_version_003Ek__BackingField;

	private string _003Cfe_version_003Ek__BackingField;

	private int _003Cstatus_003Ek__BackingField;

	private string _003Cresource_desc_003Ek__BackingField;

	private int _003Cupdate_time_003Ek__BackingField;

	private int _003Ccl_category_id_003Ek__BackingField;

	private int _003Ccl_main_category_id_003Ek__BackingField;

	private int _003Cis_public_003Ek__BackingField;

	private List<string> _003Ccl_screenshot_urls_003Ek__BackingField;

	private int _003Cresource_type_003Ek__BackingField;

	private string _003Cresource_code_003Ek__BackingField;

	private WorkshopReviewResult _003Creview_result_003Ek__BackingField;

	private ulong _003Cbuy_count_003Ek__BackingField;

	private int _003Ccl_allow_recreation_003Ek__BackingField;

	private int _003Ceditor_type_003Ek__BackingField;

	private int _003Cis_buy_003Ek__BackingField;

	private string _003Ccl_url_003Ek__BackingField;

	private ulong _003Clike_count_003Ek__BackingField;

	private uint _003Cperformance_cost_003Ek__BackingField;

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

	public ulong account_id
	{
		get
		{
			return _003Caccount_id_003Ek__BackingField;
		}
		set
		{
			_003Caccount_id_003Ek__BackingField = value;
		}
	}

	public string region
	{
		get
		{
			return _003Cregion_003Ek__BackingField;
		}
		set
		{
			_003Cregion_003Ek__BackingField = value;
		}
	}

	public string resource_name
	{
		get
		{
			return _003Cresource_name_003Ek__BackingField;
		}
		set
		{
			_003Cresource_name_003Ek__BackingField = value;
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

	public string fe_version
	{
		get
		{
			return _003Cfe_version_003Ek__BackingField;
		}
		set
		{
			_003Cfe_version_003Ek__BackingField = value;
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

	public string resource_desc
	{
		get
		{
			return _003Cresource_desc_003Ek__BackingField;
		}
		set
		{
			_003Cresource_desc_003Ek__BackingField = value;
		}
	}

	public int update_time
	{
		get
		{
			return _003Cupdate_time_003Ek__BackingField;
		}
		set
		{
			_003Cupdate_time_003Ek__BackingField = value;
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

	public int is_public
	{
		get
		{
			return _003Cis_public_003Ek__BackingField;
		}
		set
		{
			_003Cis_public_003Ek__BackingField = value;
		}
	}

	public List<string> cl_screenshot_urls
	{
		get
		{
			return _003Ccl_screenshot_urls_003Ek__BackingField;
		}
		set
		{
			_003Ccl_screenshot_urls_003Ek__BackingField = value;
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

	public WorkshopReviewResult review_result
	{
		get
		{
			return _003Creview_result_003Ek__BackingField;
		}
		set
		{
			_003Creview_result_003Ek__BackingField = value;
		}
	}

	public ulong buy_count
	{
		get
		{
			return _003Cbuy_count_003Ek__BackingField;
		}
		set
		{
			_003Cbuy_count_003Ek__BackingField = value;
		}
	}

	public int cl_allow_recreation
	{
		get
		{
			return _003Ccl_allow_recreation_003Ek__BackingField;
		}
		set
		{
			_003Ccl_allow_recreation_003Ek__BackingField = value;
		}
	}

	public int editor_type
	{
		get
		{
			return _003Ceditor_type_003Ek__BackingField;
		}
		set
		{
			_003Ceditor_type_003Ek__BackingField = value;
		}
	}

	public int is_buy
	{
		get
		{
			return _003Cis_buy_003Ek__BackingField;
		}
		set
		{
			_003Cis_buy_003Ek__BackingField = value;
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

	public ulong like_count
	{
		get
		{
			return _003Clike_count_003Ek__BackingField;
		}
		set
		{
			_003Clike_count_003Ek__BackingField = value;
		}
	}

	public uint performance_cost
	{
		get
		{
			return _003Cperformance_cost_003Ek__BackingField;
		}
		set
		{
			_003Cperformance_cost_003Ek__BackingField = value;
		}
	}
}
