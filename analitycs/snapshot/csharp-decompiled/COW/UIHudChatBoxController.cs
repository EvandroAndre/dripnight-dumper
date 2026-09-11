using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudChatBoxController : UIHudNameBaseController
{
	private UIHudChatboxView m_View;

	private BHGGAEEHJCO m_TargetPlayerID;

	private Player m_Player;

	private uint m_DelayCallID;

	private int m_StickWidth;

	private int m_StickHeight;

	private Vector3 m_DefaultStickerLocalPosition;

	private bool m_UseHudNameFollowNodePosition;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindPlayer(BHGGAEEHJCO player_id, string msg)
	{
	}

	public void UnBindPlayer()
	{
	}

	public bool IsValid()
	{
		return false;
	}

	public bool IsBoundToPlayer(BHGGAEEHJCO playerID)
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override void UpdateNamePosition()
	{
	}

	private void SetStickerLocalPositionForHudNameFollow(bool useHudNameFollowNode)
	{
	}

	private Transform GetTeammateChatBoxFollowNode()
	{
		return null;
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override bool IsVisibleWithZoneType(int zonetype)
	{
		return false;
	}

	private void _003CBindPlayer_003Eb__10_0()
	{
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

	public void _003C_003EiFixBaseProxy_UpdateNamePosition()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsVisibleWithZoneType(int P0)
	{
		return false;
	}
}
