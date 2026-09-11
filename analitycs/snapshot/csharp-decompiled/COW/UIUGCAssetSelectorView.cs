using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCAssetSelectorView : UIBaseView
{
	public UIButton ButtonConfirm;

	public UIEasyList Grid;

	public GameObject DownloadAll;

	public UILabel LabelName;

	public UILabel LabelSize;

	public UILabel LabelDuration;

	public UILabel LabelType;

	public UILabel LabelDate;

	public UILabel LabelPixel;

	public UITexture TextureIcon;

	public UINetworkTexture NetworkTextureIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
