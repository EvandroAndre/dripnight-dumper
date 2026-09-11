using GCommon;

namespace COW;

public class UIHudLocalPlayerKilledController : UIBaseController
{
	private UIHudLocalPlayerKilledView m_View;

	private UIBaseProfileInfoController m_Profile;

	private TypewriterEffect m_WriterEffect;

	private const float C_ALPHA_BLEND_TIME = 2f;

	private float m_alphaBlendTime;

	private bool m_DisableBRRank;

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

	public void OnLocalPlayerKilled(object[] data)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
