using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHotMapView : UIBaseView
{
	public UILabel LabelTag;

	public UINetworkTexture CDNMapIcon;

	public UISprite MapIcon;

	public UILabel NameTxt;

	public UIButton UIUGCHotMap;

	public GameObject GameMap;

	public UITexture GameBitMap;

	public UITexture GameBitOutLineMap;

	public UISprite IconItemSpite;

	public UILabel TimeText;

	public UITexture GameMapBg;

	public GameObject InfoContainer;

	public GameObject LockState;

	public UILabel LockTxt;

	public UISprite WarningIcon;

	public Transform HotContainer;

	public GameObject NewUpdateTip;

	public UINetworkTextureExt KolMapIcon;

	public UIButton KolMapIconButton;

	public UIButton UGCVip;

	public GameObject OfflineTag;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
