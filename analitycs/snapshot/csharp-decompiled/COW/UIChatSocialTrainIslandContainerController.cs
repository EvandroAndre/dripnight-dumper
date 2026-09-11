using GCommon;
using UnityEngine;

namespace COW;

public class UIChatSocialTrainIslandContainerController : UIChatBaseContainerController
{
	private UIChatSocialTrainIslandContainerView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
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

	public override void InitWidget(Transform parent)
	{
	}

	protected override void OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitWidget(Transform P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
