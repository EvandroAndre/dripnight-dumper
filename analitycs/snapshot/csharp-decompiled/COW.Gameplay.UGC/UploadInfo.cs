namespace COW.Gameplay.UGC;

public class UploadInfo
{
	private string _003CUrl_003Ek__BackingField;

	private byte[] _003CData_003Ek__BackingField;

	private string _003CHeader_003Ek__BackingField;

	public string Url
	{
		get
		{
			return _003CUrl_003Ek__BackingField;
		}
		set
		{
			_003CUrl_003Ek__BackingField = value;
		}
	}

	public byte[] Data
	{
		get
		{
			return _003CData_003Ek__BackingField;
		}
		set
		{
			_003CData_003Ek__BackingField = value;
		}
	}

	public string Header
	{
		get
		{
			return _003CHeader_003Ek__BackingField;
		}
		set
		{
			_003CHeader_003Ek__BackingField = value;
		}
	}

	public UploadInfo(string url, byte[] data, string header = null)
	{
	}
}
