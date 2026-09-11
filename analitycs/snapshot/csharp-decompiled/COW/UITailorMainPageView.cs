using GCommon;
using UnityEngine;

namespace COW;

public class UITailorMainPageView : UIBaseView
{
	public UILabel Current;

	public UILabel All;

	public GameObject Finish;

	public UITable Table;

	public GameObject Bundle;

	public UIGrid BundleGrid;

	public GameObject SingleHair;

	public UIGrid SingleHairGrid;

	public GameObject SingleFace;

	public UIGrid SingleFaceGrid;

	public GameObject SingleHeadAdditive;

	public UIGrid SingleHeadAdditiveGrid;

	public GameObject SingleChest;

	public UIGrid SingleChestGrid;

	public GameObject SingleLegs;

	public UIGrid SingleLegsGrid;

	public GameObject SingleFeet;

	public UIGrid SingleFeetGrid;

	public GameObject CollectionBar;

	public GameObject Collection;

	public UIGrid CollectionGrid;

	public GameObject SpecialEffectBar;

	public GameObject SpecialEffect;

	public UIGrid SpecialEffectGrid;

	public UIButton TokenBoxEntrance;

	public UIWidget TokenBoxEntranceWidget;

	public GameObject Obtain;

	public GameObject Unlock;

	public GameObject ConditionUnlock;

	public GameObject LimitedTime;

	public GameObject ToEquip;

	public UIWidget PreviewBorder;

	public UIButton EquipBtn;

	public UIButton ObtainBtn;

	public UIButton UnLockBtn;

	public UILabel CurrentTokenCnt;

	public UISprite UnLockTokenIcon;

	public UILabel UnLockTokenCnt;

	public UIButton ConditionUnLockBtn;

	public UIButton ToEquipBtn;

	public UILabel ObtainChannel;

	public UILabel UnLockTips;

	public UILabel ConditionUnLockTips;

	public TailorSlotItem SlotItemTemplete;

	public TailorSlot SlotHair;

	public TailorSlot SlotHead;

	public TailorSlot SlotHeadAdditive;

	public TailorSlot SlotChest;

	public TailorSlot SlotLegs;

	public TailorSlot SlotFeet;

	public GameObject Slots;

	public GameObject BundleHair;

	public GameObject BundleFace;

	public GameObject BundleHeadAdditive;

	public GameObject BundleLegs;

	public GameObject BundleFeet;

	public GameObject BundleChest;

	public UIGrid BundleHairGrid;

	public UIGrid BundleFaceGrid;

	public UIGrid BundleHeadAdditiveGrid;

	public UIGrid BundleLegsGrid;

	public UIGrid BundleFeetGrid;

	public UIGrid BundleChestGrid;

	public GameObject ProgressContainer;

	public TailorLockBar LockBarTemplete;

	public Transform LockBarPanel;

	public UIScrollView ItemListScrollView;

	public UIPanel ItemListPanel;

	public Transform Left;

	public UISprite ObtainChannelIcon;

	public GameObject UnFinish;

	public UIButton LimitedBtn;

	public GameObject Equied;

	public GameObject UIFX_GuideToClick;

	public UIButton CantEquip;

	public UISprite BG;

	public UIWidget GuideSecondWidget;

	public UIButton GuideSecondClickBtn;

	public UIButton GuideFirstClickBtn;

	public UIWidget GuideFirstWidget;

	public UIWidget GuideZone;

	public GameObject UnLockMixTokenContainer;

	public UISprite UnLockUniqueTokenIcon;

	public UISprite UnLockUniversalTokenIcon;

	public GameObject GemUnlock;

	public UIButton GemUnLockBtn;

	public UILabel GemUnLockTips;

	public UILabel GemCnt;

	public GameObject GemUnLockBtnDisAble;

	public GameObject UnLockBtnDisable;

	public GameObject GemCountDown;

	public GameObject UnlockCountDown;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
