using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCHudScrollViewRepItem
{
	public const int PROP_ID_CONTENTORIGIN = -267000;

	public const int PROP_ID_SCROLLDIRECTION = -267001;

	public const int PROP_ID_CUSTOMXY = -267002;

	public const int PROP_ID_DRAGEFFECT = -267003;

	public const int PROP_ID_SCROLLWHEELFACTOR = -267004;

	public const int PROP_ID_MOMENTUMAMOUNT = -267005;

	public const int PROP_ID_RESTRICTWITHINPANEL = -267006;

	public const int PROP_ID_SMOOTHDRAGSTART = -267007;

	public const int PROP_ID_CANCELDRAGIFFITS = -267008;

	public const int PROP_ID_VERTICALBAR = -267009;

	public const int PROP_ID_HORIZONTALBAR = -267010;

	public const int PROP_ID_SHOWPOSITION = -267011;

	public const int PROP_ID_DISABLECOLLIDER = -267012;

	public const int PROP_ID_VERTICALSCROLLAMOUNT = -267013;

	public const int PROP_ID_HORIZONTALSCROLLAMOUNT = -267014;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnContentOriginChangeEvent;

	public Action<int> OnScrollDirectionChangeEvent;

	public Action<Vector2> OnCustomXYChangeEvent;

	public Action<int> OnDragEffectChangeEvent;

	public Action<float> OnScrollWheelFactorChangeEvent;

	public Action<float> OnMomentumAmountChangeEvent;

	public Action<bool> OnRestrictWithinPanelChangeEvent;

	public Action<bool> OnSmoothDragStartChangeEvent;

	public Action<bool> OnCancelDragIfFitsChangeEvent;

	public Action<int> OnVerticalBarChangeEvent;

	public Action<int> OnHorizontalBarChangeEvent;

	public Action<Vector2> OnShowPositionChangeEvent;

	public Action<bool> OnDisableColliderChangeEvent;

	public Action<float> OnVerticalScrollAmountChangeEvent;

	public Action<float> OnHorizontalScrollAmountChangeEvent;

	private int _003CContentOrigin_003Ek__BackingField;

	private int _003CScrollDirection_003Ek__BackingField;

	private Vector2 _003CCustomXY_003Ek__BackingField;

	private int _003CDragEffect_003Ek__BackingField;

	private float _003CScrollWheelFactor_003Ek__BackingField;

	private float _003CMomentumAmount_003Ek__BackingField;

	private bool _003CRestrictWithinPanel_003Ek__BackingField;

	private bool _003CSmoothDragStart_003Ek__BackingField;

	private bool _003CCancelDragIfFits_003Ek__BackingField;

	private int _003CVerticalBar_003Ek__BackingField;

	private int _003CHorizontalBar_003Ek__BackingField;

	private Vector2 _003CShowPosition_003Ek__BackingField;

	private bool _003CDisableCollider_003Ek__BackingField;

	private float _003CVerticalScrollAmount_003Ek__BackingField;

	private float _003CHorizontalScrollAmount_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int ContentOrigin
	{
		get
		{
			return _003CContentOrigin_003Ek__BackingField;
		}
		private set
		{
			_003CContentOrigin_003Ek__BackingField = value;
		}
	}

	public int ScrollDirection
	{
		get
		{
			return _003CScrollDirection_003Ek__BackingField;
		}
		private set
		{
			_003CScrollDirection_003Ek__BackingField = value;
		}
	}

	public Vector2 CustomXY
	{
		get
		{
			return _003CCustomXY_003Ek__BackingField;
		}
		private set
		{
			_003CCustomXY_003Ek__BackingField = value;
		}
	}

	public int DragEffect
	{
		get
		{
			return _003CDragEffect_003Ek__BackingField;
		}
		private set
		{
			_003CDragEffect_003Ek__BackingField = value;
		}
	}

	public float ScrollWheelFactor
	{
		get
		{
			return _003CScrollWheelFactor_003Ek__BackingField;
		}
		private set
		{
			_003CScrollWheelFactor_003Ek__BackingField = value;
		}
	}

	public float MomentumAmount
	{
		get
		{
			return _003CMomentumAmount_003Ek__BackingField;
		}
		private set
		{
			_003CMomentumAmount_003Ek__BackingField = value;
		}
	}

	public bool RestrictWithinPanel
	{
		get
		{
			return _003CRestrictWithinPanel_003Ek__BackingField;
		}
		private set
		{
			_003CRestrictWithinPanel_003Ek__BackingField = value;
		}
	}

	public bool SmoothDragStart
	{
		get
		{
			return _003CSmoothDragStart_003Ek__BackingField;
		}
		private set
		{
			_003CSmoothDragStart_003Ek__BackingField = value;
		}
	}

	public bool CancelDragIfFits
	{
		get
		{
			return _003CCancelDragIfFits_003Ek__BackingField;
		}
		private set
		{
			_003CCancelDragIfFits_003Ek__BackingField = value;
		}
	}

	public int VerticalBar
	{
		get
		{
			return _003CVerticalBar_003Ek__BackingField;
		}
		private set
		{
			_003CVerticalBar_003Ek__BackingField = value;
		}
	}

	public int HorizontalBar
	{
		get
		{
			return _003CHorizontalBar_003Ek__BackingField;
		}
		private set
		{
			_003CHorizontalBar_003Ek__BackingField = value;
		}
	}

	public Vector2 ShowPosition
	{
		get
		{
			return _003CShowPosition_003Ek__BackingField;
		}
		private set
		{
			_003CShowPosition_003Ek__BackingField = value;
		}
	}

	public bool DisableCollider
	{
		get
		{
			return _003CDisableCollider_003Ek__BackingField;
		}
		private set
		{
			_003CDisableCollider_003Ek__BackingField = value;
		}
	}

	public float VerticalScrollAmount
	{
		get
		{
			return _003CVerticalScrollAmount_003Ek__BackingField;
		}
		private set
		{
			_003CVerticalScrollAmount_003Ek__BackingField = value;
		}
	}

	public float HorizontalScrollAmount
	{
		get
		{
			return _003CHorizontalScrollAmount_003Ek__BackingField;
		}
		private set
		{
			_003CHorizontalScrollAmount_003Ek__BackingField = value;
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

	public UGCHudScrollViewRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
