using GCommon;

namespace COW;

public class UIHUDUGC_IconNotificationController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_IconNotificationView m_View;

	private UGCIconNotificationHudRepItem m_ViewData;

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

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnIconSpriteNameChangeEvent(string cur)
	{
	}

	private void OnBgIconSpriteNameChangeEvent(string cur)
	{
	}

	private void OnDescriptionChangeEvent(string cur)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
