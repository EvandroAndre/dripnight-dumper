using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UIRightReigonClickMask
{
	private List<Rect> m_RectRegionList;

	private Vector3 m_ClickWorldPos;

	public Action OnClickInRightRegion;

	private bool m_OnlyOnce;

	public void OpenMask(bool onlyOnce = true)
	{
	}

	public void CloseMask()
	{
	}

	private bool GetMaskPressState()
	{
		return false;
	}

	private bool IsClickPosInRightRegion()
	{
		return false;
	}

	protected void OnUICameraCustomInput()
	{
	}

	public void AddMaskRegion(UIWidget maskRegion)
	{
	}

	private Rect MaskRect(UIWidget maskWidget)
	{
		return default(Rect);
	}
}
