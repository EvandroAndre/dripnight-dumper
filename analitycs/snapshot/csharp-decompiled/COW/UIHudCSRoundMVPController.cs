using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudCSRoundMVPController : UIHudNameBaseController
{
	private UIHudCSRoundMVPView m_View;

	private BHGGAEEHJCO m_PlayerID;

	private uint m_AttachedVFXUniqueID;

	private CIJPLNEAIIH m_LastPhase;

	private uint m_DelayCallHideMVPVFXID;

	private const float m_DelayCallHideMVPVFXTime = 5f;

	private Vector3 m_IconOffset;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnNewPhaseStarted(object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	public void BindPlayer(BHGGAEEHJCO player_id)
	{
	}

	public void UnBindPlayer()
	{
	}

	private void ShowPlayerMVP()
	{
	}

	private void DetachMVPVFX()
	{
	}

	private void HideMVPContainer()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}
}
