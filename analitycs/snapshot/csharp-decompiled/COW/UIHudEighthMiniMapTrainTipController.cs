using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudEighthMiniMapTrainTipController : UIBaseController
{
	private enum EWaveState
	{
		EWaveState_Invalid,
		EWaveState_Wait,
		EWaveState_Active,
		EWaveState_Passed
	}

	private UIHudEighthMiniMapTrainTipView m_View;

	private float TrainAppearTime;

	private float TrainWaitTime;

	private float m_CenterOneWaveProgressPercent;

	private List<float> m_AllWaveArrivedTimeList;

	private List<float> m_AllWaveLeaveTimeList;

	private UITimeLabelHelper m_LeftTimeHelper;

	private int m_LastPassedWaveIndex;

	private int m_CurDetailShowWaveIndex;

	private EWaveState m_CurDetailShowWaveState;

	private uint m_DelayHideTicket;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	public void SetShowData(float curServerTime, List<int> allWaveArrivedTime)
	{
	}

	private void UpdateShowView(float curServerTime)
	{
	}

	private void RefreshCurWaveInfo(int newIndex, EWaveState newState)
	{
	}

	private void Update()
	{
	}

	private void DelayHideEffect()
	{
	}

	private void _003CDelayHideEffect_003Eb__19_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}
}
