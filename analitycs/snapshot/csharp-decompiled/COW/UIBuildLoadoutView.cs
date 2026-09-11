using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildLoadoutView : UIBaseView
{
	public UIButton ItemBtn;

	public UIWidget ItemBtnWidget;

	public GameObject HighLightSprite;

	public GameObject ExpandPlaceholder;

	public UILabel CountLabel;

	public GameObject PlayCardContainer;

	public UISprite ItemSprite;

	public UICountDownLabel PlayCardCountDownLabel;

	public UISprite EmptyMask;

	public GameObject V1;

	public GameObject V2;

	public UISprite LoadoutV2;

	public Transform EquipEffect;

	public UISprite LeftBg;

	public UISprite RightBg;

	public UICountDownLabel V2ConutDown;

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
