using System;
using GCommon;
using tcp;

namespace COW;

internal class UITransferLeaderItemController : UIEasyListItemController
{
	private UITransferLeaderItemView m_View;

	private GroupMemberInfo m_GroupMemberInfoInfo;

	private UIModelGroup m_ModelGroup;

	private Action<ulong> BtnClickAction;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnTransferGroupLeaderBtnClick()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetBtnClickAction(Action<ulong> action)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
