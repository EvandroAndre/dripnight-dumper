using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCPresentEffectRepItem
{
	public const int PROP_ID_EFFECTTYPE = -37000;

	public const int PROP_ID_COLOR = -37001;

	public const int PROP_ID_PRESENTEFFECTSCALE = -37002;

	public const int PROP_ID_OFFSET = -37003;

	public const int PROP_ID_FOLLOWTARGET = -37004;

	public const int PROP_ID_ROTATOR = -37005;

	public const int PROP_ID_SCALEVECTOR = -37006;

	public const int PROP_ID_PLAYSPEED = -37007;

	public const int PROP_ID_SHOWTEXTURE = -37008;

	public const int PROP_ID_DIFFUSEALPHA = -37009;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnEffectTypeChangeEvent;

	public Action<int> OnColorChangeEvent;

	public Action<float> OnPresentEffectScaleChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	public Action<string> OnFollowTargetChangeEvent;

	public Action<Vector3> OnRotatorChangeEvent;

	public Action<Vector3> OnScaleVectorChangeEvent;

	public Action<int> OnPlaySpeedChangeEvent;

	public Action<string> OnShowTextureChangeEvent;

	private string _003CEffectType_003Ek__BackingField;

	private int _003CColor_003Ek__BackingField;

	private float _003CPresentEffectScale_003Ek__BackingField;

	private Vector3 _003COffset_003Ek__BackingField;

	private string _003CFollowTarget_003Ek__BackingField;

	private Vector3 _003CRotator_003Ek__BackingField;

	private Vector3 _003CScaleVector_003Ek__BackingField;

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

	public float PresentEffectScale
	{
		get
		{
			return _003CPresentEffectScale_003Ek__BackingField;
		}
		private set
		{
			_003CPresentEffectScale_003Ek__BackingField = value;
		}
	}

	public Vector3 Offset
	{
		get
		{
			return _003COffset_003Ek__BackingField;
		}
		private set
		{
			_003COffset_003Ek__BackingField = value;
		}
	}

	public string FollowTarget
	{
		get
		{
			return _003CFollowTarget_003Ek__BackingField;
		}
		private set
		{
			_003CFollowTarget_003Ek__BackingField = value;
		}
	}

	public Vector3 Rotator
	{
		get
		{
			return _003CRotator_003Ek__BackingField;
		}
		private set
		{
			_003CRotator_003Ek__BackingField = value;
		}
	}

	public Vector3 ScaleVector
	{
		get
		{
			return _003CScaleVector_003Ek__BackingField;
		}
		private set
		{
			_003CScaleVector_003Ek__BackingField = value;
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

	public UGCPresentEffectRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
