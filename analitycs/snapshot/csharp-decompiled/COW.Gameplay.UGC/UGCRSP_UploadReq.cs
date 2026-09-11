using System.Collections.Generic;
using proto;

namespace COW.Gameplay.UGC;

public class UGCRSP_UploadReq
{
	private ulong _003Cresource_id_003Ek__BackingField;

	private string _003Cresource_name_003Ek__BackingField;

	private string _003Cresource_desc_003Ek__BackingField;

	private string _003Cfe_version_003Ek__BackingField;

	private int _003Cob_version_003Ek__BackingField;

	private int _003Cis_public_003Ek__BackingField;

	private int _003Cresource_type_003Ek__BackingField;

	private List<UGCRSP_Thumbnail> _003Cmachine_audit_screenshots_003Ek__BackingField;

	private List<UGCRSP_Thumbnail> _003Ccl_screenshot_urls_003Ek__BackingField;

	private int _003Ccl_main_category_id_003Ek__BackingField;

	private int _003Ccl_category_id_003Ek__BackingField;

	private List<WorkshopWordFilter> _003Cfilter_contents_003Ek__BackingField;

	private int _003Ccl_allow_recreation_003Ek__BackingField;

	private UGCRSP_UploadReference _003Creference_indicators_003Ek__BackingField;

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

	public List<UGCRSP_Thumbnail> machine_audit_screenshots
	{
		get
		{
			return _003Cmachine_audit_screenshots_003Ek__BackingField;
		}
		set
		{
			_003Cmachine_audit_screenshots_003Ek__BackingField = value;
		}
	}

	public List<UGCRSP_Thumbnail> cl_screenshot_urls
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

	public List<WorkshopWordFilter> filter_contents
	{
		get
		{
			return _003Cfilter_contents_003Ek__BackingField;
		}
		set
		{
			_003Cfilter_contents_003Ek__BackingField = value;
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

	public UGCRSP_UploadReference reference_indicators
	{
		get
		{
			return _003Creference_indicators_003Ek__BackingField;
		}
		set
		{
			_003Creference_indicators_003Ek__BackingField = value;
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
