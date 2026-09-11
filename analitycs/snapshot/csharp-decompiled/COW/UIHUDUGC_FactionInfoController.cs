using GCommon;

namespace COW;

public class UIHUDUGC_FactionInfoController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_FactionInfoView m_View;

	private UGCFactionInfoHudRepItem m_ViewData;

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

	private void OnLeftTeammateAliveCountChangeEvent(int cur)
	{
	}

	private void OnRightTeammateAliveCountChangeEvent(int cur)
	{
	}

	private void OnLeftBgColorChangeEvent(int cur)
	{
	}

	private void OnRightBgColorChangeEvent(int cur)
	{
	}

	private void OnLeftIconSpriteNameChangeEvent(string cur)
	{
	}

	private void OnRightIconSpriteNameChangeEvent(string cur)
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
