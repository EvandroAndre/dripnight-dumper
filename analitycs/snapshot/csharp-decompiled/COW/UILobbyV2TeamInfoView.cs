using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2TeamInfoView : UIBaseView
{
	public UIButton ClickMask;

	public GameObject GroupCodeDisplay;

	public UIButton CodeCopyBtn;

	public UILabel CodeLabel;

	public UIButton GroupCodeBtn;

	public UIButton GroupCodeHelperBtn;

	public UIGrid IconGrid;

	public UIGrid InfoGrid;

	public GameObject GroupCode;

	public UIButton GroupTeammate;

	public GameObject TeamRankLimit;

	public GameObject TeamRankLimitRange;

	public GameObject TeamRankNoLimit;

	public UISprite TeamRankLimitMinRank;

	public UISprite TeamRankLimitMaxRank;

	public UILabel TeamTitle;

	public UIButton TeamRankLimitTipsBtn;

	public GameObject Recruit;

	public UIButton RecruitBtn;

	public UITable Table;

	public GameObject Bottom;

	public UIButton TransferLeaderButton;

	public UIButton GroupKickOutButton;

	public UIButton QuitButton;

	public UIButton GroupQRCodeBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
