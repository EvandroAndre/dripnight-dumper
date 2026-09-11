using GCommon;
using UnityEngine;

namespace COW;

public class UIAccountForbiddenPopWndMidView : UIBaseView
{
	public UILabel ForbiddenReasonTxt;

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

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
