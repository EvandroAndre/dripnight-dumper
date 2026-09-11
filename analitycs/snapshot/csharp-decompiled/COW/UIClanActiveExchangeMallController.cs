using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIClanActiveExchangeMallController : UIPreviewNavigationController, IUIModelDataChangeObserver, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__27_0;

		internal void _003CInitToken_003Eb__27_0()
		{
		}
	}

	private sealed class _003CDelayRefreshPreviewBorder_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIClanActiveExchangeMallController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRefreshPreviewBorder_003Ed__24(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIClanActiveExchangeMallView m_View;

	private UIModelMall m_ModelMall;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIModelClan m_ModelClan;

	private UIModelInventory m_ModelInventory;

	private UIModelCollection m_ModelCollection;

	private List<ExchangeStoreItemDesc> m_ExchangeItemList;

	private ExchangeStoreItemDesc m_CurrentSelectItemDesc;

	private bool m_StoreResReadyFlag;

	private bool m_ClanInfoReadyFlag;

	private uint m_GoposId;

	private UIEasyList m_EasyList;

	private ClanDiamondAwardSettingDesc m_AwardDesc;

	private bool m_HasTopShowSelected;

	private UICountDownController m_CountDownCtrl;

	private UIBaseProfileInfoController m_BaseProfile;

	private UIClanPrivilegeSharePreviewController m_SharePreviewCtrl;

	private bool m_IsSharing;

	public uint CurrentSelectItemID => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private IEnumerator DelayRefreshPreviewBorder()
	{
		return null;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private static void GotoClanLeaderboard()
	{
	}

	private void InitToken()
	{
	}

	private void ShowGuideTokenDetailTips()
	{
	}

	private void UpdateAllUI()
	{
	}

	private int GetItemIndexById(uint id)
	{
		return 0;
	}

	private void GenerateData()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnMallItemClicked(object[] data)
	{
	}

	private void RefreshCurrentItemView(ExchangeStoreItemDesc itemDesc = null, bool refreshEasyList = false)
	{
	}

	private void HandleShowItemList(List<ExchangeStoreItemDesc> itemList)
	{
	}

	private void SortShowItemList()
	{
	}

	private int StoreItemSort(ExchangeStoreItemDesc x, ExchangeStoreItemDesc y)
	{
		return 0;
	}

	private void OnBuyBtnClick()
	{
	}

	private void OnTopShowBtnClick()
	{
	}

	private void UnselectTopShowItem()
	{
	}

	private void UnselectCurrentSelectEasyListItem()
	{
	}

	private void RefreshTopShowPreview(bool isShow)
	{
	}

	private void RefreshEquipmentBtn(object[] data)
	{
	}

	private void RefreshShareBtn()
	{
	}

	private void RefreshTopShowUI()
	{
	}

	private void OnPrivilegeHelpButtonClick()
	{
	}

	private void OnEquipBtnClick()
	{
	}

	private void OnSponsoredDetailsGotoBtnClick()
	{
	}

	private void RefreshPrivilegeIcon()
	{
	}

	private void RefreshPrivilegeEffectingTag()
	{
	}

	private void RefreshSponsorContainer()
	{
	}

	private void RefreshTopShowBuyButtonView()
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnShare()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterSharePreview()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void PreLoadShareCDN()
	{
	}

	private void _003C_003En__0(UIWidget previewBorder)
	{
	}

	private void _003CRefreshPrivilegeEffectingTag_003Eb__56_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterSharePreview()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
