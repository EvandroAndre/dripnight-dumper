using GCommon;

namespace COW;

public class UIhudBossOniPopupController : UIBaseController
{
	private UIhudBossOniPopupView m_View;

	private uint m_DelayCall;

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

	public void SetData(float time, int bossType = 0)
	{
	}

	public void SetData(bool hold, string titleKey, string contentKey, int bossType = 0)
	{
	}

	public void SetData(int bossType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
