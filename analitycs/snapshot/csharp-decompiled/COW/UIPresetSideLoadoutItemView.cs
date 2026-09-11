using GCommon;
using UnityEngine;

namespace COW;

public class UIPresetSideLoadoutItemView : UIBaseView
{
	public UISprite ItemSprite;

	public GameObject EmptyMask;

	public UILabel QuantityLabel;

	public GameObject PlayCardContainer;

	public UICountDownLabel PlayCardCountDownLabel;

	public GameObject LoadoutDisableContainer;

	public UIButton LoadoutBtn;

	public GameObject V1Sprite;

	public GameObject V2;

	public UISprite LoadoutV2;

	public GameObject V1Bg;

	public Transform EquipEffect;

	public UISprite LeftBg;

	public UISprite RightBg;

	public UICountDownLabel V2ConutDown;

	public Transform LoadoutV2Guide;

	public GameObject V1RedDot;

	public GameObject LoadoutLock;

	public Transform LockTransForm;

	public UIButton Mask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
