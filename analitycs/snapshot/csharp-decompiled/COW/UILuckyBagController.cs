using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UILuckyBagController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
{
	private UILuckyBagView m_View;

	private UIModelClan m_ModelClan;

	private UIModelUser m_ModelUser;

	private ulong m_SelectedBagID;

	private uint GOLD_LEVEL;

	private uint PURPLE_LEVEL;

	private List<BaseItemInfo> m_GoldAwardList;

	private List<BaseItemInfo> m_PurpleAwardList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override string Rule()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshViewData()
	{
	}

	private void HighlightCurrent()
	{
	}

	private void OnLuckyBagDrawed(object[] data)
	{
	}

	private void RefreshScrollViewData()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void ShowClaimAllBtn()
	{
	}

	private void OnClaimAllBtnClick()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void RefreshLeftContainer()
	{
	}

	private bool _003CHighlightCurrent_003Eb__12_0(ClanLuckyBag item)
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
