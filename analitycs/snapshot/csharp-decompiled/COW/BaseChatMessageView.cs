using GCommon;
using UnityEngine;

namespace COW;

public class BaseChatMessageView : MonoBehaviour
{
	public UIEffectSprite m_HeadPic;

	public UILabel m_NameLabel;

	public UILabel m_SendTimeLabel;

	public UISprite m_PinIcon;

	public UISprite m_LadderIcon;

	public UISprite m_CadetIcon;

	public UISprite m_PeakTournamentIcon;

	public UILabel m_PeakTournamentPointsLabel;

	public UISprite m_BannerBGNormal;

	public UISprite m_BannerBGVip;

	public UILabel m_Content;

	public UILabel m_AnchorContent;

	public UIButton m_ResendBtn;

	public UIButton m_JoinBtn;

	public UISprite m_StickerSprite;

	public GameObject m_TitleContainer;

	public UISprite m_TitleBg;

	public UILabel m_TitleLabel;

	public GameObject m_TitleEffect;

	private bool m_InitTitleEffect;

	public UIWidget m_LiftTopMessage;

	public GameObject m_ContentExtra;

	public UILabel m_ContentSystem;

	public UILabel m_AnchorContentSystem;

	public UISprite m_ContentSystemIcon;

	public GameObject m_PrivilegeIcon;

	public Transform AvatarFramePos;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

	public GameObject m_ActivityMsgOB;

	public GameObject m_LuckyBuffContainer;

	public GameObject m_EVOGunContainer;

	public GameObject m_SquadTreasureTeamContainer;

	public GameObject m_UGCShareContainer;

	public GameObject m_HUDShareContainer;

	public GameObject m_PrimeSetShareContainer;

	public UIButton m_GoposBtn;

	public UIWidget m_GoposWidget;

	public GameObject m_RelayMartDiscountCodeShareContainer;

	public GameObject m_ClanTrendContainer;

	private bool m_ShowInClanTrend;

	public Transform m_ContentContainer;

	public Transform m_ShowProfilePos;

	public Transform m_NotShowProfilePos;

	public Transform m_ChatMessageContent;

	private const uint DEFAULT_HEAD_ID = 902000003u;

	private MessageInfo m_Message;

	private Vector3 m_LadderIconPos;

	private Vector3 m_CadetIconPos;

	private Vector3 m_NameLabelPos;

	private Vector3 m_PinIconPos;

	private Vector3 m_PeakTournamentIconPos;

	private float m_ContentExtraYOffset;

	private int m_ContentSystemXOffset;

	private uint m_Gopos;

	private string m_SubGopos;

	private UISprite m_BannerBG;

	private Vector3 m_GrandmasterRankScale;

	private Vector3 m_DefaultRankScale;

	public void SetUIData(MessageInfo info)
	{
	}

	public void UpdatePin(uint pinId)
	{
	}

	public void RefreshAvatarFrame(MessageInfo info)
	{
	}

	private void MakeUpPosition()
	{
	}

	private void MakeUpPositionWithMentoring()
	{
	}

	public void NewBieChatItemResetNameLabelPos()
	{
	}

	private void ResetNameLabelPos()
	{
	}

	private void ShowPeakTournamentIcon(bool isShowPeakTournament, uint csPeakPoints)
	{
	}

	private void ShowCadetIcon(bool isCadet)
	{
	}

	public void SetInClanTrend(bool value)
	{
	}
}
