using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetDyeColorBtnView : UIBaseView
{
	public UICustomMeshCollider CustomMeshCollider;

	public UIButton ClickBtn;

	public GameObject Selected;

	public UISprite colorSprite1;

	public GameObject Unselected;

	public UISprite colorSprite2;

	public GameObject LockedIcon;

	public GameObject Unlocked;

	public GameObject Locked;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
