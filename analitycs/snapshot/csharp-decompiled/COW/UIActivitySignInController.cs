using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIActivitySignInController : UIActivityBaseController, IUIModelDataChangeObserver
{
	private UIActivitySignInView m_View;

	private const int MaxItemPerLine = 6;

	private const int BigAwardDayIndex = 4;

	private List<UIAnnouncementRewardItemController> m_ItemList;

	private int m_lastSignedIndex;

	private Transform[] m_ItemContainerList;

	private UITaskController m_ParentCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void ClearItem()
	{
	}

	private void RefreshList()
	{
	}

	private void RefreshSignDesc()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void AutoSignIn()
	{
	}

	private void OnMembershipSignInBtnClick()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
