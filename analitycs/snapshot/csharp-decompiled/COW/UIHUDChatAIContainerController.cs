using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDChatAIContainerController : UIChatBaseContainerController
{
	private UIHUDChatAIContainerView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
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

	public override void RefreshContentNode()
	{
	}

	public void SetDepth(int depth)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
