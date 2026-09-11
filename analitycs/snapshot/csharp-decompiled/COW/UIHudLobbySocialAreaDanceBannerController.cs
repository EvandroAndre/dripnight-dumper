using GCommon;

namespace COW;

public class UIHudLobbySocialAreaDanceBannerController : UIBaseController
{
	private UIHudLobbySocialAreaDanceBannerView m_View;

	private uint m_DelayCallID;

	private uint m_IconTicket;

	private float m_LastShowTime;

	private ELobbySocialAreaBannerType m_CurrentType;

	private const float BANNER_DURATION = 3f;

	private const string DanceIconSprite = "FF_UI_Ninth_SocialLobby_Hud_DanceGold_01";

	private const string CarryIconSprite = "FF_UI_Ninth_SocialLobby_Hud_LiftGold_03";

	private const string DanceLocKey = "T_54_ZCS_SOCIALLOBBY_DANCE_DANCENOW";

	private const string CarryNoticeLocKey = "T_54_ZCS_SOCIALLOBBY_SRB_NOTICECARRY";

	private const string RideNoticeLocKey = "T_54_ZCS_SOCIALLOBBY_SRB_NOTICERIDE";

	public ELobbySocialAreaBannerType CurrentType => ELobbySocialAreaBannerType.None;

	public bool IsShowing => false;

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

	protected override void OnDestroy()
	{
	}

	public void ShowDanceBanner(bool ignoreCd = false)
	{
	}

	public void ShowCarryNotice(bool isCarrier)
	{
	}

	private void ShowBannerInternal(ELobbySocialAreaBannerType type, string locKey, string iconSprite)
	{
	}

	private void SetIconAsync(string spriteName)
	{
	}

	private void CancelIconLoad()
	{
	}

	private void AutoHide()
	{
	}

	private void CancelDelayCall()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
