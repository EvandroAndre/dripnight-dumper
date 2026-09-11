using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCEffectEntityRepItem
{
	public const int PROP_ID_EFFECTTYPE = -250000;

	public const int PROP_ID_COLOR = -250001;

	public const int PROP_ID_PLAYSPEED = -250002;

	public const int PROP_ID_SHOWTEXTURE = -250003;

	public const int PROP_ID_DIFFUSEALPHA = -250004;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnEffectTypeChangeEvent;

	public Action<int> OnColorChangeEvent;

	public Action<int> OnPlaySpeedChangeEvent;

	public Action<string> OnShowTextureChangeEvent;

	private string _003CEffectType_003Ek__BackingField;

	private int _003CColor_003Ek__BackingField;

	private int _003CPlaySpeed_003Ek__BackingField;

	private string _003CShowTexture_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string EffectType
	{
		get
		{
			return _003CEffectType_003Ek__BackingField;
		}
		private set
		{
			_003CEffectType_003Ek__BackingField = value;
		}
	}

	public int Color
	{
		get
		{
			return _003CColor_003Ek__BackingField;
		}
		private set
		{
			_003CColor_003Ek__BackingField = value;
		}
	}

	public int PlaySpeed
	{
		get
		{
			return _003CPlaySpeed_003Ek__BackingField;
		}
		private set
		{
			_003CPlaySpeed_003Ek__BackingField = value;
		}
	}

	public string ShowTexture
	{
		get
		{
			return _003CShowTexture_003Ek__BackingField;
		}
		private set
		{
			_003CShowTexture_003Ek__BackingField = value;
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

	public UGCEffectEntityRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
