using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityV2FriendReunionTitleView : UIBaseView
{
	public UILabel Title;

	public UIButton DetailButton;

	public GameObject SelfLink;

	public GameObject TeamScore;

	public UIButton LinkButton;

	public UILabel LinkLabel;

	public UILabel TeamScoreLabel;

	public UILabel ScoreVal;

	public Transform RightCon;

	public UILabel NormalLabel;

	public Transform RightConTransForBigType;

	public Transform RightConTransForNormalType;

	public Transform RightConTransForInvitee;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
