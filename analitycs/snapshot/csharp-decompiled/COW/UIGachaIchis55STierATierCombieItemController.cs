using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaIchis55STierATierCombieItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIGachaIchis55STierATierCombieItemView m_View;

	private UIModelIchis m_ModelIchis;

	private IchisTableRowData m_RowData;

	private string m_LoadedCdnUrl;

	private UIPanel m_Panel;

	private List<UIGachaIchis55ShowItemController> m_AShowItemCtrls;

	private Transform[] m_Slots;

	private const string MASKED_COUNT_TEXT = "?";

	private const float NUMBER_VFX_DURATION = 1f;

	private uint m_PrevSUniqueId;

	private uint m_PrevSRemaining;

	private bool m_HasPrevSRemaining;

	private bool m_NumberVFXPlaying;

	private uint m_NumberVFXEndDelayCallID;

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

	private void OnEnable()
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

	public void ReplayMainAniOnTabEnter()
	{
	}

	private void TryPlayMainAni()
	{
	}

	public void ApplyEntryUIFX()
	{
	}

	private void SampleMainAniToEnd()
	{
	}

	private void RefreshDisplay()
	{
	}

	private void RefreshSCdnArea()
	{
	}

	private void RefreshAItemArea()
	{
	}

	private SharedGachaGoodsDesc GetSGoods()
	{
		return null;
	}

	private IchisSortableGoodsData GetSData()
	{
		return null;
	}

	private void SetCdnVisible(bool visible)
	{
	}

	private void RefreshCdnImage()
	{
	}

	private void StopCdnDownload()
	{
	}

	private void RefreshSStateBadges(SharedGachaGoodsDesc sGoods)
	{
	}

	private void TryPlaySNumberChangeVFX(uint uniqueId, uint newRemaining, bool isSoldout, IchisSortableGoodsData sData)
	{
	}

	public void PlayCountRefreshReveal()
	{
	}

	private void PlaySCountRefreshVFX()
	{
	}

	private void StartSNumberVFX()
	{
	}

	private void OnNumberVFXEnd()
	{
	}

	private void CancelSNumberVFX()
	{
	}

	private void ResetSStateBadges()
	{
	}

	private void HideAllSlots()
	{
	}

	private void HideAllAShowItems()
	{
	}

	private void EnsureAShowItemCount(int count)
	{
	}

	public void SetPanelDepth(int depth)
	{
	}

	private void OnSItemClick()
	{
	}

	private void OnPoolItemSelected(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
