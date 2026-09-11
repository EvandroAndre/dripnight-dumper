using GCommon;
using UnityEngine;

namespace COW;

public class UIPhotoWallShowView : UIBaseView
{
	public GameObject UIPhotoWallShow;

	public UINetworkTexture DefaultSprite;

	public UINetworkTexture PhotoWallTexture;

	public UIButton ShareBtn;

	public UIButton EditBtn;

	public GameObject BanTipNode;

	public GameObject GrayBtn;

	public UICountDownLabel EditBtnCountDownLabel;

	public UINetworkTexture PhotoWallBoard;

	public UINetworkTexture PhotoWallBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
