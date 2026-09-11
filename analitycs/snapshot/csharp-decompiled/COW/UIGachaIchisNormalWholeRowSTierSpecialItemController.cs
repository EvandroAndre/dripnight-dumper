using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaIchisNormalWholeRowSTierSpecialItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIGachaIchisNormalWholeRowSTierSpecialItemView m_View;

	private UIModelIchis m_ModelIchis;

	private UIModelCDNAd m_ModelCDNAd;

	private IchisTableRowData m_RowData;

	private string m_LoadedCdnUrl;

	private string m_LoadedSoldOutCdnUrl;

	private UILabel m_CDNItemNumberLabel;

	private UILabel m_TimeLimitLabel;

	private bool m_CDNLabelsResolved;

	private List<UIGachaIchisNoramlShowItemController> m_ShowItemCtrls;

	private Transform[] m_Slots;

	private const string MASKED_COUNT_TEXT = "?";

	private const float NUMBER_VFX_DURATION = 1f;

	private uint m_PrevCdnUniqueId;

	private uint m_PrevCdnRemaining;

	private bool m_HasPrevCdnRemaining;

	private bool m_NumberVFXPlaying;

	private uint m_NumberVFXEndDelayCallID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshBGCDNAd()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private void RefreshDisplay()
	{
	}

	private void RefreshCdnImage()
	{
	}

	private void RefreshRemainingLabel()
	{
	}

	private void StopCdnDownload()
	{
	}

	private void TryPlayCdnNumberVFX(IchisSortableGoodsData data, uint newRemaining, bool isSoldout)
	{
	}

	public void PlayCountRefreshReveal()
	{
	}

	private void PlayCdnCountRefreshVFX()
	{
	}

	private void StartCdnNumberVFX()
	{
	}

	private void OnNumberVFXEnd()
	{
	}

	private void CancelCdnNumberVFX()
	{
	}

	private void RefreshCdnItemStates()
	{
	}

	private void ResetCdnConditionalStates()
	{
	}

	private void RefreshSoldOutCdnTexture(bool isSoldout)
	{
	}

	private void CopyCurrentCdnTextureToSoldOutTexture()
	{
	}

	private void SetSoldOutCdnTextureVisible(bool visible)
	{
	}

	private void SetCdnBGSoldOut(bool isSoldout)
	{
	}

	private void StopSoldOutCdnDownload()
	{
	}

	private void ResolveCdnLabels()
	{
	}

	private void OnCDNItemClick()
	{
	}

	private void OnPoolItemSelected(object[] data)
	{
	}

	private void RefreshItemSlots()
	{
	}

	private int GetCenterStartSlot(int count)
	{
		return 0;
	}

	private void HideAllSlots()
	{
	}

	private void HideAllShowItems()
	{
	}

	private void EnsureShowItemCount(int count)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
