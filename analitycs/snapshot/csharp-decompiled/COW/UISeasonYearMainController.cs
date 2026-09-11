using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UISeasonYearMainController : UINavigationController, IUIModelDataChangeObserver
{
	private uint m_SeasonYearId;

	private SeasonYearDesc m_SeasonYearDesc;

	private WebTutorialType m_WebTutorialType;

	private string m_SeasonYearTitleLabel;

	private UIModelSeasonYear m_ModelSeasonYear;

	private UIModelActivity m_ModelActivity;

	private UISeasonYearMainView m_View;

	private Dictionary<uint, Type> m_SeasonYearMainTypeDict;

	private Dictionary<uint, Type> m_SeasonYearStartPopUpDict;

	private Dictionary<uint, UISeasonYearMainBaseController> m_SeasonYearMainTypeCtrlDict;

	private UISeasonYearPopUpController m_SeasonYearChangeCtrl;

	private UISeasonYearMainBaseController m_SeasonYearMainCtrl;

	private UISeasonYearSwitchYearController m_SwitchYearCtrl;

	private uint m_PopAnimDelayCall;

	private uint m_SwitchAnimDelayCall;

	private uint m_ChangeToNewYearDelayCall;

	private bool m_IsCurSeasonYearFirstIn;

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

	protected override void OnPopupWindowListChange()
	{
	}

	public override void BeforeSharePreview()
	{
	}

	public override void AfterSharePreview()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void InitSwitchYearView()
	{
	}

	private void SetSeasonYearView(uint seasonYearId)
	{
	}

	private void OnPlayMainAnim(int animType)
	{
	}

	private void SwitchSeasonYearView(object[] data)
	{
	}

	private void SetSeasonYearMainView(uint seasonyearId)
	{
	}

	private void PlayStartAnim()
	{
	}

	private void PlaySwitchAnim(uint seasonYearId, bool isFirstIn = false)
	{
	}

	private void SetNameCDN()
	{
	}

	private void SetShareRewardView()
	{
	}

	private void OnSeasonDataBtnClick()
	{
	}

	private void OnRuleBtnClick()
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void ShowTwentySixAvatar(object[] data)
	{
	}

	private void HideTwentySixAvatar(object[] data)
	{
	}

	private void PlayMainAnim(int animType)
	{
	}

	private void SetButtonEnable()
	{
	}

	private void SetButtonState(bool enable)
	{
	}

	private void SetContentActive(bool active)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CPlaySwitchAnim_003Eb__31_0()
	{
	}

	private void _003COnShareBtnClick_003Eb__36_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeSharePreview()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterSharePreview()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
