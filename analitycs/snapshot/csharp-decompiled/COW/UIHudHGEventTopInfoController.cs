using GCommon;

namespace COW;

public class UIHudHGEventTopInfoController : UIBaseController
{
	private UIHudHGEventTopInfoView m_View;

	private UITimeLabelHelper m_TimeHelper;

	private UIHGTimingActiveEffectHelper m_TimingActiveEffectHelper;

	private UIFiveCountDownAnimHelper m_FinalCountDownHelper;

	private uint m_UIFXDelayCallID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void UpdateShowData(string iconResName, string eventDescKey, float endTimeSec = 0f, bool isForceTimeRed = false, EUITimeUpdateStyle timeUpdateStyle = EUITimeUpdateStyle.OnlySeconds)
	{
	}

	private void CheckFiveCountDownState(float endTimeSec)
	{
	}

	private void Update()
	{
	}

	private void PlayeUIFX()
	{
	}

	private void CancelDelayCall()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _003CPlayeUIFX_003Eb__10_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
