using GCommon;

namespace COW;

internal class UIBuildChooseLoadoutSideItemController : UIBaseChooseLoadoutItemController
{
	private UIBuildChooseLoadoutSideItemView m_View;

	private UIChangeStatusController m_ChangeStatusCtrl;

	private UICommonGuideController m_LoadoutDetailGuideCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitView()
	{
	}

	public override void SetData(uint id, int index)
	{
	}

	public void ShowLoadoutDetailGuide()
	{
	}

	public void HideLoadoutDetailGuide()
	{
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(uint P0, int P1)
	{
	}
}
