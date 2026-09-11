using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIDuoEmoteInviteBubbleController : UIBaseController
{
	private UIDuoEmoteInviteBubbleView m_View;

	private uint m_EmoteId;

	private GroupMemberInfo m_MemberInfo;

	private uint m_CountDownDelayCall;

	private float m_CountDownTimer;

	private ResourceID m_JoinRemindSFX;

	private GameObject m_JoinRemindSFXOBJ;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void HideAndStopEmote()
	{
	}

	public void HideWhenTimeOut()
	{
	}

	private void HideByAccountId(ulong accountId)
	{
	}

	private void HideWhenEmoteFinish(GEvent _data)
	{
	}

	private void HideWhenShowEmotes(GEvent _data)
	{
	}

	public float SetData(uint emoteId, GroupMemberInfo memInfo)
	{
		return 0f;
	}

	private void RefreshCountDown()
	{
	}

	private void OnJoinBtnClick()
	{
	}

	private void StopJoinRemindSFX()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
