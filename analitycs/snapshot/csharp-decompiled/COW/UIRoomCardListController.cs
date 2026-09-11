using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIRoomCardListController : UIBaseController, IUIModelDataChangeObserver
{
	public Action onReposition;

	private UIRoomCardListView m_View;

	private Dictionary<uint, UIRoomCardView> m_CardViewDic;

	private const string GUIDE_KEY = "KEY_CUSTOMROOM_ADCS_CARD";

	private UIUGCPremiumCardController m_PremiumCard;

	private UIModelUGCPremium m_UGCPremium;

	public UIUGCPremiumCardController UGCPremiumCard => null;

	public UITable RoomCardTable => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void RefreshCard(object[] data)
	{
	}

	public void ShowPremiumCard(Action clickCallback = null)
	{
	}

	public UIRoomCardView GetCardViewByType(EInventory.ItemSubType type)
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
