using GCommon;
using proto;

namespace COW;

public class UIGachaIchisNoramlShowItemController : UIBaseController
{
	private UIGachaIchisNoramlShowItemView m_View;

	private UIGachaIchisShowItemBaseView m_BaseView;

	private UIModelIchis m_ModelIchis;

	private IchisSortableGoodsData m_Data;

	private bool m_ShowFrame;

	private uint m_ChestId;

	private uint m_ChestSubId;

	private const string MASKED_COUNT_TEXT = "?";

	private const float NUMBER_VFX_DURATION = 1f;

	private uint m_PrevUniqueId;

	private uint m_PrevRemaining;

	private bool m_HasPrevRemaining;

	private bool m_NumberVFXPlaying;

	private uint m_NumberVFXEndDelayCallID;

	private uint m_IconAppliedUniqueId;

	private bool m_HasIconApplied;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ResetConditionalStates()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void Hide()
	{
	}

	public void SetItemData(IchisSortableGoodsData data, bool showFrame)
	{
	}

	public void SetChestIds(uint chestId, uint chestSubId)
	{
	}

	public uint GetUniqueId()
	{
		return 0u;
	}

	public void RefreshFromModel()
	{
	}

	private void RefreshItemDisplay()
	{
	}

	private void RefreshItemIcon(SharedGachaGoodsDesc goods)
	{
	}

	private void RefreshQualityPlus(uint quality)
	{
	}

	private void RefreshRemainingCount(uint remaining, uint total, bool isSoldout, ESharedGacha.RareType tier)
	{
	}

	private void TryPlayNumberChangeVFX(uint newRemaining, bool isSoldout)
	{
	}

	public void PlayCountRefreshVFX()
	{
	}

	private void StartNumberVFX()
	{
	}

	private void OnNumberVFXEnd()
	{
	}

	private void CancelNumberVFX()
	{
	}

	private void RefreshMaxState()
	{
	}

	private void RefreshQuantityLabel(SharedGachaGoodsDesc goods, bool isOwned)
	{
	}

	private void RefreshDurationLabel(SharedGachaGoodsDesc goods)
	{
	}

	private void RefreshOwnedState(bool isOwned)
	{
	}

	private void RefreshSoldoutState(bool isSoldout)
	{
	}

	private void RefreshItemContainer()
	{
	}

	private void RefreshVFX(SharedGachaGoodsDesc goods, bool isSoldout, bool isOwned)
	{
	}

	private static bool IsQualityPurpleOrAbove(uint quality)
	{
		return false;
	}

	private void RefreshSelectedState(SharedGachaGoodsDesc goods)
	{
	}

	private void OnItemClick()
	{
	}

	private void OnPoolItemSelected(object[] data)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
