using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudVerticleViewTimerController : UIBaseController
{
	private UIHudTimerViewExt m_View;

	private GIFGAGAGFLA m_Game;

	private static int m_PlayCountDownSoundSecond;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
