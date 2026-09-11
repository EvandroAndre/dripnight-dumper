using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class TimelineModeButtonHandler : AdjustButtonStateHandlerBase
{
	public Vector3 AdjustNormalPosition;

	public Vector3 AdjustExpandPosition;

	private UIButton _003CScaleBtn_003Ek__BackingField;

	private UIButton _003CMoveBtn_003Ek__BackingField;

	private UIButton _003CRotateBtn_003Ek__BackingField;

	private UISprite _003CScaleIcon_003Ek__BackingField;

	private UISprite _003CMoveIcon_003Ek__BackingField;

	private UISprite _003CRotateIcon_003Ek__BackingField;

	public UIButton ScaleBtn
	{
		get
		{
			return _003CScaleBtn_003Ek__BackingField;
		}
		set
		{
			_003CScaleBtn_003Ek__BackingField = value;
		}
	}

	public UIButton MoveBtn
	{
		get
		{
			return _003CMoveBtn_003Ek__BackingField;
		}
		set
		{
			_003CMoveBtn_003Ek__BackingField = value;
		}
	}

	public UIButton RotateBtn
	{
		get
		{
			return _003CRotateBtn_003Ek__BackingField;
		}
		set
		{
			_003CRotateBtn_003Ek__BackingField = value;
		}
	}

	public UISprite ScaleIcon
	{
		get
		{
			return _003CScaleIcon_003Ek__BackingField;
		}
		set
		{
			_003CScaleIcon_003Ek__BackingField = value;
		}
	}

	public UISprite MoveIcon
	{
		get
		{
			return _003CMoveIcon_003Ek__BackingField;
		}
		set
		{
			_003CMoveIcon_003Ek__BackingField = value;
		}
	}

	public UISprite RotateIcon
	{
		get
		{
			return _003CRotateIcon_003Ek__BackingField;
		}
		set
		{
			_003CRotateIcon_003Ek__BackingField = value;
		}
	}

	public override SceneEditItemAdjust.ButtonState ModeState => SceneEditItemAdjust.ButtonState.None;

	public override SceneEditItemAdjust.ButtonState LogicState => SceneEditItemAdjust.ButtonState.None;

	public override bool GetContainerCoordinateActive()
	{
		return false;
	}

	public override void Destroy()
	{
	}

	public override void Init(Dictionary<ulong, UIButton> buttonMaps, Dictionary<int, UISprite> iconMaps, UIGrid BtnGrid, GameObject btnRoot, GameObject containerCoordinate)
	{
	}

	public void SetTimelineExpand(bool expand)
	{
	}

	public void SetTimelineSettingIcon(bool highlight)
	{
	}

	public void SetAddSutTrackIcon(bool highlight)
	{
	}

	private bool HasPropTrackAndKeyFrame(EAdjustType type)
	{
		return false;
	}

	public void RefreshTransformToolsState()
	{
	}

	public override void RefreshResModeChanged(object[] data)
	{
	}

	public override void OnSelectedObjChanged()
	{
	}

	public bool _003C_003EiFixBaseProxy_GetContainerCoordinateActive()
	{
		return false;
	}

	public SceneEditItemAdjust.ButtonState _003C_003EiFixBaseProxy_get_LogicState()
	{
		return SceneEditItemAdjust.ButtonState.None;
	}

	public void _003C_003EiFixBaseProxy_Destroy()
	{
	}

	public void _003C_003EiFixBaseProxy_Init(Dictionary<ulong, UIButton> P0, Dictionary<int, UISprite> P1, UIGrid P2, GameObject P3, GameObject P4)
	{
	}
}
