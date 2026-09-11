using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class UGCRSP_UploadData
{
	private ulong _003Cresource_id_003Ek__BackingField;

	private int _003Cupload_time_003Ek__BackingField;

	private string _003Cupload_uuid_003Ek__BackingField;

	private int _003Cob_version_003Ek__BackingField;

	private string _003Ccl_url_003Ek__BackingField;

	private List<UGCRSP_UploadUrl> _003Cmachine_audit_screenshots_003Ek__BackingField;

	private List<UGCRSP_UploadUrl> _003Ccl_screenshot_urls_003Ek__BackingField;

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

	public int upload_time
	{
		get
		{
			return _003Cupload_time_003Ek__BackingField;
		}
		set
		{
			_003Cupload_time_003Ek__BackingField = value;
		}
	}

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

	public List<UGCRSP_UploadUrl> machine_audit_screenshots
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

	public List<UGCRSP_UploadUrl> cl_screenshot_urls
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
}
