using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDFeedbackItemController : UIHUDFeedbackItemBaseController
{
	protected UIHUDFeedbackItemView m_View;

	private uint m_AsyncLoadTicket;

	private ResourceID m_VfxResID;

	private GameObject m_Instance;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override GameObject GetLabelRoot()
	{
		return null;
	}

	public void SetData(NotifyShowDataSimple data)
	{
	}

	private void OnVfxPoolInstantiated(uint ticket, bool success, Object instance)
	{
	}

	public override void HideIcon()
	{
	}

	private void RecyleVFX()
	{
	}

	public override void ShowIcon(NotificationData data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public GameObject _003C_003EiFixBaseProxy_GetLabelRoot()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_HideIcon()
	{
	}
}
