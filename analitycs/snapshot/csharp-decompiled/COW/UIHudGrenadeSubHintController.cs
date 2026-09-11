using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudGrenadeSubHintController : UIBaseController
{
	private UIHudGrenadeSubHintView m_View;

	private bool m_IsInitedOrgColor;

	private Color m_OrgColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetActive(bool val)
	{
	}

	public void SetHintType(UIHudGrenadeHintController.HintType hinttype)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
