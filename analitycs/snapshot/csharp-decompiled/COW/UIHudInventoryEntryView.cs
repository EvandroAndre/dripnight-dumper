using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInventoryEntryView : UIBaseView
{
	public UIButton BtnInventory;

	public ParticleSystem FlashEffect;

	public UISprite Capratio;

	public UISprite SpriteBg;

	public UILabel CapacityRatio;

	public GameObject MaxCap;

	public UISprite ItemLevelInfo;

	public GameObject VFX_richer;

	public GameObject Plus2;

	public GameObject Plus;

	public Animation FXUIGuideEffect;

	public GameObject TransferItemAnimGo;

	public UISprite TransferItemUI;

	public Animation AnimTemplate;

	public Transform LoadoutV3QuickTrans;

	public VFXCreateHelper CompleteGemGetVFX;

	public VFXCreateHelper FragmentGemGetVFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
