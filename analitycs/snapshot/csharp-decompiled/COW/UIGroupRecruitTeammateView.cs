using GCommon;
using UnityEngine;

namespace COW;

public class UIGroupRecruitTeammateView : UIBaseView
{
	public UILabel GameModeLabel;

	public UILabel GroupModeLabel;

	public UIToggle WorldToggle;

	public UIWidget WorldWidget;

	public UILabel WorldLabel;

	public UIToggle ClanToggle;

	public UIWidget ClanWidget;

	public UITable TagTable;

	public Transform RankMinContainer;

	public Transform RankMaxContainer;

	public UISprite RankMinIcon;

	public UILabel RankMinLabel;

	public UISprite RankMaxIcon;

	public UILabel RankMaxLabel;

	public UISprite MapBonusIcon;

	public UITable ExtraTable;

	public UILabel CsSpecialLabel;

	public UIToggle CsSpecialToggle;

	public UIToggle MapBonusToggle;

	public UITable ContentTable;

	public GameObject ExtraContainer;

	public GameObject SendToContainer;

	public UILabel ClanLabel;

	public GameObject TagContainer;

	public GameObject LadderLimitContainer;

	public Transform RankMinBRIcon;

	public Transform RankMaxBRIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
