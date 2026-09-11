using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudMapAstrolGateTipsController : UIBaseController
{
	private UIHudMapAstrolGateTipsView m_View;

	private OONOIDNLCFF m_CurrentState;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void UpdateTipsByState(OONOIDNLCFF state)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
