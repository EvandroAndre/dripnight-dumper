using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCDrumMusicElementRepItem
{
	public const int PROP_ID_MUSICELEMENTTYPE = -113000;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnMusicElementTypeChangeEvent;

	private int _003CMusicElementType_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int MusicElementType
	{
		get
		{
			return _003CMusicElementType_003Ek__BackingField;
		}
		private set
		{
			_003CMusicElementType_003Ek__BackingField = value;
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

	public UGCDrumMusicElementRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
