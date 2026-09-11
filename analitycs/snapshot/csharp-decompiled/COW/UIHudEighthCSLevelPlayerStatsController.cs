using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudEighthCSLevelPlayerStatsController : UIHudLevelPlayerStatsController
{
	private enum ShowState
	{
		Init,
		Charge,
		WaitActive,
		Active
	}

	private UIHudEighthCSInfiniteLevelView m_View;

	private NKDHFJHPEFL m_BattleLevelModule;

	private JHNCAGHNHAK m_BindPlayerModule;

	private ShowState m_CurrentState;

	private const float m_CircleExpBarOffsetDegrees = 36f;

	private const float m_CircleExpBarFillAmountMin = 0.1f;

	private const float m_CircleExpBarFillAmountMax = 0.9f;

	private uint useActiveTime;

	private uint useEndTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void Update()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void RefreshContent()
	{
	}

	private void RefreshShowState()
	{
	}

	public override void BindPlayer(BHGGAEEHJCO playerID)
	{
	}

	private void OnBtnClick()
	{
	}

	private void OnPlayerExpChange(uint playerID)
	{
	}

	private void OnPlayerLevelChange(uint playerID)
	{
	}

	private void RefreshBuildIcon()
	{
	}

	private void OnGotEighthEffect()
	{
	}

	private void OnRemoveEightEffect()
	{
	}

	private void UpdateUseProgress()
	{
	}

	private void ShowGotEffect()
	{
	}

	private void OnRechargeMax()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}

	public void _003C_003EiFixBaseProxy_BindPlayer(BHGGAEEHJCO P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
