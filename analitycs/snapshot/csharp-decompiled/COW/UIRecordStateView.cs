using GCommon;
using UnityEngine;

namespace COW;

public class UIRecordStateView : UIBaseView
{
	public UILabel RecordingLabel;

	public UILabel SavingLabel;

	public GameObject Content;

	public UIButton ContentBtn;

	public TweenAlpha TweenAlpha;

	public TweenScale TweenScale;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
