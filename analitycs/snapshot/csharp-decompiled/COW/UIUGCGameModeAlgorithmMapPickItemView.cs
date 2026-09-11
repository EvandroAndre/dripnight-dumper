using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCGameModeAlgorithmMapPickItemView : UIBaseView
{
	public GameObject GoPick;

	public UINetworkTexture CDNMapIcon;

	public GameObject GameMap;

	public UITexture GameBitMap;

	public UITexture GameBitOutLineMap;

	public UISprite IconItemSpite;

	public UISprite MapIcon;

	public UITexture GameMapBg;

	public UIButton BtnPick;

	public Transform HeatInfo;

	public UILabel ModeName;

	public UILabel MapName;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
