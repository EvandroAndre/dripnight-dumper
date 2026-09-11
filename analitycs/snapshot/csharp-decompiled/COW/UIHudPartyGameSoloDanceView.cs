using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPartyGameSoloDanceView : UIBaseView
{
	public Transform ScoreInfo;

	public UILabel LabelScore;

	public UILabel LabelScorePopWithAnim;

	public Animation AddScoreAnim;

	public UIButton BtnQuitGame;

	public GameObject GoPreGame;

	public GameObject GoInvitor;

	public GameObject GoWaitingTip;

	public UIButton BtnInvite;

	public UISprite SpriteBtnInviteCD;

	public GameObject GoInvitePanel;

	public UIButton BtnInviteAll;

	public UIButton BtnInviteFriends;

	public UIButton BtnCloseInvite;

	public GameObject GoInGame;

	public Transform TrCountDownDuringGame;

	public UILabel LabelCountDownDuringGameKey;

	public UIWidget labelbgwidget;

	public UISprite SpriteCountDownDuringGameWarning;

	public UIWidget warningwidget;

	public UILabel LabelCountDownDuringGame;

	public TweenAlpha TweenAlpha;

	public GameObject GoCountDownOnStarting;

	public UILabel PreCountNum;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
