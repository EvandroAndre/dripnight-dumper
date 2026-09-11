using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassEXPShareView : UIBaseView
{
	public UIButton RuleBtn;

	public UIButton LeaderBoardBtn;

	public UIButton CloseBtn;

	public UIEasyList FriendEasyList;

	public UIButton MaskClick;

	public UILabel GainLabel;

	public GameObject AddFriendCon;

	public GameObject NoFriendsCon;

	public UIButton AddFrinedBtn;

	public UIButton ClaimOrSendBtn;

	public UIPanel GuideMaskPanel;

	public UIButton GuideMask;

	public GameObject EXPShareToEXPGainUIFXTrail;

	public UIScrollView EXPScrollView;

	public Animation UIFX_EXPGain;

	public UILabel ClaimOrSendLabel;

	public UISprite ClaimAllBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
