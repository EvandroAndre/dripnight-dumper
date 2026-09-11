using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2ReserveAndObserveWndView : UIBaseView
{
	public UIButton CloseMaskBtn;

	public UIButton ReserveBtn;

	public UILabel ReserveLabel;

	public GameObject CanReserve;

	public GameObject Reserved;

	public GameObject Reserving;

	public GameObject CannotReserve;

	public UIButton ObserveBtn;

	public Transform DownLoadRootTransform;

	public UIButton WorkshopReserveBtn;

	public Transform Root;

	public UITable Table;

	public UIButton InviteBtn;

	public UIButton JoinBtn;

	public UISprite InviteSprite;

	public UISprite JoinSprite;

	public UIButton UGCHalfJoinBtn;

	public GameObject ObserverLine;

	public GameObject WorkShopLine;

	public GameObject UGCLine;

	public GameObject JoinLine;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
