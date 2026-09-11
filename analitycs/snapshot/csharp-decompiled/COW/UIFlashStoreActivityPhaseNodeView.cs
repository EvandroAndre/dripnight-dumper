using GCommon;
using UnityEngine;

namespace COW;

public class UIFlashStoreActivityPhaseNodeView : UIBaseView
{
	public GameObject OverdueGroup;

	public GameObject ProceedingGroup;

	public GameObject LockedGroup;

	public UILabel OverdueDateLabel;

	public UILabel ProceedingLabel;

	public UICountDownLabel ProceedingCountdownLabel;

	public UILabel LockedDateLabel;

	public UIButton ActionBtn;

	public GameObject SelectedIcon;

	public GameObject OverdueContent;

	public GameObject ProceedingContent;

	public GameObject LockedContent;

	public UILabel ProceedingDescLabel;

	public UILabel OverdueDescLabel;

	public UISprite ProceedingTimeIcon;

	public UIWidget GuideWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
