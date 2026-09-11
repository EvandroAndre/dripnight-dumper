namespace COW.Gameplay.UGC;

public class UGCRSP_UploadListReq
{
	private int _003Cpage_003Ek__BackingField;

	private int _003Csize_003Ek__BackingField;

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
}
