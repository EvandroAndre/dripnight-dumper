using GCommon;
using UnityEngine;

namespace COW;

public class UIDownloadCentreFixWndView : UIBaseView
{
	public UIButton RepairBtn;

	public GameObject Error;

	public GameObject Repairing;

	public GameObject repairFinished;

	public UIButton OkBtn;

	public UILabel RepairFinishedContent;

	public UIButton CloseBtn;

	public UILabel RepairProgressLabel;

	public UISprite RepairProgress;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
