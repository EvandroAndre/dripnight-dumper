using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCNPCRepItem
{
	public const int PROP_ID_TRANSFORMCLOTHINFO = -413000;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnTransformClothInfoChangeEvent;

	private string _003CTransformClothInfo_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string TransformClothInfo
	{
		get
		{
			return _003CTransformClothInfo_003Ek__BackingField;
		}
		private set
		{
			_003CTransformClothInfo_003Ek__BackingField = value;
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

	public UGCNPCRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
