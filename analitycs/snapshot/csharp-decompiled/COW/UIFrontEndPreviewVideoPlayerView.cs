using GCommon;
using UnityEngine;

namespace COW;

public class UIFrontEndPreviewVideoPlayerView : UIBaseView
{
	public UITexture VideoTexture;

	public FFVideoPlayer VideoPlayer;

	public UIButton StartPlayBtn;

	public GameObject PrivilegeIcon;

	public UIButton ClickSkipBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
