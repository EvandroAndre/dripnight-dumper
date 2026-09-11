using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIActivityV2FriendReunionInviteeMissionController : UIBaseController, IUIModelDataChangeObserver
{
	private UIActivityV2FriendReunionInviteeMissionView m_View;

	private UIModelFriendReunion m_ModelFriendReunion;

	private CallbackTaskDesc m_TaskDesc;

	private CallbackTaskInfo m_TaskInfo;

	private List<UIStandardItemMiniController> m_ListRewardItem;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(CallbackTaskDesc taskDesc)
	{
	}

	public void SetLineState(bool show)
	{
	}

	private void InitUIState()
	{
	}

	private void SetAwardItemUI()
	{
	}

	private void SetBtnStateUI()
	{
	}

	private void OnBtnOperateClick()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
