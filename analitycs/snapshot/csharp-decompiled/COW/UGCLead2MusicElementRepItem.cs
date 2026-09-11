using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCLead2MusicElementRepItem
{
	public const int PROP_ID_MUSICELEMENTTYPE = -115000;

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

	public UGCLead2MusicElementRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
