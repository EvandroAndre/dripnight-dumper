using GCommon;
using UnityEngine;

namespace COW;

public class UIGroupNewRecruitView : UIBaseView
{
	public UIButton ModeBtn;

	public UIWidget ModeWidget;

	public UILabel GameModeLabel;

	public UIButton GroupBtn;

	public UIWidget GroupWidget;

	public UILabel GroupModeLabel;

	public UIToggle WorldToggle;

	public UIWidget WorldWidget;

	public BoxCollider WorldClick;

	public UILabel WorldLabel;

	public UIToggle ClanToggle;

	public UIWidget ClanWidget;

	public BoxCollider ClanClick;

	public UIButton RecruitBtn;

	public UIWidget SendWidget;

	public UIButton RankTipsBtn;

	public UILabel CSSpecialName;

	public GameObject CSSpeicalMatchContainer;

	public UITable TagTable;

	public UIButton StopRecruitBtn;

	public UIButton SaveBtn;

	public GameObject HighLightSave;

	public GameObject GreySave;

	public Transform RankMinContainer;

	public Transform RankMaxContainer;

	public GameObject MapBonusContainer;

	public UISprite MapBonusIcon;

	public UIToggle CsSpecialToggle;

	public UIToggle MapBonusToggle;

	public UILabel RecruiteTagChooseLabel;

	public UITable ExtralTable;

	public UITable ContentTable;

	public GameObject ExtraContainer;

	public GameObject LadderLimitContainer;

	public GameObject SendToContainer;

	public UITable SendToTable;

	public GameObject BannedTrioTips;

	public GameObject CSPeakTournamentContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
