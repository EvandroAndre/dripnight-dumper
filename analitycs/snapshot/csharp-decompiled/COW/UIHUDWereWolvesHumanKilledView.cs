using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDWereWolvesHumanKilledView : UIBaseView
{
	public UISprite WolfIcon;

	public UISprite WolfIndexBg;

	public UILabel WolfNum;

	public UISprite HumanIcon;

	public UISprite HumanIndexBg;

	public UILabel HumanNum;

	public GameObject FinalKillRoot;

	public GameObject CommonKillRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
