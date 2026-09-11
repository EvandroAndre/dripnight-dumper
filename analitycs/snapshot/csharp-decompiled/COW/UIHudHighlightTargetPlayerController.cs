using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHighlightTargetPlayerController : UIHudNameBaseController
{
	private UIHudHighlightTargetPlayerView m_View;

	private BHGGAEEHJCO m_PlayerID;

	private Vector3 m_IconOffset;

	private uint m_AttachedMaxLevelVFXUniqueID;

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

	protected override void OnVisibilityChanged()
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

	public void BindPlayer(BHGGAEEHJCO player_id)
	{
	}

	public void DetachVFX()
	{
	}

	public void OnShowAddFriendPlayerVFX(BHGGAEEHJCO playerID)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
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
}
