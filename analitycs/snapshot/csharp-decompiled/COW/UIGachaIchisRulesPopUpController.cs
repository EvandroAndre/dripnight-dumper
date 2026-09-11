using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaIchisRulesPopUpController : UIGachaRulesPopUpController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<SharedGachaGoodsDesc> _003C_003E9__31_0;

		public static Comparison<GachaRulesPopUpIchisRecordData> _003C_003E9__38_0;

		internal int _003CGenerateIchisDropRateItemData_003Eb__31_0(SharedGachaGoodsDesc a, SharedGachaGoodsDesc b)
		{
			return 0;
		}

		internal int _003CRefreshIchisRecordList_003Eb__38_0(GachaRulesPopUpIchisRecordData a, GachaRulesPopUpIchisRecordData b)
		{
			return 0;
		}
	}

	private static readonly string ICHIS_RECORD_FILTER_ALL;

	private UIModelIchis m_ModelIchis;

	private int m_IchisRecordFilterTierIndex;

	private bool m_IchisRecordOnlySelf;

	private UIPopMenuSmallControler m_IchisRecordPopMenuCtrl;

	private bool m_IchisRecordInited;

	private bool m_IchisRecordActive;

	private uint m_IchisRecordChestId;

	private uint m_IchisRecordChestSubId;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(uint chestID)
	{
	}

	public void NavigateToIchisRecord()
	{
	}

	protected override void OnRulesTabSelect(UIToggleButton btn)
	{
	}

	protected override void SetDropRateTabActive()
	{
	}

	protected override void OnDropRateTabSelect(UIToggleButton btn)
	{
	}

	protected override void ShowRareProbabilityTips(object[] param)
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private UIModelIchis GetModelIchis()
	{
		return null;
	}

	private bool TryGetIchisChestKey(out uint chestId, out uint chestSubId)
	{
		chestId = default(uint);
		chestSubId = default(uint);
		return false;
	}

	private bool IsIchisGuaranteedConfigured()
	{
		return false;
	}

	private bool IsIchisGuaranteedEnabled()
	{
		return false;
	}

	private List<SharedGachaGoodsDesc> GetIchisGuaranteedGoods(uint chestId, uint chestSubId)
	{
		return null;
	}

	private BaseItemInfo CreateIchisBaseItemInfo(SharedGachaGoodsDesc goods)
	{
		return null;
	}

	private bool IsIchisProbabilityEnabled()
	{
		return false;
	}

	private int GetIchisProbabilityPrecision()
	{
		return 0;
	}

	private string GetIchisMinProbabilityText(int precision)
	{
		return null;
	}

	private decimal GetDecimalPow10(int power)
	{
		return 0m;
	}

	private void SetIchisGuaranteedDropLabel(uint chestId, uint chestSubId)
	{
	}

	private void SetIchisGrandPrizeList(uint chestId, uint chestSubId)
	{
	}

	private List<UIGachaRulesPopUpRateItemData> GenerateIchisDropRateItemData(uint chestId, uint chestSubId)
	{
		return null;
	}

	private string FormatIchisProbabilityText(uint itemCount, ulong totalCount)
	{
		return null;
	}

	private void OnIchisRecordTabSelect(UIToggleButton btn)
	{
	}

	private void OnIchisRecordToggleSelf()
	{
	}

	private void OnIchisRecordFilterSelect(object data)
	{
	}

	private void GenerateIchisRecordFilterMenuData()
	{
	}

	private void OnIchisHistoryRecordUpdated(object[] param)
	{
	}

	private void RefreshIchisRecordList()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnRulesTabSelect(UIToggleButton P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetDropRateTabActive()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDropRateTabSelect(UIToggleButton P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowRareProbabilityTips(object[] P0)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}
}
