using GCommon;

namespace COW;

public class UIHudHypeSnowmanProcessBarController : UIBaseController
{
	private UIHudHypeSnowmanProcessBarView m_View;

	private ushort m_MaxHypeValue;

	private ushort m_MaxHypeLevel;

	private ushort m_CurrentHypeLevel;

	private ushort m_CurrentHypeValue;

	private bool m_IsFootball;

	private bool m_IsTeamateSpeedUp;

	private bool m_IsTipsOpen;

	private float rotateEndTime;

	private uint EffectTipsCloseDelayCall;

	private UIClickMask m_TipsClickMask;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void OnUIReInit()
	{
	}

	private void Update()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnHypeValueChange(object[] data)
	{
	}

	private void OnHypeLevelChange(object[] data)
	{
	}

	private void ShowLevelUpEffect()
	{
	}

	private void OnMaxHypeValueChange(object[] data)
	{
	}

	private void OnMaxHypeLevelChange(object[] data)
	{
	}

	private void OnSwitchObserver(object[] data)
	{
	}

	private void OnFootBallStatusChange(object[] data)
	{
	}

	private void OnFootBallRadiusChange(float radius)
	{
	}

	private void OnSnowBallSpeedUpChange(bool flag)
	{
	}

	private void OnHyperTipsBtnClick()
	{
	}

	private string[] GetHypeDescParam()
	{
		return null;
	}

	private void _003CShowLevelUpEffect_003Eb__16_0()
	{
	}

	private void _003COnHyperTipsBtnClick_003Eb__24_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
