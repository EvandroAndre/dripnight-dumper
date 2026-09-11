using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudTrainingScoreController : UIBaseController
{
	private UIHudTrainingScoreView m_View;

	private HKGAJCJCMPE m_CurrentGame;

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

	private void OnCloseClick()
	{
	}

	public void SetData(uint kill, uint damage, uint dead, uint killStack, uint headshot)
	{
	}

	private void OnLocalPlayerBattleRankChange(int rank)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
