using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICountDownController : UIBaseController
{
	public enum AlignmentType
	{
		LEFT,
		CENTER,
		RIGHT
	}

	public enum EIconType
	{
		TIME1,
		TIME2,
		Lock
	}

	private List<string> m_IconList;

	private UICountDownView m_View;

	private UILabel m_UILabel;

	private Action m_CountDownIconClickHandler;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetIconShow(bool show)
	{
	}

	public void RefreshCountDown(ulong end, string prefix = "", string suffix = "", bool formated = true, OnStarted onStarted = null, OnFinished onFinished = null, bool isStarted = true, bool shortDisplay = true)
	{
	}

	public void RefreshCountDownNew(ulong end, string prefix = "", string suffix = "", bool formated = true, OnStarted onStarted = null, OnFinished onFinished = null, bool isStarted = true, bool shortDisplay = true)
	{
	}

	public void SetIconStyle(EIconType iconType)
	{
	}

	public void SetStyle(AlignmentType alignmentType = AlignmentType.LEFT, EIconType iconType = EIconType.TIME1, UILabel.Effect labelStyle = UILabel.Effect.Shadow, bool applyGradient = false, uint gradientTop = 16777215u, uint gradientBottom = 0u)
	{
	}

	public void SetFontSize(int size)
	{
	}

	public void SetColor(Color color)
	{
	}

	public void SetLabelEffect(UILabel.Effect effectStyle)
	{
	}

	public void SetLabelEffectColor(uint color, Vector2 effectSize)
	{
	}

	public void ShowCountDownBg(bool value)
	{
	}

	public void ShowCountDownBar(bool value)
	{
	}

	public void SetLabelText(string text)
	{
	}

	public void SetLabel(string value)
	{
	}

	public UILabel GetLabel()
	{
		return null;
	}

	public void Cancel()
	{
	}

	public void SetCountDownIconClickCallback(Action callback)
	{
	}

	private void OnCountDownIconClick()
	{
	}

	public void SetDepth(int depth)
	{
	}

	public void ChangeParentWidgetWidth(int widget)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
