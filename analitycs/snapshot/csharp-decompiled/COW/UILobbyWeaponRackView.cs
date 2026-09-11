using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyWeaponRackView : UIBaseView
{
	public GameObject Guide;

	public TweenPosition RightTween;

	public Transform PopMenuGun;

	public Transform PopMenuRare;

	public UIScrollView ScrollView;

	public UIEasyList Grid;

	public GameObject Empty;

	public UIButton GoShopButton;

	public UIGrid Slots;

	public UIButton GotoShopCollectionSkin;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
