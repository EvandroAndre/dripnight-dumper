using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCCameraRayCastHudRepItem
{
	public const int PROP_ID_OPENSTATE = -277000;

	public const int PROP_ID_DISTANT = -277001;

	public const int PROP_ID_LAYERTYPE = -277002;

	public const int PROP_ID_CENTEROFFSET = -277003;

	public const int PROP_ID_ICONSPRITENAME = -277004;

	public const int PROP_ID_CLICKSIZE = -277005;

	public const int PROP_ID_SHOWHITPOINTEFFECT = -277006;

	public const int PROP_ID_HITPOINTEFFECT = -277007;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<float> OnDistantChangeEvent;

	public Action<int> OnLayerTypeChangeEvent;

	public Action<Vector2> OnCenterOffsetChangeEvent;

	public Action<string> OnIconSpriteNameChangeEvent;

	public Action<Vector2> OnClickSizeChangeEvent;

	public Action<bool> OnShowHitPointEffectChangeEvent;

	public Action<string> OnHitPointEffectChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private float _003CDistant_003Ek__BackingField;

	private int _003CLayerType_003Ek__BackingField;

	private Vector2 _003CCenterOffset_003Ek__BackingField;

	private string _003CIconSpriteName_003Ek__BackingField;

	private Vector2 _003CClickSize_003Ek__BackingField;

	private bool _003CShowHitPointEffect_003Ek__BackingField;

	private string _003CHitPointEffect_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool OpenState
	{
		get
		{
			return _003COpenState_003Ek__BackingField;
		}
		private set
		{
			_003COpenState_003Ek__BackingField = value;
		}
	}

	public float Distant
	{
		get
		{
			return _003CDistant_003Ek__BackingField;
		}
		private set
		{
			_003CDistant_003Ek__BackingField = value;
		}
	}

	public int LayerType
	{
		get
		{
			return _003CLayerType_003Ek__BackingField;
		}
		private set
		{
			_003CLayerType_003Ek__BackingField = value;
		}
	}

	public Vector2 CenterOffset
	{
		get
		{
			return _003CCenterOffset_003Ek__BackingField;
		}
		private set
		{
			_003CCenterOffset_003Ek__BackingField = value;
		}
	}

	public string IconSpriteName
	{
		get
		{
			return _003CIconSpriteName_003Ek__BackingField;
		}
		private set
		{
			_003CIconSpriteName_003Ek__BackingField = value;
		}
	}

	public Vector2 ClickSize
	{
		get
		{
			return _003CClickSize_003Ek__BackingField;
		}
		private set
		{
			_003CClickSize_003Ek__BackingField = value;
		}
	}

	public bool ShowHitPointEffect
	{
		get
		{
			return _003CShowHitPointEffect_003Ek__BackingField;
		}
		private set
		{
			_003CShowHitPointEffect_003Ek__BackingField = value;
		}
	}

	public string HitPointEffect
	{
		get
		{
			return _003CHitPointEffect_003Ek__BackingField;
		}
		private set
		{
			_003CHitPointEffect_003Ek__BackingField = value;
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

	public UGCCameraRayCastHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
