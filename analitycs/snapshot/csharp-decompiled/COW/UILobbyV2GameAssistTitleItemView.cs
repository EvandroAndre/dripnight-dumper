using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2GameAssistTitleItemView : UIBaseView
{
	public UISprite Sprite;

	public UILabel IntroduceLabel;

	public UIButton GotoBtn;

	public GameObject CountDownContainer;

	public GameObject GotoContainer;

	public UICountDownLabel CountDownLabelTime;

	public GameObject ArrowExpland;

	public GameObject NormalRedPoint;

	public UILabel BattleReportTime;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
