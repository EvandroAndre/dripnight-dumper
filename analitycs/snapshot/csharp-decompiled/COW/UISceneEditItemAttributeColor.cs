using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditItemAttributeColor : UISceneEditItemAttributeControllerBase, IUISceneEditItemAttributeRefreshView
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__13_1;

		internal void _003COnColorBtnClick_003Eb__13_1()
		{
		}
	}

	private UISceneEditItemAttributeColorView m_View;

	private UIHudBlockEditColorSetterWndController m_ColorWnd;

	private int m_CurValue;

	private int CurValue
	{
		get
		{
			return 0;
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

	public override void InitShowData(ItemEditAttributeUIData_V2 data)
	{
	}

	public void OnColorBtnClick()
	{
	}

	public void RefreshView(ItemEditAttributeUIData_V2 data)
	{
	}

	public UIWidget GetTutorialColorButtonWidget()
	{
		return null;
	}

	public void SetEditMode(UISceneEditItemAttributeEditMode mode)
	{
	}

	private void _003COnColorBtnClick_003Eb__13_0(Color value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_InitShowData(ItemEditAttributeUIData_V2 P0)
	{
	}
}
