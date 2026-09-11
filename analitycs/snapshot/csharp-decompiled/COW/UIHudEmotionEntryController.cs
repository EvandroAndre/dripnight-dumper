using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudEmotionEntryController : UIHudButtonBaseController
{
	private UIHudEmotionEntryView m_View;

	private bool m_ShowFollowEmoteEffect;

	private const float FOLLOW_EMOTE_OPEN_EMOTE_TIPS_DURATION = 5f;

	private const string FOLLOW_EMOTE_OPEN_EMOTE_TIPS_KEY = "T_54_SY_FOLLEWEMOTE_OPENEMOTE";

	private const string FOLLOW_EMOTE_OPEN_EMOTE_TIPS_ICON = "UI_Emote_Privilege_01_MoveEmote";

	private const string FOLLOW_EMOTE_OPEN_EMOTE_TIPS_EFFECT = "UIFX_UIHudTweenTips_Glow";

	public const uint VISIBILITY_STATE_CARRY = 134217728u;

	public const uint VISIBILITY_STATE_LOBBY_SOCIAL_HUD = 67108864u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitIsNewUI()
	{
	}

	private void OnGameLoadingOver(object[] data)
	{
	}

	private void OnShowTransformEffect(object[] data)
	{
	}

	private void OnShow(object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnUseMicrophone(object[] param)
	{
	}

	private void OnCarryStateChanged()
	{
	}

	private void OnLobbySocialHudStateChanged(bool visible)
	{
	}

	private void OnBtnEmotionEntryClick()
	{
	}

	private bool IsHavePaintSprayerItem()
	{
		return false;
	}

	private void RequestOpenEmotionPanel(bool tryShowFollowEmoteOpenTips = false)
	{
	}

	private void TryShowFollowEmoteOpenTips(Player localPlayer, Dictionary<uint, uint> emoteSlots)
	{
	}

	private UIHudTweenTipsController GetCurrentTweenTipsController()
	{
		return null;
	}

	private bool ShouldShowFollowEmoteOpenTips(Player localPlayer, Dictionary<uint, uint> emoteSlots)
	{
		return false;
	}

	private bool HasMoveEmoteOnWheel(Dictionary<uint, uint> emoteSlots)
	{
		return false;
	}

	public void ShowEmoteGuide()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
