using GCommon;

namespace COW;

public class UIHudHGArriveEndPointTopInfoController : UIBaseController
{
	private UIHudHGArriveEndPointTopInfoView m_View;

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

	protected override void OnUIClose()
	{
	}

	public void UpdateShowData(HGRoundTopDataParam param)
	{
	}

	private void CheckFiveCountDownState(float endTimeSec, bool isNeedShow)
	{
	}

	private void Update()
	{
	}

	private void PlayeUIFX()
	{
	}

	private void _003CPlayeUIFX_003Eb__11_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
