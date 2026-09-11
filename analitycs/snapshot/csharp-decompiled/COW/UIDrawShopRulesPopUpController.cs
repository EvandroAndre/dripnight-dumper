using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIDrawShopRulesPopUpController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private enum UIDrawShopRulesPopUpTab
	{
		None,
		Rule,
		DropRate
	}

	private enum TTAllDorpRateItemTemplateType
	{
		DescLabel,
		DropRateV1,
		DropRateV2
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UIDrawShopRulesPopUpRateItemData> _003C_003E9__65_0;

		internal int _003CGetDropRateV1ItemList_003Eb__65_0(UIDrawShopRulesPopUpRateItemData x, UIDrawShopRulesPopUpRateItemData y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public UILabel label;

		public uint tierThreshold;

		public int round;

		internal void _003CSetLabelTextWithIcon_003Eb__0(bool downloadResult, string spriteName, bool hasPending)
		{
		}
	}

	private sealed class _003CSetTTAllDorpRateUITable2OffsetCoroutine_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDrawShopRulesPopUpController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetTTAllDorpRateUITable2OffsetCoroutine_003Ed__70(int _003C_003E1__state)
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

	private UIGachaRulesPopUpView m_View;

	private UIModelDrawShop m_ModelDrawShop;

	private uint m_ChestID;

	private UIDrawShopRulesPopUpTab m_Tab;

	private bool m_NeedNavigateToPrice;

	private List<UIDrawShopPreviewPopWndItemController> m_PrizeItemCtrlList;

	private List<UIGachaRulesPopUpDropRateV1Controller> m_CommonDropRateV1CtrlList;

	private List<UIGachaRulesPopUpDropRateV1Controller> m_DWGrandPrizeDropRateV1CtrlList;

	private List<UIGachaRulesPopUpDropRateV1Controller> m_DWCommonRewardDropRateV1CtrlList;

	private List<UIDrawShopRulesPopUpDropRateV2ItemController> m_CommonDropRateV2ItemCtrlList;

	private List<UIDrawShopRulesPopUpDropRateV2ItemController> m_DWGrandPrizeDropRateV2ItemCtrlList;

	private List<UIDrawShopRulesPopUpDropRateV2ItemController> m_DWCommonRewardDropRateV2ItemCtrlList;

	private List<UIDrawShopLimitedDropRateItemController> m_LimitedDropRateItemCtrlList;

	private List<UILabel> m_GuaranteedDropLabelList;

	private const int MAX_TOKEN_COUNT = 5;

	private int m_ProbabilityPrecision;

	private string m_GotoTutorialUrl;

	private string m_GotoTutorialTitleKey;

	private Coroutine m_DelayBuildTTAllDorpRateUITable2Coroutine;

	private bool IsProbabilityEnabled(UIModelDrawShop.DrawShopContentDataBase contentData)
	{
		return false;
	}

	private bool ShouldShowTowerAllProbability()
	{
		return false;
	}

	private string GetMinProbabilityDisplay()
	{
		return null;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint chestID)
	{
	}

	public void NavigateToGuaranteedDrop()
	{
	}

	public void NavigateToPrice()
	{
	}

	private void SetDropRateTabActive()
	{
	}

	private bool CheckWheelDropRateTabVisible(UIModelDrawShop.DrawShopWheelContentData wheelData)
	{
		return false;
	}

	private bool CheckTowerDropRateTabVisible(UIModelDrawShop.DrawShopTowerContentData towerData)
	{
		return false;
	}

	private bool CheckLimitedPoolDropRateTabVisible(UIModelDrawShop.DrawShopLimitedPoolContentData limitedData)
	{
		return false;
	}

	private void OnRulesTabSelect(UIToggleButton btn)
	{
	}

	private void OnGotoTutorialBtnClick()
	{
	}

	private void OnDropRateTabSelect(UIToggleButton btn)
	{
	}

	private void ShowEmptyDropRateContent()
	{
	}

	private bool GetChestDropProbabilitySwitch(UIModelDrawShop.DrawShopContentDataBase contentData)
	{
		return false;
	}

	private void RequestProbabilityData(UIModelDrawShop.DrawShopContentDataBase contentData)
	{
	}

	private void ShowDropRateContentWithoutProbability(UIModelDrawShop.DrawShopContentDataBase contentData)
	{
	}

	private void ShowGuaranteedInfo(UIModelDrawShop.DrawShopContentDataBase contentData)
	{
	}

	private void ShowGrandPrizeList(UIModelDrawShop.DrawShopContentDataBase contentData)
	{
	}

	private void ShowPriceInfo(UIModelDrawShop.DrawShopContentDataBase contentData)
	{
	}

	private string GetPriceString(UIModelDrawShop.DrawShopContentDataBase contentData)
	{
		return null;
	}

	private string GetLimitedPoolPriceString(UIModelDrawShop.DrawShopLimitedPoolContentData limitedData)
	{
		return null;
	}

	private string GetCurrencyIcon(UIModelDrawShop.EDrawShopCoinType coinType)
	{
		return null;
	}

	private void TryNavigateToPriceAfterPopulated()
	{
	}

	private void SetGuaranteedDropLabel(UILabel label, UIModelDrawShop.DrawShopWheelContentData wheelData, UIModelDrawShop.DrawShopInfoData chestInfo)
	{
	}

	private void SetTowerGuaranteedDropLabel(UILabel label, UIModelDrawShop.DrawShopTowerContentData towerData, UIModelDrawShop.DrawShopInfoData chestInfo)
	{
	}

	private void SetTokenTowerAllCanGotGuaranteedDropLabel(UIModelDrawShop.DrawShopTowerContentData towerData, UIModelDrawShop.DrawShopInfoData chestInfo)
	{
	}

	private void SetLabelTextWithIcon(UILabel label, uint tierThreshold, int round, uint item_id)
	{
	}

	private bool CheckAllGrandPrizesRemoved(UIModelDrawShop.DrawShopWheelContentData wheelData, UIModelDrawShop.DrawShopInfoData chestInfo)
	{
		return false;
	}

	private bool CheckAllGrandPrizesRemovable(UIModelDrawShop.DrawShopWheelContentData wheelData)
	{
		return false;
	}

	private void ShowLimitedPoolProbability(object probabilityData)
	{
	}

	private void ShowLimitedPoolProbabilityItems(CSDrawShopGetLimitedPoolProbabilityRes res)
	{
	}

	private void ShowWheelProbability(object probabilityData)
	{
	}

	private void ShowWheelProbabilityItems(UIModelDrawShop.DrawShopContentDataBase contentData, CSDrawShopGetWheelProbabilityRes res)
	{
	}

	private UIGachaRulesPopUpRateItemData CreateWheelItemData(ClientDrawShopWheelGoodsDesc goods, uint probability)
	{
		return null;
	}

	private void ShowTowerProbability(object probabilityData)
	{
	}

	private void ShowTowerProbabilityCurrentRound(UIModelDrawShop.DrawShopContentDataBase contentData, CSDrawShopGetTowerProbabilityRes res)
	{
	}

	private void ShowTowerProbabilityAllRounds(UIModelDrawShop.DrawShopContentDataBase contentData, CSDrawShopGetTowerProbabilityRes res)
	{
	}

	private void AddTowerProbabilityRoundToTable(int tokenCount, int tierIndex, CSDrawShopGetTowerProbabilityRes res, Dictionary<uint, ClientDrawShopTowerGoodsDesc> goodsDict)
	{
	}

	private UIGachaRulesPopUpRateItemData CreateTowerItemData(ClientDrawShopTowerGoodsDesc goods, uint probability)
	{
		return null;
	}

	private int GetCurrentTokenTier(UIModelDrawShop.DrawShopTowerContentData towerData, uint tokenProgress)
	{
		return 0;
	}

	private string FormatProbabilityText(uint probability)
	{
		return null;
	}

	private void ShowRareProbabilityTips(object[] param)
	{
	}

	private List<UIDrawShopRulesPopUpRateItemData> GetDropRateV1ItemList(List<GachaShowItem> showItemList, uint rare)
	{
		return null;
	}

	private void InitTTAllDorpRateItemTemplate()
	{
	}

	private void CreateTTAllDorpRateUITable2RoundItem(uint round, LevelProbability pr, bool isUseV1)
	{
	}

	private void BuildTTAllDorpRateUITable2()
	{
	}

	private IEnumerator SetTTAllDorpRateUITable2OffsetCoroutine()
	{
		return null;
	}

	private List<Transform> GetAllActiveTransformAboveTTAllDorpRateUITable2()
	{
		return null;
	}

	private float GetAllAdditionalPaddingAboveTTAllDorpRateUITable2()
	{
		return 0f;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private UITable2.IUITable2Item _003CInitTTAllDorpRateItemTemplate_003Eb__66_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTTAllDorpRateItemTemplate_003Eb__66_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTTAllDorpRateItemTemplate_003Eb__66_2()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
