using System.Collections.Generic;
using UnityEngine;
using proto;

namespace COW;

public class UIHudMatchResultStateMachine
{
	private Dictionary<int, UIHudMatchResultStateBase> m_States;

	private UIHudMatchResultStateBase m_CurrentState;

	private MatchStats m_MatchStatsData;

	private MatchIncome m_MatchIncomeData;

	private bool m_HasShowMVP;

	private TeammateStats m_MVPData;

	private UIMaleAvatar m_MVPAvatar;

	private bool m_IsWin;

	private Camera m_ResultBGCamera;

	private Camera m_ResultAvatarCamera;

	private Camera m_ResultMVPCamera;

	private GameObject m_MVPRoomOB;

	private GameObject m_MVPCameraOB;

	private UIHudMatchResultStateMachineFinishDelegate fnStateMachineFinish;

	private Dictionary<int, UIHudMatchResultStateBase> States => null;

	public UIHudMatchResultStateBase CurrentState => null;

	public MatchStats StatsData => null;

	public MatchIncome IncomeData => null;

	public bool HasShowMVP
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public TeammateStats MVPData => null;

	public UIMaleAvatar MVPAvatar => null;

	public bool IsWin => false;

	public Camera ResultBGCamera => null;

	public Camera ResultAvatarCamera => null;

	public Camera ResultMVPCamera => null;

	public UIHudMatchResultStateMachine(MatchStats stats, MatchIncome income)
	{
	}

	public void GoTo(EUIHudMatchResultState state)
	{
	}

	public void InitData(TeammateStats mvpData, UIMaleAvatar avatar, Camera bgCamera, Camera avatarCamera, bool win, UIHudMatchResultStateMachineFinishDelegate fnFinish)
	{
	}

	public void SetMVPRoomObject(GameObject mvpRoom, GameObject mvpCameraOB)
	{
	}

	public void DestroyMVPRoomObject()
	{
	}

	public bool CanShowMVP()
	{
		return false;
	}

	public void EnableResultCamera(bool enable)
	{
	}

	private void InitStates()
	{
	}

	private void EnterStateMachine()
	{
	}

	private void ExitStateMachine()
	{
	}

	private void OnHandleStateFinish(object[] param)
	{
	}
}
