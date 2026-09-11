using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPlayerMarkView : UIBaseView
{
	public UISprite Icon;

	public Transform Root;

	public UIWidget AreaWidget;

	public GameObject EnemyMark;

	public UILabel Label;

	public UILabel M_Label;

	public GameObject InteractingIconBG;

	public Animation InteractingIconAnimation;

	public UISprite InteractingIcon1;

	public UISprite InteractingIcon2;

	public UISprite InteractingIcon3;

	public UISprite InteractingIcon4;

	public Transform Distance;

	public UISprite InteractingAnimIcon;

	public GameObject WhiteEffect;

	public GameObject RedEffect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
