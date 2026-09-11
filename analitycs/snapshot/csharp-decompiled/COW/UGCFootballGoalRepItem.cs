using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCFootballGoalRepItem
{
	public const int PROP_ID_TEAM = -105000;

	public const int PROP_ID_TEAMSEQ = -105001;

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

	public UGCFootballGoalRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
