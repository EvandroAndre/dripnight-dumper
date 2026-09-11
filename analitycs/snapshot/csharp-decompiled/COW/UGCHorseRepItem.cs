using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCHorseRepItem
{
	public const int PROP_ID_MODEL = -471000;

	public const int PROP_ID_WALKMAXSPEEDSCALE = -471001;

	public const int PROP_ID_INWATERMAXSPEEDSCALE = -471002;

	public const int PROP_ID_HORSEJUMPHEIGHT = -471003;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnModelChangeEvent;

	public Action<float> OnWalkMaxSpeedScaleChangeEvent;

	public Action<float> OnInWaterMaxSpeedScaleChangeEvent;

	public Action<float> OnHorseJumpHeightChangeEvent;

	private int _003CModel_003Ek__BackingField;

	private float _003CWalkMaxSpeedScale_003Ek__BackingField;

	private float _003CInWaterMaxSpeedScale_003Ek__BackingField;

	private float _003CHorseJumpHeight_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int Model
	{
		get
		{
			return _003CModel_003Ek__BackingField;
		}
		private set
		{
			_003CModel_003Ek__BackingField = value;
		}
	}

	public float WalkMaxSpeedScale
	{
		get
		{
			return _003CWalkMaxSpeedScale_003Ek__BackingField;
		}
		private set
		{
			_003CWalkMaxSpeedScale_003Ek__BackingField = value;
		}
	}

	public float InWaterMaxSpeedScale
	{
		get
		{
			return _003CInWaterMaxSpeedScale_003Ek__BackingField;
		}
		private set
		{
			_003CInWaterMaxSpeedScale_003Ek__BackingField = value;
		}
	}

	public float HorseJumpHeight
	{
		get
		{
			return _003CHorseJumpHeight_003Ek__BackingField;
		}
		private set
		{
			_003CHorseJumpHeight_003Ek__BackingField = value;
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

	public UGCHorseRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
