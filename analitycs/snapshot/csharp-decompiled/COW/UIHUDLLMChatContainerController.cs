using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDLLMChatContainerController : UIChatBaseContainerController
{
	private UIHUDLLMChatContainerView m_View;

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

	protected override void OnVisibilityChanged()
	{
	}

	public override void InitWidget(Transform parent)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_InitWidget(Transform P0)
	{
	}
}
