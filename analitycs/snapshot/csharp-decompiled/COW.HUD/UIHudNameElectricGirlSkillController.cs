using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

internal class UIHudNameElectricGirlSkillController : UIBaseController
{
	public enum Status
	{
		None,
		LowHp,
		BindPlayer,
		BindPlayerKnockDown
	}

	private UIHudNameElectricGirlSkillView m_View;

	public Transform CachedTransform;

	private BHGGAEEHJCO m_PlayerId;

	private int m_LowHpLine;

	private int? m_LastDirection;

	private Status m_CurStatus;

	private int m_PrevDistance;

	private int m_LastDistancePrintLength;

	private bool m_UpdateDisInterval;

	private float m_LastHpFillAmount;

	private bool? m_PlayerIsDieing;

	private bool m_UpdateHpInterval;

	private float m_BigHealTargetHpHideTs;

	private int m_EaseOutTick;

	private Vector3 m_TableStartLocalPos;

	private Vector3 m_TableTargetLocalPos;

	private float m_NameLabelOffset;

	private float m_TableHalfWidth;

	private float m_TableHalfHeight;

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

	public bool BindPlayer(BHGGAEEHJCO playerId)
	{
		return false;
	}

	public bool BindPlayer(BHGGAEEHJCO playerId, int lowHpLine)
	{
		return false;
	}

	public void SetStatus(Status status)
	{
	}

	public void ShowArrow(UIHudNameController.EArrowDirection direction)
	{
	}

	private void UpdateDistanceText()
	{
	}

	private void UpdateTable(UIHudNameController.EArrowDirection direction)
	{
	}

	protected void LateUpdate()
	{
	}

	private void EaseOutPos()
	{
	}

	private void UpdatePlayerHp(bool force = false)
	{
	}

	private void OnActiveSkillStart(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}
}
