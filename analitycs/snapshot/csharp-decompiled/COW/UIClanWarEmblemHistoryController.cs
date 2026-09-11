using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIClanWarEmblemHistoryController : UIPopupWindowController, IEasyList
{
	private UIClanWarEmblemHistoryView m_View;

	private List<UIClanWarEmblemHistoryItemController> m_Items;

	private UIModelClan m_ModelClan;

	private UIModelClanWarV2 m_ModelClanWar;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private UIClanWarEmblemHistoryItemController m_RegionGloryItem;

	private UIClanWarEmblemHistoryItemController m_GlobalGloryItem;

	private ulong m_ClanId;

	private uint m_CurSelectTitleId;

	private uint m_CurEquipTitleId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void SetViewData(ulong clanId, bool showDesc = true)
	{
	}

	private void OnClickShareBtn()
	{
	}

	private void OnItemSelect(uint titleId)
	{
	}

	protected override void OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
