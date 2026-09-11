using GCommon;

namespace COW;

internal class UIHudStropDashController : UIHudButtonBaseController
{
	public const string BUTTON_MAPPING_NAME = "StropDash";

	private UIHudStropDashView m_View;

	private float m_DashTotalTime;

	private float m_DashRemainTime;

	private uint m_RemainTimes;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override string GetMappingName()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	private void OnBtnCoolDownClick()
	{
	}

	private void Update()
	{
	}

	private void RefreshDashBuff(float duration)
	{
	}

	private void ResetDashTime(bool isUsing)
	{
	}

	private void OnChangeCancelVisible(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
