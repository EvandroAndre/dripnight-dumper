using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisChatItemView : UIBaseView
{
	public UIEffectSprite ChatHeadIcon;

	public UILabel ChatNickname;

	public UILabel ChatMessageTxt;

	public UISprite ChatFactionIcon;

	public UILabel ChatTimeTxt;

	public UILabel SystemMessageTxt;

	public UILabel SystemTimeTxt;

	public GameObject SystemContent;

	public GameObject SelfContent;

	public GameObject ChatContent;

	public UIEffectSprite SelfHeadIcon;

	public UILabel SelfNickname;

	public UILabel SelfMessageTxt;

	public UISprite SelfFactionIcon;

	public UILabel SelfTimeTxt;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
