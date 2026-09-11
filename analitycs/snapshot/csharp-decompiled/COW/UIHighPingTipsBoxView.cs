using GCommon;
using UnityEngine;

namespace COW;

public class UIHighPingTipsBoxView : UIBaseView
{
	public UIButton BtnClose;

	public UIButton BtnRight;

	public UIWidget BtnWidgetRight;

	public GameObject Timer;

	public UILabel TimeLabel;

	public UISprite TimeCircle;

	public UIButton BtnLeft;

	public UIWidget BtnWidgetLeft;

	public UILabel LabelTipsType;

	public UILabel LabelDescription;

	public UILabel LabelRight;

	public UILabel LabelLeft;

	public UISprite BG;

	public UIToggle IgnoreToggle;

	public UILabel IgnoreLabel;

	public GameObject OfflineTips;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
