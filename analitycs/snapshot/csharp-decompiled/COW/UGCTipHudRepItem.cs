using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCTipHudRepItem
{
	public const int PROP_ID_BACKGROUND = -259000;

	public const int PROP_ID_TEXT = -259001;

	public const int PROP_ID_NORMALIZEDPOSITION = -259002;

	public const int PROP_ID_LOCSWITCH = -259003;

	public const int PROP_ID_TEXTCOLOR = -259004;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnBackgroundChangeEvent;

	public Action<string> OnTextChangeEvent;

	public Action<Vector3> OnNormalizedPositionChangeEvent;

	public Action<bool> OnLocSwitchChangeEvent;

	public Action<int> OnTextColorChangeEvent;

	private string _003CBackground_003Ek__BackingField;

	private string _003CText_003Ek__BackingField;

	private Vector3 _003CNormalizedPosition_003Ek__BackingField;

	private bool _003CLocSwitch_003Ek__BackingField;

	private int _003CTextColor_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string Background
	{
		get
		{
			return _003CBackground_003Ek__BackingField;
		}
		private set
		{
			_003CBackground_003Ek__BackingField = value;
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

	public int TextColor
	{
		get
		{
			return _003CTextColor_003Ek__BackingField;
		}
		private set
		{
			_003CTextColor_003Ek__BackingField = value;
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

	public UGCTipHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
