using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIKolHudPopWndController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__25_0;

		internal void _003CInitShareCodeGuide_003Eb__25_0()
		{
		}
	}

	private UIKolHudPopWndView m_View;

	private UIKolHudFastPreviewController m_HudFastPreviewController;

	private UIModelKolHud m_ModelKolHud;

	private UIModelSetting m_ModelSetting;

	private List<KolHudItemData> m_FilterKolItemDataList;

	private uint m_FilterTagID;

	private bool m_IsSearchEnable;

	private ulong m_SearchEndTime;

	private const int SEARCH_COOLDOWN_SEC = 3;

	private uint m_SearchCountDownCallID;

	private UIPopMenuSmallControler m_FilterCtrl;

	private List<PopMenuData> m_FilterPopDatas;

	private ulong m_SelectedAccountId;

	private uint m_SelectedHudIndex;

	private string m_SelectedHudDesc;

	private bool m_IsUseSensitivity;

	private UICommonGuideController m_GuideController;

	private List<UIHudUploadTagController> m_TagControllerList;

	private bool m_IsShowPreviewChosen;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void InitFilterNode()
	{
	}

	private void InitKolItemList()
	{
	}

	private void InitShareCodeGuide()
	{
	}

	private void RefreshKolItemList()
	{
	}

	private void OnUseSensitivityChange()
	{
	}

	private void OnSearchEntrenceClick()
	{
	}

	private void OnClickClearButton()
	{
	}

	private void OnSearchInputChanged()
	{
	}

	private void OnClickSearchButton()
	{
	}

	private void OnSearchCountDownStarted()
	{
	}

	private void OnSearchCountDownFinished()
	{
	}

	private void SearchCountDown()
	{
	}

	private void OnQuitSerachClick()
	{
	}

	private void OnFilterItemClick(object obj)
	{
	}

	private void OnFilterClick()
	{
	}

	private void OnQRCodeInputGetFocus()
	{
	}

	private void OnUseShareCode()
	{
	}

	private void HandleUseHudSettingRes(CSUseHudSettingsShareCodeRes data)
	{
	}

	public void OnQrCodeSuccess(byte[] hud_settings, string playerName, ulong player_id)
	{
	}

	public void OnSureUseQrCode(byte[] hud_settings, string playerName, ulong player_id, bool isUseSensitivity)
	{
	}

	private void OnPreviewSensivityEntranceClick()
	{
	}

	private void OnClickCUseHudButton()
	{
	}

	private void OnPreviewHudClick()
	{
	}

	private void OnClickDetailButton()
	{
	}

	private void OnClickScanQRButton()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void RefreshKolItemChosen(uint hud_index, ulong account_id)
	{
	}

	public void RefreshKolHudList(List<ulong> accountIdList, List<uint> hudIndexList)
	{
	}

	public void RefreshFastPreview(KolHudDetail itemData, ulong account_id, uint hud_index)
	{
	}

	public void RefreshShowPreviewChosen()
	{
	}

	private void _003COnUIInit_003Eb__20_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
