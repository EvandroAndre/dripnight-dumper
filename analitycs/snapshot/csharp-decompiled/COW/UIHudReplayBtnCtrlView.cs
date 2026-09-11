using GCommon;
using UnityEngine;

namespace COW;

public class UIHudReplayBtnCtrlView : UIBaseView
{
	public UIButton PauseBtn;

	public UIButton PlayBtn;

	public UIButton JumpBtn;

	public TweenAlpha Background;

	public GameObject Container;

	public UIButton ResetBtn;

	public Transform RecordStatePos;

	public UILabel LoadingOrSpeedUp;

	public Transform SingleHighlightBtnPos;

	public UIButton RewindBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
