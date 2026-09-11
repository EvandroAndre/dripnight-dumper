using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2UGCReserveWndView : UIBaseView
{
	public UIButton CloseMaskBtn;

	public UIButton ReserveBtn;

	public UILabel ReserveLabel;

	public GameObject CanReserve;

	public GameObject Reserved;

	public GameObject Reserving;

	public GameObject CannotReserve;

	public UIButton WorkshopDetailBtn;

	public Transform BtnPanel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
