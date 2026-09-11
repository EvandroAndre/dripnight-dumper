using GCommon;
using UnityEngine;

namespace COW;

public class UIGameModeMapPickItemView : UIBaseView
{
	public UIButton BtnPick;

	public UILabel LabelName;

	public GameObject GoPick;

	public Transform RootDownloader;

	public GameObject GoTimeLimit;

	public UILabel LabelTimeLimitTop;

	public UINetworkTexture NetworkTexture;

	public GameObject GoLock;

	public UIButton MapProtectionBtn;

	public GameObject MapProtection;

	public UILabel MapProtectionLabel;

	public GameObject SpritePickTick;

	public GameObject SpriteFrame;

	public GameObject RankLimitNode;

	public UISprite IconRankLimit;

	public UILabel LabelRankLimit;

	public GameObject NewTag;

	public GameObject NewTagWithFrame;

	public GameObject MapProtectionTop;

	public UILabel MapProtectionTopLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
