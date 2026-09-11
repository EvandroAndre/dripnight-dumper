using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaContentCustomizedBackgroundView : UIBaseView
{
	public UIButton MaskBtn;

	public UITexture VideoTexture;

	public FFVideoPlayer CustomvideoPlayer;

	public Transform BG;

	public UILabel InterfaceMaskLabel;

	public Transform LoadingCardMask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
