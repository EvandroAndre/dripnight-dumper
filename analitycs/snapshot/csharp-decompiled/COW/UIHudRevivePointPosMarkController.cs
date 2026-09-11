using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudRevivePointPosMarkController : UIHudNameBaseController
{
	private UIHudRevivePointPosMarkView m_View;

	private uint m_RevivePointId;

	private Vector3 m_RevivePointPos;

	private CMHCKKJBOFL m_CurrentState;

	private bool m_Advanced;

	private UIModelMatch m_ModelMatch;

	private int m_RevivePointMarkShowDis;

	private bool m_NeedUpdatePosition;

	private bool m_IsContainerActive;

	public bool IsSoloRevivePoint;

	public static Color ReviveIconNormal;

	public static Color ReviveBgNormal;

	public static Color ReviveSoloBgNormal;

	public static Color ReviveIconCD;

	public static Color ReviveBgCD;

	private Color RevivePointProgressNormal;

	private Color RevivePointProgressRed;

	private bool m_ShowActivityNode;

	private bool m_IsFighting;

	private UIHudActivityRevivePointIconController m_ActivityNode;

	private UITimeLabelHelper m_TimeHelper;

	private LevelRevivePoint m_CurrentRevivePoint;

	private Color m_CurrentColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	public void BindTarget(uint id, Vector3 target)
	{
	}

	private void ChangeIconRes(uint revivePointId)
	{
	}

	private void TryApplyPOIMissionCompletedIcon()
	{
	}

	private void OnPlayersChange(uint value)
	{
	}

	private void OnObserverChanged(object[] data)
	{
	}

	private void OnHidRevivePointMarkInSolo()
	{
	}

	private void OnUsingRevivePointStateChanged(uint data, uint oldValue)
	{
	}

	private void OnPlayerCountChanged(int value)
	{
	}

	private void UpdateTeam()
	{
	}

	private void SetIconTween(bool value)
	{
	}

	public void Reset()
	{
	}

	private void TryShowTeamInfo()
	{
	}

	private bool IsCapturing()
	{
		return false;
	}

	public void SetState(CMHCKKJBOFL state)
	{
	}

	public void SetTime(int time)
	{
	}

	public void SetAdvanced(bool advanced)
	{
	}

	private void RefreshState()
	{
	}

	private void Update()
	{
	}

	protected override void OnDistanceChanged(float distance)
	{
	}

	private void UpdateExitReviveView()
	{
	}

	private void UpdateEnterReviveView()
	{
	}

	private void OnEnterRevivePoint(object[] data)
	{
	}

	private void OtherEnterLeavePoint(bool enter)
	{
	}

	private void OnLocalPlayerDead(object[] data)
	{
	}

	private void OnLocalPlayerRevive(object[] data)
	{
	}

	private void UpdateFightingState()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		return default(Vector2);
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDistanceChanged(float P0)
	{
	}
}
