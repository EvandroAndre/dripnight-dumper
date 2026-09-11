using GCommon;
using UnityEngine;
using UnityEngine.Video;

namespace COW;

public class UIBooyahPassVideoView : UIBaseView
{
	public UIButton SkipBtn;

	public UIButton MaskBtn;

	public VideoPlayer videoPlayer;

	public UITexture videoTexture;

	public AudioSource videoAudio;

	public UIAnchor TopRight;

	public UILabel SkipLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
