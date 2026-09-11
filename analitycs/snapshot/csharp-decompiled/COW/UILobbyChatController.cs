using System;
using GCommon;
using tcp;

namespace COW;

public class UILobbyChatController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<GroupMemberInfo, FriendInfo> _003C_003E9__10_0;

		internal FriendInfo _003COnFastSendGiftBtnClick_003Eb__10_0(GroupMemberInfo teammate)
		{
			return null;
		}
	}

	private UILobbyChatView m_View;

	private UIModelChat m_ChatModel;

	private UIModelGroup m_GroupModel;

	private uint m_MessageDispearCallID;

	private int m_MessageLabelOrigWidth;

	private bool m_HideBtn;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnChatRecruitBtnClick()
	{
	}

	private void OnRecruitBtnClick()
	{
	}

	private void OnFastSendGiftBtnClick()
	{
	}

	private void OnChatMessageBtnClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void OnChatBtnClick()
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshLatestMessage()
	{
	}

	private void OnScrollFinish()
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshBtnState(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
