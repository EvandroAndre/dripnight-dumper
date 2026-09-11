using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCEntityGeneratorRepItem
{
	public const int PROP_ID_COUNTEACHBATCH = -2509000;

	public const int PROP_ID_BATCHCOUNT = -2509001;

	public const int PROP_ID_CURBATCH = -2509002;

	public const int PROP_ID_BATCHINTERVAL = -2509003;

	public const int PROP_ID_LOGICENTITY = -2509004;

	public const int PROP_ID_STARTGENTIME = -2509005;

	public const int PROP_ID_ISCONTINUOUS = -2509006;

	public const int PROP_ID_BATCHINTERVALFLOAT = -2509007;

	public const int PROP_ID_TEMPLATEPREFABID = -2509008;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnTemplatePrefabIDChangeEvent;

	private string _003CTemplatePrefabID_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string TemplatePrefabID
	{
		get
		{
			return _003CTemplatePrefabID_003Ek__BackingField;
		}
		private set
		{
			_003CTemplatePrefabID_003Ek__BackingField = value;
		}
	}

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

	public UGCEntityGeneratorRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
