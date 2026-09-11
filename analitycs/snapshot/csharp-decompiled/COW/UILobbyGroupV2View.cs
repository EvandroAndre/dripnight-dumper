using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyGroupV2View : UIBaseView
{
	public GameObject ChampionshipTeamInfo;

	public UILabel ChampionshipTeamName;

	public UIButton readyBtn;

	public UILabel readyLabel;

	public GameObject Ready;

	public UILabel ReadyText;

	public GameObject CancelReady;

	public UILabel CancelReadyText;

	public UISprite readyBtnSprite;

	public UIButton playBtn;

	public UIWidget StartGameWidget;

	public UILabel StartLabel;

	public UISprite AllReadySprite;

	public UISprite NotReadySprite;

	public GameObject championshipInfo;

	public UIButton TicketBtn;

	public UISprite ItemIcon;

	public UILabel TicketNum;

	public GameObject OpenTime;

	public UILabel OpenTimeLabel;

	public GameObject cupMatchInfo;

	public UILabel CupOpenTimeLabel;

	public UIToggle cupTicketToggle;

	public UISprite CupTicketUnSelect;

	public UISprite CupTicketSelect;

	public UILabel CupTicketIconLabel;

	public GameObject ReadyEffect;

	public GameObject Guide_start_Anim_Ready_Effect;

	public GameObject MatchMaking;

	public UILabel MulMatchLabel;

	public UISprite MulMatchIcon;

	public GameObject CupTeamLocking;

	public UILabel CupTeamLockLabel;

	public UISprite CupTeamLockIcon;

	public GameObject HDInCaptainLobby;

	public UILabel CaptainName;

	public UIButton BtnTeamInfo;

	public Transform ReadyEffectVFX;

	public GameObject ReadyVfxSkinChange;

	public GameObject StartIconVFX;

	public GameObject NotReadyNotify;

	public GameObject InRoom;

	public UIButton InRoomBtn;

	public UILabel InRoomLabel;

	public UISprite InRoomBG;

	public UITable InfoGrid;

	public UILabel TeamScore;

	public GameObject CupMatchTeamInfo;

	public UILabel CupMatchTeamName;

	public UIButton BtnRankLimit;

	public GameObject CupTeamTier;

	public UILabel TierLevel;

	public UISprite TeamStatusLight;

	public UISprite TeamStatus;

	public Transform RankLimitPoint;

	public UISprite RankLimitIcon;

	public GameObject Remind;

	public Animation BellAnim;

	public UILabel RemindStartLabel;

	public Animation RemindProgressAnim;

	public GameObject TeamCodeUpdateTips;

	public GameObject VFXEffectRoot;

	public GameObject TeamRankLimit;

	public UILabel TeamInfoLabel;

	public UISprite TeamRankLimitMinRank;

	public UISprite TeamRankLimitMaxRank;

	public GameObject TeamRankLimitRange;

	public GameObject TeamRankNoLimit;

	public UILabel TeamRankNoLimitLabel;

	public UISprite TeamRankNoLimitRole;

	public UILabel TeamRankNoLimitCount;

	public UILabel TeamRankLimitCount;

	public GameObject BannedTrio;

	public UIButton TeamRankLimitBtn;

	public UISprite TeamRankLimitBg;

	public UITable LimitStateTable;

	public UISprite TeamRankLimitRangeRole;

	public GameObject Recruiting;

	public UILabel SpecialBgStartLabel;

	public UILabel DefaultStyleLabel;

	public UIButton RecruitBtn;

	public UILabel RecruitLabel;

	public UISprite RecruitBtnSprite;

	public UIPanel UILobbyGroupV2;

	public GameObject InHippoCrisis;

	public GameObject BanMatchContainer;

	public UILabel BanMatchLabel;

	public Transform BanMatchTime;

	public UIButton BanMatchBtn;

	public UISprite InHippoCrisisBG;

	public UIButton InHippoCrisisBtn;

	public Transform InGameTeamInfoContainer;

	public GameObject NewbieRecruitRoot;

	public GameObject TeamRankLimitTipContainer;

	public UIButton TeamRankLimitTipBtn;

	public GameObject TeamRankLimitTipSoftBg;

	public VFXCreateHelper TeamRankLimitTipSoftHelper;

	public GameObject TeamRankLimitTipHardBg;

	public VFXCreateHelper TeamRankLimitTipHardHelper;

	public UILabel TeamRankLimitTipLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
