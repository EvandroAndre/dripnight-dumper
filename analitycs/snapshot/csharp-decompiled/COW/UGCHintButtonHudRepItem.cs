using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCHintButtonHudRepItem
{
	public const int PROP_ID_ICON = -253000;

	public const int PROP_ID_TEXT = -253001;

	public const int PROP_ID_EFFECTACTIVE = -253002;

	public const int PROP_ID_NORMALIZEDPOSITION = -253003;

	public const int PROP_ID_LOCSWITCH = -253004;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnIconChangeEvent;

	public Action<string> OnTextChangeEvent;

	public Action<bool> OnEffectActiveChangeEvent;

	public Action<Vector3> OnNormalizedPositionChangeEvent;

	public Action<bool> OnLocSwitchChangeEvent;

	private string _003CIcon_003Ek__BackingField;

	private string _003CText_003Ek__BackingField;

	private bool _003CEffectActive_003Ek__BackingField;

	private Vector3 _003CNormalizedPosition_003Ek__BackingField;

	private bool _003CLocSwitch_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string Icon
	{
		get
		{
			return _003CIcon_003Ek__BackingField;
		}
		private set
		{
			_003CIcon_003Ek__BackingField = value;
		}
	}

	public string Text
	{
		get
		{
			return _003CText_003Ek__BackingField;
		}
		private set
		{
			_003CText_003Ek__BackingField = value;
		}
	}

	public bool EffectActive
	{
		get
		{
			return _003CEffectActive_003Ek__BackingField;
		}
		private set
		{
			_003CEffectActive_003Ek__BackingField = value;
		}
	}

	public Vector3 NormalizedPosition
	{
		get
		{
			return _003CNormalizedPosition_003Ek__BackingField;
		}
		private set
		{
			_003CNormalizedPosition_003Ek__BackingField = value;
		}
	}

	public bool LocSwitch
	{
		get
		{
			return _003CLocSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CLocSwitch_003Ek__BackingField = value;
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

	public UGCHintButtonHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
