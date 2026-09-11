using GCommon;

namespace COW;

public class UIImmortalityCountdownTimerController : UIBaseController
{
	private UIImmortalityCountdownTimerView m_View;

	private VisualInstanceHolder m_immortalitySuccessKilledEffectHolder;

	private uint m_FullScreenVfxId;

	private float m_fTimer;

	private float m_fStartTimer;

	private float m_fEndTimer;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetTimerDataByEndTime(int endTime)
	{
	}

	public void SetTimerData(float startTimer, float timer, ResourceID uiEffect)
	{
	}

	private void Update()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
