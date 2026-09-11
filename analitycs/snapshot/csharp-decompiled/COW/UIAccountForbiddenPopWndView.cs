using GCommon;
using UnityEngine;

namespace COW;

public class UIAccountForbiddenPopWndView : UIBaseView
{
	public UILabel ReasonText;

	public UIButton ConfirmBtn;

	public UIButton HelpBtn;

	public Transform CountDownContainer;

	public UIEffectSprite PersonHeadSprite;

	public UISprite PersonFakeSprite;

	public UILabel Personlevel;

	public UILabel Info;

	public UISprite PersonProfileInfobg;

	public UISprite PersonProfileInfobgLow;

	public GameObject PersonfakeBg;

	public GameObject PersonfakeLow;

	public UILabel HelpTxt;

	public UILabel UnbindRemindLabel;

	public UIButton ReCheckBtn;

	public UIButton DeleteAccountBtn;

	public UILabel TopNoticeText1;

	public GameObject UnbanTimeText;

	public UITable ReasonAndTimeContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
