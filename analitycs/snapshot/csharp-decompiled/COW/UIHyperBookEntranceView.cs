using GCommon;
using UnityEngine;

namespace COW;

public class UIHyperBookEntranceView : UIBaseView
{
	public UIButton EntranceBtn;

	public UIDragScrollView EntranceDragScrollView;

	public UILabel BookNameLabel;

	public UITable ProgressTable;

	public GameObject ProgressUnit;

	public UILabel BookStatusLabel;

	public UISprite BookCoverIcon;

	public GameObject BookEntranceTips;

	public UISprite LockIconBg;

	public UISprite BookCoverIconMask;

	public Transform DownloadCtrlTrans;

	public Animation UnlockAnim;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
