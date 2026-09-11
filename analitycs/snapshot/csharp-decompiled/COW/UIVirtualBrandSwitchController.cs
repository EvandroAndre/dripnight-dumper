using System;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIVirtualBrandSwitchController : UIBaseController
{
	public enum LastAnim
	{
		NONE,
		LEFT,
		RIGHT
	}

	private UIVirtualBrandSwitchView m_View;

	private UIModelVirtualBrand m_Model;

	private uint m_PreBrand;

	private uint m_NextBrand;

	private Action<uint> m_LeftBtnCallBack;

	private Action<uint> m_RightBtnCallBack;

	private const uint CLICK_COOLDOWN_SECONDS = 2u;

	private const float m_ClickDelayCall = 0.5f;

	private const string LEFT_ANIM = "UIVirtualBrandSwitch_Switch_Left";

	private const string RIGHT_ANIM = "UIVirtualBrandSwitch_Switch_Right";

	private ulong m_LastClickTimeStamp;

	private Animation m_Ani;

	private LastAnim m_LastAnim;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint brandID)
	{
	}

	private void OnLeftBtnClick()
	{
	}

	private void OnRightBtnClick()
	{
	}

	public void SetLeftCallBack(Action<uint> func)
	{
	}

	public void SetRightCallBack(Action<uint> func)
	{
	}

	public void ResetAnim()
	{
	}

	private void _003COnLeftBtnClick_003Eb__17_0()
	{
	}

	private void _003COnRightBtnClick_003Eb__18_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
