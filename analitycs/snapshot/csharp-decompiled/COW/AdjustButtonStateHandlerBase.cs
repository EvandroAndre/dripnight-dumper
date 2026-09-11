using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW;

public abstract class AdjustButtonStateHandlerBase
{
	private SceneEditItemAdjust.ButtonState _003CLogicState_003Ek__BackingField;

	protected Dictionary<ulong, UIButton> m_ButtonMaps;

	protected Dictionary<int, UISprite> m_ButtonIconMaps;

	protected GameObject m_btnRoot;

	protected GameObject m_ContainerCoordinate;

	protected UIGrid m_BtnGrid;

	private SceneEditAgent agent;

	public virtual SceneEditItemAdjust.ButtonState LogicState
	{
		get
		{
			return _003CLogicState_003Ek__BackingField;
		}
		protected set
		{
			_003CLogicState_003Ek__BackingField = value;
		}
	}

	public abstract SceneEditItemAdjust.ButtonState ModeState { get; }

	protected SceneEditAgent Agent => null;

	public virtual bool GetContainerCoordinateActive()
	{
		return false;
	}

	public abstract void RefreshResModeChanged(object[] data);

	public abstract void OnSelectedObjChanged();

	public virtual void Init(Dictionary<ulong, UIButton> buttonMaps, Dictionary<int, UISprite> iconMaps, UIGrid BtnGrid, GameObject btnRoot, GameObject containerCoordinate)
	{
	}

	public virtual void Destroy()
	{
	}

	public virtual void SetButtonActive(SceneEditItemAdjust.ButtonState flag, bool active)
	{
	}

	public virtual void SetButtonState(SceneEditItemAdjust.ButtonState buttonIdx, SceneEditItemAdjust.State state)
	{
	}

	public void RefreshGrid()
	{
	}

	public virtual void UpdateButtonStatus()
	{
	}

	public virtual void ForceRefreshAllActive()
	{
	}
}
