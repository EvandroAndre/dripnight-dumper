using GCommon;
using UnityEngine;

namespace COW;

public class UIClanBriefBoxFriendItemController : UIBaseController
{
	private UIClanBriefBoxFriendItemView m_View;

	private BaseProfileInfo m_Data;

	private Vector3 m_OpenPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(BaseProfileInfo data, int depth, Vector3 openPos)
	{
	}

	private void OnFriendButtonClicked()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
