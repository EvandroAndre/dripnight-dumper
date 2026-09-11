using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditSkyBoxAttributeColorController : UIBaseController
{
	private UIHudSceneEditSkyBoxAttributeColorView m_View;

	private UIHudBlockEditColorSetterWndController m_ColorWnd;

	private Action<string> m_ValueChangeCallback;

	private string m_CurValue;

	private float m_OriginalAlpha;

	private string CurValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private Color CurColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public float OriginalAlpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void InitShowData(string title, string curValue)
	{
	}

	public void OnColorBtnClick()
	{
	}

	public void RegisetrValueChangeCallback(Action<string> callBack)
	{
	}

	private void OnLogClick()
	{
	}

	private void _003COnColorBtnClick_003Eb__18_0(Color value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
