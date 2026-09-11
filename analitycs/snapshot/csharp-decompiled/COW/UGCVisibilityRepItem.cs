using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCVisibilityRepItem
{
	public const int PROP_ID_VISIBLE = -170000;

	public const int PROP_ID_VISIBILITYLAYER = -170001;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnVisibleChangeEvent;

	public Action<int> OnVisibilityLayerChangeEvent;

	private bool _003CVisible_003Ek__BackingField;

	private int _003CVisibilityLayer_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool Visible
	{
		get
		{
			return _003CVisible_003Ek__BackingField;
		}
		private set
		{
			_003CVisible_003Ek__BackingField = value;
		}
	}

	public int VisibilityLayer
	{
		get
		{
			return _003CVisibilityLayer_003Ek__BackingField;
		}
		private set
		{
			_003CVisibilityLayer_003Ek__BackingField = value;
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

	public UGCVisibilityRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
