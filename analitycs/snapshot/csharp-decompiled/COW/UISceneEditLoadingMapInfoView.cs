using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditLoadingMapInfoView : UIBaseView
{
	public UILabel MapName;

	public UILabel MapRound;

	public UILabel MapPlayer;

	public UILabel MapDesc;

	public UITable Table;

	public UIScrollView SV;

	public UISprite MapIcon;

	public GameObject GameMap;

	public UITexture GameMapBg;

	public UITexture GameBitMap;

	public UITexture GameBitOutLineMap;

	public UISprite IconItemSpite;

	public UINetworkTexture CDNMapIcon;

	public UILabel ModeName;

	public Transform Container;

	public Transform Tags;

	public Transform LikeRate;

	public GameObject UpdateNewTip;

	public UITexture GameBitOutLineMap2;

	public GameObject OfflineTag;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
