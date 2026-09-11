using GCommon;

namespace COW;

public class UIHUDUGC_CSRoundInfoController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_CSRoundInfoView m_View;

	private UGCRoundInfoHudRepItem m_RepItem;

	private UGCEntityRepItem m_EntityRepItem;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void OnActiveSelfChanged(bool value)
	{
	}

	private void OnTitleChanged(string value)
	{
	}

	private void OnSubTitleChanged(string value)
	{
	}

	private void OnBackgroundColor1Changed(int value)
	{
	}

	private void OnBackgroundColor2Changed(int value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
