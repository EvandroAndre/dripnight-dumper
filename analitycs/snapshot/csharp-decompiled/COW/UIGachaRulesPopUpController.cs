using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaRulesPopUpController : UIPopupWindowController, IUIModelDataChangeObserver
{
	protected enum UIGachaRulesPopUpTab
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

		public static Predicate<LevelProbability> _003C_003E9__19_0;

		public static Predicate<LevelProbability> _003C_003E9__19_3;

		public static Comparison<UIGachaRulesPopUpRateItemData> _003C_003E9__20_0;

		internal bool _003CShowRareProbabilityTips_003Eb__19_0(LevelProbability x)
		{
			return false;
		}

		internal bool _003CShowRareProbabilityTips_003Eb__19_3(LevelProbability x)
		{
			return false;
		}

		internal int _003CGetDropRateV1ItemList_003Eb__20_0(UIGachaRulesPopUpRateItemData x, UIGachaRulesPopUpRateItemData y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public uint currentRound;

		internal bool _003CShowRareProbabilityTips_003Eb__1(LevelProbability x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_1
	{
		public uint currentRound;

		internal bool _003CShowRareProbabilityTips_003Eb__4(LevelProbability x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public UILabel label;

		public GachaLegendaryInfoData infoData;

		internal void _003CSetGuaranteedDropLabel_003Eb__0(bool downloadResult, string spriteName, bool hasPending)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public uint curGuaranteedDrop;

		public int round;
	}

	private sealed class _003C_003Ec__DisplayClass30_1
	{
		public UILabel label;

		public _003C_003Ec__DisplayClass30_0 CS_0024_003C_003E8__locals1;

		internal void _003CSetTokenTowerAllCanGotGuaranteedDropLabel_003Eb__0(bool downloadResult, string spriteName, bool hasPending)
		{
		}
	}

	private sealed class _003CSetTTAllDorpRateUITable2OffsetCoroutine_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGachaRulesPopUpController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetTTAllDorpRateUITable2OffsetCoroutine_003Ed__35(int _003C_003E1__state)
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

	protected UIGachaRulesPopUpView m_View;

	protected UIModelGacha m_ModelGacha;

	protected uint m_GachaID;

	protected UIGachaRulesPopUpTab m_Tab;

	protected bool m_NeedNavigateToPrice;

	protected List<UIGachaRulesPopUpGrandPrizeItemController> m_PrizeItemCtrlList;

	private List<UIGachaRulesPopUpDropRateV1Controller> m_CommonDropRateV1CtrlList;

	private List<UIGachaRulesPopUpDropRateV1Controller> m_DWGrandPrizeDropRateV1CtrlList;

	private List<UIGachaRulesPopUpDropRateV1Controller> m_DWCommonRewardDropRateV1CtrlList;

	protected List<UIGachaRulesPopUpDropRateV2ItemController> m_CommonDropRateV2ItemCtrlList;

	private List<UIGachaRulesPopUpDropRateV2ItemController> m_DWGrandPrizeDropRateV2ItemCtrlList;

	private List<UIGachaRulesPopUpDropRateV2ItemController> m_DWCommonRewardDropRateV2ItemCtrlList;

	protected List<UILabel> m_GuaranteedDropLabelList;

	protected const int MAXTOKENCOUNT = 5;

	private Coroutine m_DelayBuildTTAllDorpRateUITable2Coroutine;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ShowLimitedRareProbabilityTips(object[] param)
	{
	}

	protected virtual void ShowRareProbabilityTips(object[] param)
	{
	}

	private List<UIGachaRulesPopUpRateItemData> GetDropRateV1ItemList(List<GachaShowItem> showItemList, uint rare)
	{
		return null;
	}

	public virtual void SetViewData(uint chestID)
	{
	}

	protected void LogRulesPopupTabClick(string tabName)
	{
	}

	protected virtual void SetDropRateTabActive()
	{
	}

	public void NavigateToGuaranteedDrop()
	{
	}

	public void NavigateToPrice()
	{
	}

	protected void TryNavigateToPriceAfterPopulated()
	{
	}

	protected virtual void OnRulesTabSelect(UIToggleButton btn)
	{
	}

	protected virtual void OnDropRateTabSelect(UIToggleButton btn)
	{
	}

	private void SetGuaranteedDropLabel(UILabel label, uint chestID)
	{
	}

	private void SetTokenTowerAllCanGotGuaranteedDropLabel(uint chestID)
	{
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

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private int _003CShowLimitedRareProbabilityTips_003Eb__18_0(LevelProbability a, LevelProbability b)
	{
		return 0;
	}

	private int _003CShowLimitedRareProbabilityTips_003Eb__18_1(LevelProbability a, LevelProbability b)
	{
		return 0;
	}

	private int _003CShowRareProbabilityTips_003Eb__19_2(LevelProbability a, LevelProbability b)
	{
		return 0;
	}

	private int _003CShowRareProbabilityTips_003Eb__19_5(LevelProbability a, LevelProbability b)
	{
		return 0;
	}

	private UITable2.IUITable2Item _003CInitTTAllDorpRateItemTemplate_003Eb__31_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTTAllDorpRateItemTemplate_003Eb__31_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTTAllDorpRateItemTemplate_003Eb__31_2()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
