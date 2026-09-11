using GCommon;
using UnityEngine;

namespace COW;

public class UIChatRecruitItemView : UIBaseView
{
	public UISprite BG;

	public Transform ProfileContainer;

	public UILabel Mode;

	public UILabel Tag1;

	public UILabel Tag2;

	public UIButton JoinGroupBtn;

	public GameObject GroupRoot;

	public UISprite LadderMinIcon;

	public UILabel Map;

	public UILabel GroupMode;

	public GameObject ClanSourceIcon;

	public GameObject ClanGroupRoot;

	public UIGrid ClanGroupGrid;

	public UISprite ClanLadderIcon1;

	public UISprite ClanLadderIcon2;

	public UISprite ClanGroupIcon;

	public UILabel ClanGroupName;

	public UILabel ClanGroupMember;

	public GameObject GameBufIcon;

	public UISprite GameBufIconSprite;

	public UISprite LadderMaxIcon;

	public UITable TagTable;

	public UILabel LabelNum;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
