using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDHGReviveTeammateView : UIBaseView
{
	public GameObject ReviveSingleNode;

	public UIButton BtnConfirm;

	public UIButton BtnCancel;

	public UILabel TokenNum;

	public UILabel tips;

	public UIHUDHGTeammateReviveItem PlayerBtnSample;

	public Transform Pos2Root;

	public Transform Pos3Root;

	public Transform Pos1Root;

	public GameObject RevivePanelRoot;

	public GameObject ClosePanelRoot;

	public GameObject RedPointSprite;

	public UIButton OpenDetailBtn;

	public UIGrid PlayerItemsGrid;

	public GameObject ReviveEnableRoot;

	public GameObject ReviveDisableRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
