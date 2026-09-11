using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCGameModeMapPickItemView : UIBaseView
{
	public UIButton BtnPick;

	public UILabel LabelName;

	public GameObject GoPick;

	public UINetworkTextureExt NetworkTexture;

	public UIButton TipBtn;

	public GameObject VFXContainer;

	public UISprite BG;

	public GameObject HeatInfo;

	public Transform DownloadContainer;

	public GameObject DownloadBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
