using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UILuckyBuffBattleController : UIPreviewPopUpWindowController, IUIModelDataChangeObserver, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public uint lastItemId;

		internal bool _003CRefreshFriendlyShopAndItemCurrency_003Eb__0(ExchangeStoreItemDesc item)
		{
			return false;
		}
	}

	private UILuckyBuffBattleView m_View;

	private UIModelPreVeteran m_Model;

	private UIModelMall m_ModelMall;

	private UIModelAvatar m_ModelAvatar;

	private UIModelInventory m_ModelInventory;

	private List<ExchangeStoreItemDesc> m_CurrentDataList;

	private uint m_TeamUpTokenId;

	private uint m_CurrentSelectedItem;

	private readonly string m_AutoAutoRecruitKey;

	private bool m_IsExchangePurchaseSuccess;

	private uint m_LastItemId;

	public uint CurrentSelectedItem
	{
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

	public void RequestTeamUpBufDesc()
	{
	}

	private bool IsEnableRegion()
	{
		return false;
	}

	private void InitToggle()
	{
	}

	private void InitTeamUpTokenId()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void SetBG(AdType adType)
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnRecruitBtnClick()
	{
	}

	private void UpdateFriendlyShopData()
	{
	}

	private void RefreshViewData(List<ExchangeStoreItemDesc> dataList)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void RefreshRecommendViewData()
	{
	}

	private void OnFriendlyShopGoBtnClick()
	{
	}

	private void OnToggleAutoRecruitClick()
	{
	}

	private void OnSocialBufRuleBtnClick()
	{
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	public FrontEndPreviewComponent GetFrontEndPreviewComponentInternal()
	{
		return null;
	}

	public void RefreshFriendlyShopAndItemCurrency(uint lastItemId)
	{
	}

	private void HighLightItem(int itemIndex, UIEasyList grid)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
