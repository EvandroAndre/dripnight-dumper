using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditRecommendMapItemView : UIBaseView
{
	public UIButton ItemBtn;

	public UINetworkTexture CDNMapIcon;

	public GameObject GameMap;

	public UITexture GameMapBg;

	public UITexture GameBitOutLineMap;

	public UITexture GameBitMap;

	public UISprite IconItemSpite;

	public UILabel ModeLabel;

	public UILabel NameTxt;

	public UILabel LikeCnt;

	public UILabel SubCnt;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
