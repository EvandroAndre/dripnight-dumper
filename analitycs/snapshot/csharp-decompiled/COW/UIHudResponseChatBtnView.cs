using GCommon;
using UnityEngine;

namespace COW;

public class UIHudResponseChatBtnView : UIBaseView
{
	public UISprite CDBlock;

	public GameObject Icon;

	public UISprite IconSprite;

	public UILabel DescLabel;

	public UIButton IconBg;

	public UIButton DescBg;

	public UILabel ResponseIndex;

	public UISprite ResponseBG;

	public GameObject ResponseChatContainer;

	public GameObject AutoEnemyMarkContainer;

	public UIButton AutoEnemyMarkBtn;

	public UISprite ResponseRing;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
