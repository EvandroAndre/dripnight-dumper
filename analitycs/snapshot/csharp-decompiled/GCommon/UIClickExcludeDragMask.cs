using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UIClickExcludeDragMask
{
	public enum EClickExcludeDragMaskCheck
	{
		click
	}

	private Action m_Action;

	private List<Rect> m_RectRegionList;

	private Vector3 m_ClickPos;

	private bool m_IsPressing;

	private bool m_IsDragging;

	private Vector3 m_LastClickPos;

	public bool Enable;

	public UIClickExcludeDragMask(Action Action, UIWidget maskRegion)
	{
	}

	public void Destroy()
	{
	}

	private bool GetMaskPressState()
	{
		return false;
	}

	private bool IsReleasingAndNotDrag()
	{
		return false;
	}

	private bool IsClickPosInMaskRegion()
	{
		return false;
	}

	private void OnUICameraCustomInput()
	{
	}

	private Rect MaskRect(UIWidget maskWidget)
	{
		return default(Rect);
	}
}
