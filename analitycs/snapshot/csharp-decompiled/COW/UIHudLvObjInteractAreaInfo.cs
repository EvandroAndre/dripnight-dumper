using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLvObjInteractAreaInfo : UIBaseController
{
	private const uint VISIBILITY_STATE_DETECTIVE_SCAN_WARNING = 67108864u;

	private UIHudLvObjInteractAreaInfoView m_View;

	private float m_FillAmount;

	private uint m_BindId;

	private float m_ProcessMax;

	private InteractiveState m_CurrentState;

	private int m_CurrentStep;

	private Vector3 m_InitPos;

	private bool m_Conflict;

	private List<GameObject> m_IconList;

	private bool m_PlayerIn;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnDetectiveScanWarningStateChanged(bool showing)
	{
	}

	private void OnConflictUIHUD(bool otherShow)
	{
	}

	private void ChangePos()
	{
	}

	private void OnTimeChanged(GEvent param)
	{
	}

	private void SetTime(int time, int[] interactTimes)
	{
	}

	private void OnStateChanged(GEvent param)
	{
	}

	private void SetIcon(int bigItemType)
	{
	}

	private void OnVisibleChanged(GEvent param)
	{
	}

	private void SetIcons(int[] interactTimes)
	{
	}

	private void RetsetProcess()
	{
	}

	private void UpdateTeamInfo(float fillAmount)
	{
	}

	private void OnPlayerCountChanged(object[] param)
	{
	}

	private void OnPlayerActiveChanged(object[] param)
	{
	}

	private bool CanShowTeamInfo()
	{
		return false;
	}

	private void PlayerCountChange(int value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
