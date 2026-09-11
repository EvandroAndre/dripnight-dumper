using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMemberShipCheckInListItemController : UIEasyListItemController
{
	private const string TIMEFORMAT = "{0}.{1}";

	private UIMemberShipCheckInListItemView m_View;

	private UIModelMemberShip m_Model;

	private UIPaymentMemberShipController.CheckInData m_Data;

	private Dictionary<EVipCard.VipCardType, uint> m_EVipCardTypeToDiamondCnt;

	private Color m_NormalColor;

	private Color m_LastDayColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void InitView()
	{
	}

	private void ProcessItemData()
	{
	}

	private void RefreshReissueView()
	{
	}

	private void RefreshMoreRewardsView()
	{
	}

	private void RefreshCheckInView()
	{
	}

	private void RefreshLastDayLabel()
	{
	}

	private void RefreshLockedView()
	{
	}

	private void OnButtonClick()
	{
	}

	private void PopupCheckInDetailTips()
	{
	}

	private bool IsToday()
	{
		return false;
	}

	private bool IsLastDay()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
