using GCommon;
using UnityEngine;

namespace COW;

public class UIQuickMessagePreviewItemView : UIBaseView
{
	public UILabel PreviewItemTxt;

	public Transform PreviewItemVoicePlayingVfxContainer;

	public GameObject PreviewItem;

	public Transform PreviewItemDownloadTrans;

	public UIButton PreviewItemBtn;

	public UISprite PreviewItemHighLight;

	public UISprite PreviewItemVoicePlayingIcon;

	public GameObject PreviewItemVoiceIcon;

	public UISprite PreviewItemVoicePlayingLine;

	public GameObject PreviewItemHighLightDefault;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
