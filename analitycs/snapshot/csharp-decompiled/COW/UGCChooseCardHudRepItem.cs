using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCChooseCardHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1040000;

	public const int PROP_ID_LOCSWITCH = -1040001;

	public const int PROP_ID_COUNTDOWNKEY = -1040002;

	public const int PROP_ID_COUNTDOWNTIMES = -1040003;

	public const int PROP_ID_DESCRIPTIONKEY = -1040004;

	public const int PROP_ID_DESCRIPTIONPARAMS = -1040005;

	public const int PROP_ID_ITEMBGSPRITES = -1040006;

	public const int PROP_ID_ITEMBGCOLORS = -1040007;

	public const int PROP_ID_ITEMICONSPRITES = -1040008;

	public const int PROP_ID_ITEMNAMES = -1040009;

	public const int PROP_ID_ITEMDESCS = -1040010;

	public const int PROP_ID_SELECTITEMINDEX = -1040011;

	public const int PROP_ID_BUTTONNAMES = -1040012;

	public const int PROP_ID_BUTTONCOLORS = -1040013;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<bool> OnLocSwitchChangeEvent;

	public Action<string> OnCountDownKeyChangeEvent;

	public Action<int> OnCountDownTimeSChangeEvent;

	public Action<string> OnDescriptionKeyChangeEvent;

	public Action<List<object>> OnDescriptionParamsChangeEvent;

	public Action<List<object>> OnItemBGSpritesChangeEvent;

	public Action<List<object>> OnItemBGColorsChangeEvent;

	public Action<List<object>> OnItemIconSpritesChangeEvent;

	public Action<List<object>> OnItemNamesChangeEvent;

	public Action<List<object>> OnItemDescsChangeEvent;

	public Action<int> OnSelectItemIndexChangeEvent;

	public Action<List<object>> OnButtonNamesChangeEvent;

	public Action<List<object>> OnButtonColorsChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private bool _003CLocSwitch_003Ek__BackingField;

	private string _003CCountDownKey_003Ek__BackingField;

	private int _003CCountDownTimeS_003Ek__BackingField;

	private string _003CDescriptionKey_003Ek__BackingField;

	private List<object> _003CDescriptionParams_003Ek__BackingField;

	private List<object> _003CItemBGSprites_003Ek__BackingField;

	private List<object> _003CItemBGColors_003Ek__BackingField;

	private List<object> _003CItemIconSprites_003Ek__BackingField;

	private List<object> _003CItemNames_003Ek__BackingField;

	private List<object> _003CItemDescs_003Ek__BackingField;

	private int _003CSelectItemIndex_003Ek__BackingField;

	private List<object> _003CButtonNames_003Ek__BackingField;

	private List<object> _003CButtonColors_003Ek__BackingField;

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

	public string CountDownKey
	{
		get
		{
			return _003CCountDownKey_003Ek__BackingField;
		}
		private set
		{
			_003CCountDownKey_003Ek__BackingField = value;
		}
	}

	public int CountDownTimeS
	{
		get
		{
			return _003CCountDownTimeS_003Ek__BackingField;
		}
		private set
		{
			_003CCountDownTimeS_003Ek__BackingField = value;
		}
	}

	public string DescriptionKey
	{
		get
		{
			return _003CDescriptionKey_003Ek__BackingField;
		}
		private set
		{
			_003CDescriptionKey_003Ek__BackingField = value;
		}
	}

	public List<object> DescriptionParams
	{
		get
		{
			return _003CDescriptionParams_003Ek__BackingField;
		}
		private set
		{
			_003CDescriptionParams_003Ek__BackingField = value;
		}
	}

	public List<object> ItemBGSprites
	{
		get
		{
			return _003CItemBGSprites_003Ek__BackingField;
		}
		private set
		{
			_003CItemBGSprites_003Ek__BackingField = value;
		}
	}

	public List<object> ItemBGColors
	{
		get
		{
			return _003CItemBGColors_003Ek__BackingField;
		}
		private set
		{
			_003CItemBGColors_003Ek__BackingField = value;
		}
	}

	public List<object> ItemIconSprites
	{
		get
		{
			return _003CItemIconSprites_003Ek__BackingField;
		}
		private set
		{
			_003CItemIconSprites_003Ek__BackingField = value;
		}
	}

	public List<object> ItemNames
	{
		get
		{
			return _003CItemNames_003Ek__BackingField;
		}
		private set
		{
			_003CItemNames_003Ek__BackingField = value;
		}
	}

	public List<object> ItemDescs
	{
		get
		{
			return _003CItemDescs_003Ek__BackingField;
		}
		private set
		{
			_003CItemDescs_003Ek__BackingField = value;
		}
	}

	public int SelectItemIndex
	{
		get
		{
			return _003CSelectItemIndex_003Ek__BackingField;
		}
		private set
		{
			_003CSelectItemIndex_003Ek__BackingField = value;
		}
	}

	public List<object> ButtonNames
	{
		get
		{
			return _003CButtonNames_003Ek__BackingField;
		}
		private set
		{
			_003CButtonNames_003Ek__BackingField = value;
		}
	}

	public List<object> ButtonColors
	{
		get
		{
			return _003CButtonColors_003Ek__BackingField;
		}
		private set
		{
			_003CButtonColors_003Ek__BackingField = value;
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

	public UGCChooseCardHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
