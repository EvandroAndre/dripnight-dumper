using GCommon;
using UnityEngine;

namespace COW;

public class UILoadoutTagController : UIBaseController
{
	private UILoadoutTagView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public Transform GetSpriteTarget()
	{
		return null;
	}

	public void SetData(object data, bool isBtnEnabled = false)
	{
	}

	public void OnTagClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
