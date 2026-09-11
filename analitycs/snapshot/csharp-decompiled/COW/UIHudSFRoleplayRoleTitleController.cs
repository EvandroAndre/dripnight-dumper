using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSFRoleplayRoleTitleController : UIHudNameBaseController
{
	private UIHudSFRoleplayRoleTitleView m_View;

	private uint m_DelayCallHideID;

	private BHGGAEEHJCO m_PlayerID;

	private Vector3 m_IconOffset;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
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

	private void _003CBindPlayer_003Eb__8_0()
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
