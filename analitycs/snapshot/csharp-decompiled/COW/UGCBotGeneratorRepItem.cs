using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCBotGeneratorRepItem
{
	public const int PROP_ID_COUNTEACHBATCH = -2508000;

	public const int PROP_ID_BATCHCOUNT = -2508001;

	public const int PROP_ID_ISCONTINUOUS = -2508002;

	public const int PROP_ID_CURBATCH = -2508003;

	public const int PROP_ID_BATCHINTERVAL = -2508004;

	public const int PROP_ID_AITYPE = -2508005;

	public const int PROP_ID_ENABLEDEADDROP = -2508006;

	public const int PROP_ID_STARTGENTIME = -2508007;

	public const int PROP_ID_BATCHINTERVALFLOAT = -2508008;

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

	public UGCBotGeneratorRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
