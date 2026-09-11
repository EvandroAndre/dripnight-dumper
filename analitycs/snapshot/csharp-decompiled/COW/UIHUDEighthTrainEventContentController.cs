using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHUDEighthTrainEventContentController : UIBaseController, IGameMissionTopEventUI
{
	private enum EWaveState
	{
		EWaveState_Invalid,
		EWaveState_Wait,
		EWaveState_Active,
		EWaveState_Passed
	}

	private const float Const_BeginProgressPercent = 0.125f;

	private Color m_GrayColor;

	private UIHUDEighthTrainEventContentView m_View;

	private float TrainAppearTime;

	private float TrainWaitTime;

	private float m_CenterOneWaveProgressPercent;

	private List<float> m_AllWaveArrivedTimeList;

	private List<float> m_AllWaveLeaveTimeList;

	private List<uint> m_AllWaveTrainType;

	private Dictionary<int, EWaveState> m_CacheWaveState;

	private int m_LastPassedWaveIndex;

	private int m_CurDetailShowWaveIndex;

	private EWaveState m_CurDetailShowWaveState;

	private UITimeLabelHelper m_LeftTimeHelper;

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

	public float NeedHeight()
	{
		return 0f;
	}

	public void InitDataOnOpenFromGameMissionUI(object data)
	{
	}

	public void InitEventData(DGJMMMNFDKF msg)
	{
	}

	private string GetIconSpriteName(PHINPNKPLBG trainType, out string itemName)
	{
		itemName = null;
		return null;
	}

	private UISprite GetWaveIcon(int waveIndex)
	{
		return null;
	}

	private void CalcCurWave(float curServerTime)
	{
	}

	private void InitSetUIToNoPassedState()
	{
	}

	private void SetUIToAllPassedState()
	{
	}

	private void UpdateCalcProgressUI(float serverTime)
	{
	}

	private void RefreshCurWaveInfo(int newIndex, EWaveState newState)
	{
	}

	private void ToggleTrainTimeShowState(bool isHighlight)
	{
	}

	private void SetProgressItemState(int index, EWaveState state)
	{
	}

	private void Update()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void TickWaveState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
