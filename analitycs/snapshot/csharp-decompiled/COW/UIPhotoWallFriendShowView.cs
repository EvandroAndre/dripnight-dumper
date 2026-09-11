using GCommon;
using UnityEngine;

namespace COW;

public class UIPhotoWallFriendShowView : UIBaseView
{
	public GameObject UIPhotoWallFriendShow;

	public UINetworkTexture DefaultSprite;

	public UINetworkTexture PhotoWallTexture;

	public UIButton ReportBtn;

	public Transform BaseProfileNode;

	public Transform BanTipNode;

	public UINetworkTexture PhotoWallBG;

	public UINetworkTexture PhotoWallBoard;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
