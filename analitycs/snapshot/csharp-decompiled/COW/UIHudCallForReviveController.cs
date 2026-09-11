using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudCallForReviveController : UIBaseController
{
	private UIHudCallForReviveView m_View;

	private bool m_IsDuringCD;

	private float m_CDEndTime;

	private float m_CurrentCDTime;

	private float m_TotalCDTime;

	private Vector3 m_AutoEnemyMarkPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnBtnActionClick()
	{
	}

	private void OnCallForReviveEnterCD(float CD)
	{
	}

	private void Update()
	{
	}

	private void SetBtnClickable(bool enable)
	{
	}

	private void OnAbandonLifeShow(object[] data)
	{
	}

	private void OnLocalPlayerDead(object[] data)
	{
	}

	private void OnLocalPlayerRevive(object[] data)
	{
	}

	private void OnAutoEnemyMarkUpdateMarkPos(object[] data)
	{
	}

	private void RequestAutoEnemyMark()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
