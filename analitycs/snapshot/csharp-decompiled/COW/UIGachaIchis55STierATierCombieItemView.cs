using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaIchis55STierATierCombieItemView : UIBaseView
{
	public UINetworkTexture CDNNetWorkTexture;

	public UILabel NumberLabel;

	public UIGrid ItemGrid;

	public Transform ItemSlot0;

	public Transform ItemSlot1;

	public Transform ItemSlot2;

	public Transform ItemSlot3;

	public GameObject NumberContainer;

	public GameObject SelectedContainer;

	public GameObject OwnedContainer;

	public GameObject SoldoutObject;

	public GameObject STierClickBtnGameObject;

	public UIButton STierClickBtn;

	public Animation MainAni;

	public GameObject NumberVFX;

	public VFXCreateHelper NumberVFXCreateHelper;

	public UIPanel Panel;

	public GameObject UIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
