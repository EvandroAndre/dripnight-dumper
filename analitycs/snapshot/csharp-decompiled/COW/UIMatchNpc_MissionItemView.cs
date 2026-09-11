using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchNpc_MissionItemView : UIBaseView
{
	public UILabel LabelDescription;

	public GameObject LabelReceived;

	public UIButton BtnReceive;

	public GameObject GoAwarded;

	public UINetworkTexture TextureBg;

	public UILabel LabelProcess;

	public UIGrid GridAwards;

	public GameObject GotoBtnGo;

	public UIButton GotoBtn;

	public UINetworkTexture SpriteGotoBg;

	public UILabel LabelAwarded;

	public UISprite SpriteAwardedBg;

	public UINetworkTexture TextureReceiveBg;

	public GameObject SpriteReceiveBg;

	public UINetworkTexture TextureReceiveBg2;

	public GameObject SpriteReceivedBg2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
