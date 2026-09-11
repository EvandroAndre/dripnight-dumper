using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIChatWorldContainerController : UIChatBaseContainerController, IUIModelDataChangeObserver
{
	private UIChatWorldContainerView m_View;

	private UIModelChat m_Model;

	private uint m_UpdateLiftTopCallID;

	private uint m_HideLiftTopCallID;

	private Queue<MessageInfo> m_LiftTopMessageList;

	private int m_DefaultBottomValue;

	private int m_PanelIncrement;

	private UIChatWorldContainerLiftTopMessageController m_LeftTopMessageCtrl;

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

	public override GameObject GetContentNode()
	{
		return null;
	}

	public override GameObject GetEmptyNode()
	{
		return null;
	}

	public override UIScrollView GetMessageList()
	{
		return null;
	}

	public override UITable2 GetMessageListTable2()
	{
		return null;
	}

	public override void InitWidget(Transform parent)
	{
	}

	public override void RefreshContentNode()
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void AddLiftTopMessage(MessageInfo info)
	{
	}

	private void ShowLiftTopMessage()
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void ResetChatPanel(bool recover)
	{
	}

	private void _003CShowLiftTopMessage_003Eb__19_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_InitWidget(Transform P0)
	{
	}
}
