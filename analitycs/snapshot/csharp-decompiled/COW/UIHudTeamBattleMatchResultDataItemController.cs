using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHudTeamBattleMatchResultDataItemController : UIHudMatchResultItemBaseController
{
	private UIHudTeamBattleMatchResultDataItemView m_View;

	private TeammateStats m_Player;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private uint m_SreakScrollCallId;

	private int m_scrollIndex;

	private bool m_IsCSRankRatingOpen;

	private float m_RatingNum;

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

	protected override void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	public void HandleGradeAndStreakPos(bool isConfigShowStreak = true)
	{
	}

	public void InitGradePanelDepth(int depth)
	{
	}

	private void StreakScroll()
	{
	}

	private void UpdatePlayerData(TeammateStats player)
	{
	}

	private void UpdateWinStreakIcon(uint playerStreakWins)
	{
	}

	public void SetCSRankRatingView(bool isMvp, bool isWin, bool isToxic, float ratingPoint)
	{
	}

	public override void OnChangePageType(EMatchResultPageType pageType)
	{
	}

	public void ShowRatingUIFX()
	{
	}

	protected void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetPlayerData(TeammateStats P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnChangePageType(EMatchResultPageType P0)
	{
	}
}
