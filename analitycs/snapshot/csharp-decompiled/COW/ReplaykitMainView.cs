using GCommon;
using UnityEngine;

namespace COW;

public class ReplaykitMainView : UIBaseView
{
	public UIEventListener ContainerListener;

	public Transform ContainerTransform;

	public UIWidget ContainerWidget;

	public GameObject Start;

	public UILabel Content;

	public GameObject Record;

	public GameObject Save;

	public UILabel Progress;

	public UIButton ArrowBtn;

	public UIButton VideoBtn;

	public UIButton RecordBtn;

	public UIButton CloseBtn;

	public Animation ReplaykitMain;

	public GameObject GuideView;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
