using GCommon;
using UnityEngine;

namespace COW;

public class UIEquipSetSelectionView : UIBaseView
{
	public UILabel LastTime;

	public GameObject InGameContainer;

	public GameObject LeftTimeShow;

	public UILabel LeftTime;

	public UIButton BtnConfirm;

	public GameObject LobbyContainer;

	public UIButton BtnClose;

	public UIGrid Grid;

	public GameObject LabelNumShow;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
