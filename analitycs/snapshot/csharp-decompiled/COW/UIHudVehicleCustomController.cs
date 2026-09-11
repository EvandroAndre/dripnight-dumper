using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudVehicleCustomController : UIPopupWindowController
{
	public enum TweenHeightType
	{
		None,
		ExpandAdjust
	}

	private enum GrenadeSlot
	{
		One,
		Two
	}

	public enum SizeButtonType
	{
		Up,
		Right,
		Down,
		Left
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<CustomHudItem> _003C_003E9__53_0;

		internal bool _003COnConfirmButtonClick_003Eb__53_0(CustomHudItem a)
		{
			return false;
		}
	}

	private UIHudVehicleCustomView m_View;

	private CustomHudItem m_CurrentHudItem;

	private HudConfigItem m_HudConfigItem;

	private List<CustomHudItem> m_CustomHudList;

	private Dictionary<string, HudConfigItem> m_ConfigChangeList;

	private const string m_JoystickName = "HudVehicleMovingJoystick";

	private const int HEIGHT_BUTTONS = 86;

	private const int HEIGHT_ADJUST = 214;

	private const float PRESSED_INTERVAL = 0.5f;

	private float m_DefaultDragThreshold;

	private float m_CustomDragThreshold;

	private float m_DefaultMouseDragThreshold;

	private float m_CustomMouseDragThreshold;

	private UICamera m_UICamera;

	private bool m_IsDefault;

	private Dictionary<uint, UIButton> m_SizeButtons;

	private float? m_LastPressTime;

	private float m_PixelSize;

	private TweenHeightType m_TweenHeightType;

	private float pixelSize => 0f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void Update()
	{
	}

	private void CheckAndPressSizeButton()
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void OnPopupWindowListChange()
	{
	}

	public override void OnNavigationBack()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitHudCustomDragThreshold()
	{
	}

	private void InitTopPanelDropItem()
	{
	}

	private void SetHudCustomDragThreshold(bool state)
	{
	}

	private void OnArrowClicked()
	{
	}

	private void OnCloseButtonClick(int from = 214, int to = 86)
	{
	}

	private void OnExpandClicked(int from = 86, int to = 214)
	{
	}

	private void PlayMoveableLogoTween(int from, int to)
	{
	}

	private void OnSizeUpButtonClick()
	{
	}

	private void OnSizeRightButtonClick()
	{
	}

	private void OnSizeDownButtonClick()
	{
	}

	private void OnSizeLeftButtonClick()
	{
	}

	private void OnSizeButtonClickInternal(SizeButtonType sizeButtonType)
	{
	}

	private void ExpandAdjustContainer()
	{
	}

	private void RefreshAdjustContainer()
	{
	}

	private void OnHudPressed(object[] param)
	{
	}

	private void OnHudChangePosition(object[] param)
	{
	}

	private void OnHudChangePositionInternal(CustomHudItem changedItem)
	{
	}

	private void InitData(bool needPlayTweenAnim = true)
	{
	}

	private void SetAnchor(Transform transform, EUIAnchor anchor)
	{
	}

	private void ResetData()
	{
	}

	private void OnResetButtonClick()
	{
	}

	private void OnConfirmButtonClick()
	{
	}

	private void OnCancelButtonClick()
	{
	}

	private void OnSizeSliderBarChange()
	{
	}

	private void OnSizeSliderBarChangeFinished()
	{
	}

	public void OnAlphaSliderBarChange()
	{
	}

	public void OnAlphaSliderBarChangeFinished()
	{
	}

	private void UpdateSliderBar(UISlider sliderBar, UILabel label, float value)
	{
	}

	private HudConfigItem GetCurrentHudConfigTemporary(string hudName)
	{
		return null;
	}

	private void ChangeHudConfigTemporary(string hudName, HudConfigItem hudConfig, bool isdefault = false)
	{
	}

	private void OnHudChanged()
	{
	}

	private void ShowPopupMessage(string message)
	{
	}

	private void _003COnResetButtonClick_003Eb__52_0()
	{
	}

	private void _003COnCancelButtonClick_003Eb__54_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationBack()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
