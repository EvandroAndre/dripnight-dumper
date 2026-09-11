using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomCard_Main_FiveView : UIBaseView
{
	public Animation main;

	public UINetworkTexture DrawOneTexture;

	public UIButton DrawOneBtn;

	public UILabel DrawOneLabel;

	public GameObject TokenDrawOneConsume;

	public UISprite TokenDrawOneIcon;

	public UILabel TokenDrawOneCount;

	public UIButton FloorRewardBoxBtn;

	public UINetworkTexture FloorRewardBoxTexture;

	public Transform FloorRewardBoxEffectParent;

	public UIButton JackpotBtn;

	public UINetworkTexture JackpotBtnTexture;

	public UILabel JackpotLabel;

	public Transform Card_One;

	public Transform Card_Two;

	public Transform Card_Three;

	public Transform Card_Four;

	public Transform Card_Five;

	public Transform Card_Six;

	public UILabel DrawFiveLabel;

	public GameObject TokenDrawFiveConsume;

	public UISprite TokenDrawFiveIcon;

	public UILabel TokenDrawFiveCount;

	public UINetworkTexture DrawFiveTexture;

	public UIButton DrawFiveBtn;

	public UINetworkTexture FloorRewardSmallBoxTex;

	public UIButton FloorRewardSmallBoxBtn;

	public GameObject FloorRewardTips;

	public GameObject Draw;

	public GameObject SpriteRedDot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
