using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCFootballRepItem
{
	public const int PROP_ID_RADIUS = -99000;

	public const int PROP_ID_ROLLINGFRICTIONCOEFF = -99001;

	public const int PROP_ID_ROLLINGFRICTIONCOEFF_RUSHING = -99002;

	public const int PROP_ID_SHOOTANGLEMIN = -99003;

	public const int PROP_ID_HIGHSHOOTANGLEMIN = -99004;

	public const int PROP_ID_HIDETIME = -99005;

	public const int PROP_ID_SHOOTANGLEMAX = -99006;

	public const int PROP_ID_INITPOS = -99007;

	private UGCEntityDataStore _repDataMgr;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string UGCEntityID
	{
		get
		{
			return _003CUGCEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CUGCEntityID_003Ek__BackingField = value;
		}
	}

	public UGCFootballRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
