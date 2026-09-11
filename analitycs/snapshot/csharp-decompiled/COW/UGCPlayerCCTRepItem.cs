using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCPlayerCCTRepItem
{
	public const int PROP_ID_JUMPHEIGHT = -399000;

	public const int PROP_ID_MAXJUMPCOUNT = -399001;

	public const int PROP_ID_REMAINJUMPCOUNT = -399002;

	public const int PROP_ID_CANMOVEINAIR = -399003;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnJumpHeightChangeEvent;

	public Action<int> OnMaxJumpCountChangeEvent;

	public Action<bool> OnCanMoveInAirChangeEvent;

	private float _003CJumpHeight_003Ek__BackingField;

	private int _003CMaxJumpCount_003Ek__BackingField;

	private bool _003CCanMoveInAir_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float JumpHeight
	{
		get
		{
			return _003CJumpHeight_003Ek__BackingField;
		}
		private set
		{
			_003CJumpHeight_003Ek__BackingField = value;
		}
	}

	public int MaxJumpCount
	{
		get
		{
			return _003CMaxJumpCount_003Ek__BackingField;
		}
		private set
		{
			_003CMaxJumpCount_003Ek__BackingField = value;
		}
	}

	public bool CanMoveInAir
	{
		get
		{
			return _003CCanMoveInAir_003Ek__BackingField;
		}
		private set
		{
			_003CCanMoveInAir_003Ek__BackingField = value;
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

	public UGCPlayerCCTRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
