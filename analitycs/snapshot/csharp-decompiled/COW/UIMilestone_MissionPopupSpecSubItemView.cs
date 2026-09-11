using GCommon;
using UnityEngine;

namespace COW;

public class UIMilestone_MissionPopupSpecSubItemView : UIBaseView
{
	public UILabel LabelDescription;

	public GameObject LabelReceived;

	public UIButton BtnReceive;

	public GameObject GoAwarded;

	public UINetworkTexture TextureBg;

	public UILabel LabelProcess;

	public UIGrid GridAwards;

	public UINetworkTexture SpriteReceivedBg;

	public UINetworkTexture SpriteReceiveBg;

	public GameObject GotoBtnGo;

	public UIButton GotoBtn;

	public UINetworkTexture SpriteGotoBg;

	public UISprite TimeIcon;

	public Transform Effect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
