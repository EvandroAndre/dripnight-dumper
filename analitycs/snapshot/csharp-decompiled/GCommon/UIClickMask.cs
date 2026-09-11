using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UIClickMask
{
	public enum ETouchCheck
	{
		Press,
		Release
	}

	public bool IsVertical;

	private Func<bool> CanCheckAction;

	private Action m_Action;

	private UIBaseController m_TargetUI;

	private GameObject m_TargetGo;

	private List<Rect> m_RectRegionList;

	private Vector3 m_ClickWorldPos;

	private bool HideTargetUI;

	private ETouchCheck m_TouchCheck;

	public UIClickMask(Action Action, UIWidget maskRegion)
	{
	}

	public UIClickMask(UIBaseController targetUI, UIWidget maskRegion, bool isHide = false, bool isVertical = false)
	{
	}

	public UIClickMask(UIBaseController targetUI, Rect maskRect, bool hideInsteadClose)
	{
	}

	public UIClickMask(GameObject targetGo, UIWidget maskRegion)
	{
	}

	public UIClickMask(Action Action, Rect maskRect)
	{
	}

	public void SetTriggeredCallback(Action action)
	{
	}

	public void ClearMaskRegion()
	{
	}

	public void AddMaskRegion(UIWidget maskRegion)
	{
	}

	public void AddMaskRegion(Rect maskRect)
	{
	}

	public void RemoveMaskRegion(UIWidget maskRegion)
	{
	}

	public void Destroy()
	{
	}

	private bool GetMaskPressState()
	{
		return false;
	}

	private bool GetMaskReleaseState()
	{
		return false;
	}

	private bool IsClickPosInRightRegion()
	{
		return false;
	}

	public void SetCanCheckAction(Func<bool> action)
	{
	}

	private void OnUICameraCustomInput()
	{
	}

	private Rect MaskRect(UIWidget maskWidget)
	{
		return default(Rect);
	}
}
