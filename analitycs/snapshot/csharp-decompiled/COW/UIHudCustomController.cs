using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHudCustomController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private enum TweenHeightType
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

		public static Predicate<CustomHudItem> _003C_003E9__107_0;

		public static Predicate<CustomHudItem> _003C_003E9__107_1;

		public static Predicate<CustomHudItem> _003C_003E9__107_2;

		internal bool _003CSaveTemproryConfigDatas_003Eb__107_0(CustomHudItem a)
		{
			return false;
		}

		internal bool _003CSaveTemproryConfigDatas_003Eb__107_1(CustomHudItem a)
		{
			return false;
		}

		internal bool _003CSaveTemproryConfigDatas_003Eb__107_2(CustomHudItem a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass109_0
	{
		public UIHudCustomController _003C_003E4__this;

		public int index;

		internal void _003CChangePresetIndexPreCheck_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass157_0
	{
		public string hudName;

		internal bool _003CFindHudItemByName_003Eb__0(CustomHudItem item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public string name;

		internal bool _003CCheckEnableHidden_003Eb__0(string item)
		{
			return false;
		}
	}

	private Vector3 m_BottomViewDefaultPos;

	private UIHudCustomView m_View;

	private CustomHudItem m_CurrentHudItem;

	private HudConfigItem m_HudConfigItem;

	private int m_CurPresetIndex;

	private List<CustomHudItem> m_CustomHudList;

	private Dictionary<string, HudConfigItem> m_TemporaryConfigDatas;

	private List<string> m_EnableHiddenList;

	public const string ClickLogStr = "HudCustom";

	public const string UIHudGrenadeBtnName = "HudGrenadeChange";

	private const string m_LeftFireName = "HudAuxFire";

	private const string m_AuxAimName = "HudAuxAim";

	private const string m_JoystickName = "HudMovingJoystick";

	private const string m_UIHudGrenadeBtnName2 = "HudGrenadeChange2";

	private const string m_UIHudThumbUpBtnName = "HudThumbUp";

	private const string m_UIHudAge18LogoName = "HudLoginAge18";

	private const int HEIGHT_BUTTONS = 86;

	private const int HEIGHT_ADJUST = 262;

	private const int HEIGHT_ADJUST_WITH_HIDE = 300;

	private const int HEIGHT_DIRECTIONS = 341;

	private const float PRESSED_INTERVAL = 0.5f;

	private const int HEIGHT_SMART_ADJUST = 40;

	public const int HudKillNotificationWidth = 208;

	public const int HudKillNotificationHeight = 90;

	private float m_DefaultDragThreshold;

	private float m_CustomDragThreshold;

	private float m_DefaultMouseDragThreshold;

	private float m_CustomMouseDragThreshold;

	private BoxCollider m_GrenadeCollider;

	private UICamera m_UICamera;

	private EdgeDetectHudItem m_GrenadeEdgeDetect;

	private EdgeDetectHudItem m_GrenadeEdgeDetect2;

	private EdgeDetectHudItem m_Age18Logo;

	private int m_CurrentGrenadeDirection;

	private int m_CurrentGrenadeDirection2;

	private bool m_IsChangeToDefault;

	private List<Transform> m_RemainInfo;

	private List<Transform> m_Settinfo;

	private Dictionary<uint, UIButton> m_SizeButtons;

	private int pre_preset;

	private float? m_LastPressTime;

	private float m_PixelSize;

	private float m_BtnScaleMinPct;

	private float m_BtnScaleMaxPct;

	private float m_BtnAlphaMinPct;

	private float m_BtnAlphaMaxPct;

	private HudSmartAdjustHelper m_SmartAdjustHelper;

	private TweenHeightType m_TweenHeightType;

	private float pixelSize => 0f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void Update()
	{
	}

	private void UpdateWeaponSwitchHudConfig()
	{
	}

	private void CheckHudSettingBg()
	{
	}

	private void CheckAndPressSizeButton()
	{
	}

	private float ResolveAlphaMinPctFor(HudConfigItem cfg)
	{
		return 0f;
	}

	private void UpdateAlphaSliderRangeForCurrent()
	{
	}

	private void InitBtnScaleRangeConfig()
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

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
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

	private void SelectDefaultPreset()
	{
	}

	private void ChangePresetBtnClick(int index)
	{
	}

	private void OnArrowClicked()
	{
	}

	private void OnCloseButtonClick(int from = 262, int to = 86)
	{
	}

	private void OnExpandClicked(int from = 86, int to = 262)
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

	private bool CheckEnableSizeAdjust(string name)
	{
		return false;
	}

	private bool CheckEnableLeftAligned(string name)
	{
		return false;
	}

	private bool CheckEnableHudSeparated(string name)
	{
		return false;
	}

	private bool CheckEnableHidden(string name)
	{
		return false;
	}

	private void OnHudPressed(object[] param)
	{
	}

	private int GetHeightByHudItem(CustomHudItem hudItem, bool includeDescLabel = true)
	{
		return 0;
	}

	private int GetDescLabelHeight()
	{
		return 0;
	}

	private void OnCurrentHudItemChanged()
	{
	}

	private void FocusHighlight(CustomHudItem pressedItem)
	{
	}

	private void AfterCustomHudItemFocus(CustomHudItem item)
	{
	}

	private void AfterCustomHudItemLostFocus(CustomHudItem item)
	{
	}

	private void RefreshHudInteractionColliderRegion(bool focused)
	{
	}

	private void RefreshHudHoldGrenadeColliderRegion(bool focused)
	{
	}

	private void RefreshHudTeamParachuteActionColliderRegion(bool focused)
	{
	}

	private void OnHudChangePosition(object[] param)
	{
	}

	private void OnHudChangePositionInternal(CustomHudItem changedItem)
	{
	}

	private void PlayOpenTweenAnim()
	{
	}

	private void InitData()
	{
	}

	private void ChangeHudItemAnchor(string hudName, Transform uihudTrans, EUIAnchor anchor)
	{
	}

	private void ResetToDefaultConfig()
	{
	}

	public void ChangeHudConfigsTemporary(Dictionary<string, HudConfigItem> configDatas, int garenadDir, int ganenadeDir2, bool isInit = false)
	{
	}

	private void OnResetButtonClick()
	{
	}

	private void OnConfirmButtonClick()
	{
	}

	public bool SaveTemproryConfigDatas(bool skipPosCheck = false)
	{
		return false;
	}

	private void OnCancelButtonClick()
	{
	}

	private void ChangePresetIndexPreCheck(int index)
	{
	}

	public string GetCurPresetKey()
	{
		return null;
	}

	private string GetPresetKey(int index)
	{
		return null;
	}

	private void ChangePresetIndex(int index, bool showPopTips = true)
	{
	}

	private void RefreshHudLayout()
	{
	}

	private void RefreshSmartHudAdjustToggle()
	{
	}

	private void OnSizeSliderBarChange()
	{
	}

	private void OnSizeSliderBarChangeFinished()
	{
	}

	private void OnLeftAlignedToggleChanged()
	{
	}

	private void UpdateLeftAlignedToggle(UIToggle toggle, bool isLeftAligned)
	{
	}

	private void OnWeaponSeparatedToggleChanged()
	{
	}

	private void OnHiddenStatusChanged()
	{
	}

	public void OnAlphaSliderBarChange()
	{
	}

	public void OnAlphaSliderBarChangeFinished()
	{
	}

	private float SliderValueToPctValue(float sliderValue, float pctMinValue, float pctMaxValue)
	{
		return 0f;
	}

	private float PctValueToSliderValue(float pctValue, float pctMinValue, float pctMaxValue)
	{
		return 0f;
	}

	private void WriteValueToSlideBar(UISlider sliderBar, float sliderValue, UILabel label, float pctValue)
	{
	}

	private void UpdateHiddenToggle(UIToggle toggle, bool isHidden)
	{
	}

	private void UpdateHudWeaponSeparatedToggle(UIToggle toggle, bool isHudSeparated)
	{
	}

	private HudConfigItem GetOrCreateTemporaryConfigData(string hudName)
	{
		return null;
	}

	private void ChangeHudConfigTemporary(string hudName, HudConfigItem hudConfig, bool isChangeToDefalut = false)
	{
	}

	private void OnHudChanged()
	{
	}

	private void SetConfirmBtnState(bool active)
	{
	}

	private void OnGrenadeLeftBtnClicked()
	{
	}

	private void OnGrenadeRightBtnClicked()
	{
	}

	private void OnGrenadeTopBtnClicked()
	{
	}

	private void OnGrenadeBottomBtnClicked()
	{
	}

	private void SetGrenadeBtnExpandDirection(int direction)
	{
	}

	private void RefreshGrenadeBtnInteractionRegion(int direction)
	{
	}

	private CustomHudExpandDirection GetGrenadeBtnExpandContentWithDirection(int direction)
	{
		return null;
	}

	private UIToggleButton GetGrenadeChangeExpandDirectionToggleBtn(int direction)
	{
		return null;
	}

	private void PrepareGrenadeBtnComponents()
	{
	}

	private void CollapseGrenadeBtnAllDirections()
	{
	}

	private void ShowPopupMessage(string message)
	{
	}

	private bool ConfigHasChanged()
	{
		return false;
	}

	private void GenerateShareCodeBtnClick()
	{
	}

	private void OpenGenerateShareCodeWindow(string shareCode)
	{
	}

	private void OpenUseShareCodeWindow()
	{
	}

	public void SetKolViewData(KolHudDetail itemData)
	{
	}

	public void OpenKolPreviewGreyBG()
	{
	}

	private void OnClickClosePreviewButton()
	{
	}

	private void OnSmartHudAdjustToggleChanged()
	{
	}

	private void ResetToSavedConfig()
	{
	}

	private void OnSmartHudAdjustHelpBtnClicked()
	{
	}

	private void ProcessAge18Hud()
	{
	}

	private bool ShouldShowInGameAge18Logo()
	{
		return false;
	}

	private bool TryGetInGameAge18LogoUrl(out string cdnUrl)
	{
		cdnUrl = null;
		return false;
	}

	private void InitSmartAdjustHelper()
	{
	}

	private CustomHudItem FindHudItemByName(string hudName)
	{
		return null;
	}

	private Vector2 GetSavedHudLocalPosition(string hudName)
	{
		return default(Vector2);
	}

	private void OnSmartAdjustPositionApplied(string hudName, float localX, float localY)
	{
	}

	private void _003COnUIInit_003Eb__61_0()
	{
	}

	private void _003COnUIInit_003Eb__61_1()
	{
	}

	private void _003COnResetButtonClick_003Eb__105_0()
	{
	}

	private void _003COnCancelButtonClick_003Eb__108_0()
	{
	}

	private void _003CGenerateShareCodeBtnClick_003Eb__144_0()
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
