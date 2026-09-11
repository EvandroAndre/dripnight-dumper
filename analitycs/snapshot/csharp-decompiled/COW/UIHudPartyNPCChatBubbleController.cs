using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPartyNPCChatBubbleController : UIHudNameBaseController
{
	private UIHudPartyNPCChatBubbleView m_View;

	private NetworkAIPawn_NPC m_NPCOwner;

	private uint m_HideDelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetOwner(NetworkAIPawn_NPC npc)
	{
	}

	public void SetChatMessage(string message, float duration)
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	private void _003CSetChatMessage_003Eb__6_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}
}
