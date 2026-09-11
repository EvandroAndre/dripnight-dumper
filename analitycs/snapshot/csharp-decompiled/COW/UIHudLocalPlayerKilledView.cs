using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLocalPlayerKilledView : UIBaseView
{
	public UISprite MaskBG;

	public UILabel KillMsg;

	public Animation KillInfoContainer;

	public GameObject ProfileContainer;

	public UILabel killerMsg;

	public GameObject NormalContainer;

	public UILabel NormalName;

	public GameObject NormalNode;

	public GameObject ClanGuideNode;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
