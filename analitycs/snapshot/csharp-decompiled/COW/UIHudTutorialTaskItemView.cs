using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTutorialTaskItemView : UIBaseView
{
	public UILabel TaskDesc;

	public GameObject ImgFinish;

	public GameObject ImgNotFinish;

	public Animation ItemAnim;

	public Animation UIFX_Line;

	public GameObject Glow;

	public GameObject Line;

	public UIButton TaskClickButton;

	public UIDragScrollView DragScrollview;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
