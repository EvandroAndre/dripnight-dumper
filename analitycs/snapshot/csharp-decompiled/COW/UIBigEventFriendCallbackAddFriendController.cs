using System;
using GCommon;

namespace COW;

public class UIBigEventFriendCallbackAddFriendController : UIPopupWindowController
{
	private UIBigEventFriendCallbackAddFriendView m_View;

	private FriendAccountInfo m_Data;

	private UIBaseProfileInfoController m_BaseProfile;

	private Action m_afterAddAction;

	protected new UIPopupGlassBG m_Glass;

	public new UIGlassBGController GlassCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected void OnBtnCloseClicked()
	{
	}

	public void SetData(FriendAccountInfo data, Action action)
	{
	}

	private void OnBtnReWriteClicked()
	{
	}

	private void OnBtnAddFriendClicked()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
