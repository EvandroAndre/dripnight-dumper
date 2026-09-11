using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudFollowEmoteController : UIBaseController, INotifyHudConfigChanged
{
	private UIHudFollowEmoteView m_View;

	public static int UPDATE_INTERVAL_FRAME_COUNT;

	private BHGGAEEHJCO m_FollowBtnFollowPlayerID;

	private int m_FollowTeamIndex;

	private const string FOLLOW_EMOTE_GLOW_ONCE_EFFECT = "UIFX_UIHUDFOLLOWEMOTE_GLOWONCE";

	private const string FOLLOW_EMOTE_LOADING_EFFECT = "UIFX_UIHUDFOLLOWEMOTE_LOADING";

	private const string FOLLOW_EMOTE_STAND_TIPS = "TXT_OB11_JRW_EMOTE_WAITINGLAND_TIP01";

	private const float FOLLOW_EMOTE_GLOW_ONCE_LIFETIME = 0.5f;

	private ResourceID m_FollowEmoteGlowOnceEffect;

	private ResourceID m_FollowEmoteLoadingEffect;

	private uint m_DriverLoadingEffect;

	private uint m_FollowLoadingEffect;

	private bool m_HaveShowDriverBtn;

	private bool m_HaveShowFollowBtn;

	private bool m_CheckCanClickBtn;

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

	public void NotifyHudConfigChanged(HudConfigItem config)
	{
	}

	private void ApplyAlpha(float alpha)
	{
	}

	private void ApplyButtonAlpha(UIButton btn, float alpha)
	{
	}

	private void HideAllBtn()
	{
	}

	private void OnFollowMessageResponse()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	private void UpdateFollowEmoteBtnStateByDistanceandview(Player localPlayer, MatchTeam localTeam)
	{
	}

	private void UpdateFollowEmoteBtnStateByDistance(Player localPlayer, MatchTeam localTeam)
	{
	}

	private bool IsTeammateInFollowEmoteViewDistance(Player teammatePlayer)
	{
		return false;
	}

	private bool CanFollowEmoteTarget(Player target)
	{
		return false;
	}

	private void OnDriverBtnClick()
	{
	}

	private void OnFollowBtnClick()
	{
	}

	private void ShowDriverBtn()
	{
	}

	private void ShowFollowBtn(int followIndex)
	{
	}

	private void HideAllFollowTarget()
	{
	}

	private void HideFollowBtn()
	{
	}

	private void HideDriverBtn()
	{
	}

	private void PlayGlowOnceEffect(GameObject effectRoot)
	{
	}

	private void InitLoadingEffects()
	{
	}

	private void InitLoadingEffect(Transform root, ref uint holder)
	{
	}

	private void DetachLoadingEffects()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
