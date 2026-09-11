using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIPaymentMemberShipController : UIPaymentController.PaymentTabContentController, IUIModelDataChangeObserver, IEasyList
{
	public enum ECheckInType
	{
		Reissue,
		CheckIn,
		MoreRewards,
		Locked
	}

	public class CheckInData
	{
		public ECheckInType CheckInType;

		public ClientReissueItemData ItemData;

		public bool HasOwnVipCard;

		public bool MiniLastDay;

		public bool WeeklyLastDay;

		public bool MonthlyLastDay;

		public bool HasWarned;

		public CheckInData(ECheckInType type, bool hasOwnVipCard, ClientReissueItemData itemData = null)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public DateTime loginDayRefreshDateTime;

		internal bool _003CRefreshContent_003Eb__0(CheckInData data)
		{
			return false;
		}
	}

	private UIPaymentMemberShipView m_View;

	private UIModelMemberShip m_ModelMemberShip;

	private UIMemberShipDescController m_CardItemController;

	private UIMemberShipTabItemController m_MiniWeekCardTabItemController;

	private UIMemberShipTabItemController m_WeekCardTabItemController;

	private UIMemberShipTabItemController m_MonthCardTabItemController;

	private UIMemberShipNewVerAdPopupWindowController m_NewVerAdPopupWindowController;

	private const uint m_CheckInListLength = 29u;

	private const string ChangeMemberShipVersionNoticeKey = "CHANGE_MEMBERSHIP_VER_NOTICE_KEY_{0}";

	private bool m_IsFirstOpenPage;

	private bool m_SkipReissuedItem;

	private int m_LastDayOffset;

	private bool m_IsCheckInListActive;

	private EVipCard.VipCardType m_CurSelectCard;

	private List<CheckInData> m_CheckInDataList;

	public EVipCard.VipCardType CurSelectCard
	{
		get
		{
			return EVipCard.VipCardType.VipCardType_NONE;
		}
		set
		{
		}
	}

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

	protected override void OnVisibilityChanged()
	{
	}

	public override void RefreshContent()
	{
	}

	private void UpdateRebateCardItem()
	{
	}

	private void UpdateCheckInList()
	{
	}

	private void UpdateRefreshTimeLabel()
	{
	}

	public void ShowContentUI(EVipCard.VipCardType vipCardType)
	{
	}

	private void OnSelectCardTypeEvent(object[] data)
	{
	}

	private void SelectTabByCardType(EVipCard.VipCardType vipCardType)
	{
	}

	public void UnSelectAllMemberShipTabItems()
	{
	}

	public void PlayDescTitleClampInVFX()
	{
	}

	public void SelectCertainTabItem()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void ChangeMemberShipVersionNotice()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}
}
