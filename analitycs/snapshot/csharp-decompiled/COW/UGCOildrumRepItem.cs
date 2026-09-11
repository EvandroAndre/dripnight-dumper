using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCOildrumRepItem
{
	public const int PROP_ID_DURABILITY = -150000;

	public const int PROP_ID_RADIUS = -150001;

	public const int PROP_ID_DAMAGEFAC = -150002;

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

	public UGCOildrumRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
