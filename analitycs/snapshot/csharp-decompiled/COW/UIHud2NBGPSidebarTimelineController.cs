using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHud2NBGPSidebarTimelineController : UIBaseController, IGameMissionTopEventUI
{
	private enum PhaseStage
	{
		Invalid,
		Before,
		Active,
		Ending
	}

	private const string m_BloodMoonIconName = "2NBGP_Icon_Activity_BloodMoon";

	private const string m_BigItemsIconName = "2NBGP_Icon_Activity_Akatsuki";

	private const string m_NotActiveBigItemsIconName = "2NBGP_Icon_Activity_Akatsuki_Grey";

	private static readonly Color m_ActiveLabelColor;

	private static readonly Color m_NotActiveLabelColor;

	private bool m_TimelineSetup;

	private float m_PhaseBloodMoonStartTimeSecs;

	private float m_PhaseBloodMoonEndTimeSecs;

	private float m_PhaseBigItemsStartTimeSecs;

	private float m_PhaseBigItemsEndTimeSecs;

	private float m_TimelineEndTimeSecs;

	private CJHKNOOJLIH m_PreviousTickGamePhase;

	private UIHud2NBGPSidebarTimelineView m_View;

	private UITimeLabelHelper m_TimeLabelHelper;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void RegisterEvents()
	{
	}

	private void OnGameModuleInfoReady()
	{
	}

	private void OnCabinPhaseEnd()
	{
	}

	private void Update()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void SetupTimeLabelHelper()
	{
	}

	private void SavePhaseTimestamps()
	{
	}

	private void SetPhaseBloodMoonActive(bool active)
	{
	}

	private void SetPhaseBigItemsActive(bool active)
	{
	}

	private void SetPhaseInfoBgActive(bool active)
	{
	}

	private void UpdatePhaseLabelsColor(bool active)
	{
	}

	private void SwitchCountdownLabelWithState(PhaseStage stage)
	{
	}

	private void UpdateLayoutContentAfterTimelineSetup()
	{
	}

	private void UpdateContentOnGamePhaseStart(CJHKNOOJLIH phase)
	{
	}

	private void UpdateCountdownLabelOnGamePhaseStart(float currentTime, CJHKNOOJLIH phase)
	{
	}

	private void TryUpdateContentWithPhaseChange(float currentTime, CJHKNOOJLIH phase)
	{
	}

	private CJHKNOOJLIH CalculateCurrentGamePhase(float currentTime)
	{
		return CJHKNOOJLIH.ENaru2NBGPGamePhase_None;
	}

	public float NeedHeight()
	{
		return 0f;
	}

	public void InitDataOnOpenFromGameMissionUI(object data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
