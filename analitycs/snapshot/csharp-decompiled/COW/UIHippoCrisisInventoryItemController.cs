using System;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHippoCrisisInventoryItemController : UIEasyListItemController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__28_1;

		internal void _003CStartGuide_003Eb__28_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public UIHippoCrisisInventoryItemController _003C_003E4__this;

		public NewbieGuideId guideId;

		public CommonGuideSetting setting;

		public int nextGuideStep;

		public ulong uniqueId;

		internal void _003CStartGuide_003Eb__0()
		{
		}
	}

	private UIHippoCrisisInventoryItemView m_View;

	private HippoCrisisOutGameItemUIData m_Data;

	private HippoCrisisStoreItemData m_StoreItemData;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private bool m_IsMultiSelected;

	private UIHippoCrisisItemBriefBoxController m_boxCtrl;

	private HENEHAGJCLI m_ItemData;

	private UIHippoCrisisInventoryDragDropItem m_DropItem;

	private bool m_IsSelected;

	private TweenScale m_Tween;

	private uint m_GuideDelayCall;

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

	private void OnSellingSelect()
	{
	}

	private void ShowTipsInMarketWindow()
	{
	}

	private void HideTipsInMarketWindow(object[] param)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetViewData(HippoCrisisOutGameItemUIData data)
	{
	}

	public void SetUIDataInSellPop(HippoCrisisOutGameItemUIData data)
	{
	}

	public void SetUIDataByInterface(IHippoCrisisBackPackItemUIData data)
	{
	}

	public void SetMaterialUseUIData(uint itemId, uint inventoryNum, uint needNum, bool isMarketUse = false)
	{
	}

	public void SetUIDataInMarket(HippoCrisisStoreItemData data, bool isMatUse = false)
	{
	}

	public void SetUIDataInRecommendPreSet(HippoCrisisPreSetData data)
	{
	}

	public void PlayTween()
	{
	}

	public void DisableClick()
	{
	}

	private void StartGuide(object[] param)
	{
	}

	private void OnGuideDragSuccess()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
