using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudVoiceboxController : UIHudNameBaseController
{
	private UIHudVoiceboxView m_View;

	private BHGGAEEHJCO m_TargetPlayerID;

	private Player m_Player;

	private uint m_HideDelayCallID;

	private uint m_ShowDelayCallID;

	private float m_PointMarkShowDis;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnPlayerDead(object[] args)
	{
	}

	public void BindPlayer(BHGGAEEHJCO player_id, bool show, float delay, bool isMute, ulong account_id)
	{
	}

	public void UnBindPlayer()
	{
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected override void OnDistanceChanged(float distance)
	{
	}

	public void SetDistance(float value)
	{
	}

	protected override bool IsVisibleWithZoneType(int zonetype)
	{
		return false;
	}

	public void TryHide(BHGGAEEHJCO pid, float delay)
	{
	}

	private void DelayShow(float delay)
	{
	}

	private void ShowGameObject()
	{
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDistanceChanged(float P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsVisibleWithZoneType(int P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}
}
