using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditSlotItemView : UIBaseView
{
	public GameObject LockState;

	public UILabel LockTxt;

	public GameObject UnLockState;

	public GameObject SpecialStateMask;

	public GameObject SlotIcon;

	public UINetworkTexture CDNMap;

	public GameObject EmptySlotIcon;

	public GameObject LostIcon;

	public GameObject WarningIcon;

	public UILabel NameTxt;

	public GameObject Upload;

	public GameObject Download;

	public GameObject Share;

	public UILabel IndexTxt;

	public GameObject SelectedBg;

	public UIButton Btn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
