using GCommon;
using UnityEngine;

namespace COW;

public class UICSPeakTournamentInvitationView : UIBaseView
{
	public UILabel TitleLabel;

	public UIButton ReadyBtn;

	public UILabel Label;

	public UILabel SeasonLabel;

	public UILabel SeasonTimeLabel;

	public UILabel DailyOpenLabel;

	public UIButton GoMatchBtn;

	public UILabel WelcomeLabel;

	public UIButton CloseBtn;

	public Transform PointsContainer;

	public UIGrid RewardGrid;

	public Animation WelComeAnim;

	public Animation InvitationAnim;

	public UINetworkTexture Card1_01;

	public UINetworkTexture Card1_02;

	public UINetworkTexture Card1Mask;

	public UINetworkTexture Card2_01;

	public UINetworkTexture Card2_02;

	public UINetworkTexture Card3_02;

	public UINetworkTexture Card3_01;

	public UISprite Reward01;

	public UISprite Reward02;

	public UISprite Reward03;

	public GameObject InfoLabel;

	public GameObject NormalDescLabel;

	public GameObject DirectAccess;

	public Transform StarIconPos;

	public Transform OnlySquadTrans;

	public UILabel SquadWelcomeLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
