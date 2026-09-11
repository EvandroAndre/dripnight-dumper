using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudCancelController : UIHudButtonBaseController
{
	private UIHudCancelView m_View;

	private Vector3 m_pos;

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

	private void OnChangeVisible(object[] param)
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	public void SetDefaultPos(Vector3 pos)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
