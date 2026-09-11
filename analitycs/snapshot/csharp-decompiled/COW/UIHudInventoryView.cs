using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInventoryView : UIBaseView
{
	public UIButton BtnClose1;

	public UIButton BtnClose;

	public UIScrollView ScrollViewRoot;

	public UIPanel ScrollViewPanel;

	public Transform ItemListGridTF;

	public UIGrid ItemListGrid;

	public UILabel BagCapacity;

	public UILabel Bagrighttxt;

	public UIButton BtnSort;

	public UILabel EmptyTipLabel;

	public Transform VestSlot;

	public GameObject VestHolderEmptyBG;

	public UIToggle VestToggle;

	public GameObject VestHighlightGO;

	public Transform HelmetSlot;

	public GameObject HelmetHolderEmptyBG;

	public UIToggle HelmetToggle;

	public GameObject HelmetHighlightGO;

	public Transform BagSlot;

	public GameObject BagHolderEmptyBG;

	public UIToggle BagToggle;

	public GameObject BagHighlightGO;

	public Transform CamouflageSlot;

	public GameObject CamouflageHolderEmptyBG;

	public UIToggle CoverToggle;

	public GameObject CoverHighlightGO;

	public UILabel DescItemName;

	public UIScrollView ScrollView;

	public UITable TagTable;

	public UILabel DescItemInfo;

	public GameObject TagDescContainer;

	public UILabel TagDesc;

	public UISprite TagDescBG;

	public Transform Prim1WeaponSlot;

	public GameObject P1HolderEmptyBG;

	public UIToggle PrimaryWToggle;

	public GameObject PrimaryWHighlightGO;

	public Transform MeleeWeaponSlot;

	public GameObject M1HolderEmptyBG;

	public GameObject MeleeHighlightGO;

	public Transform Prim2WeaponSlot;

	public GameObject P2HolderEmptyBG;

	public UIToggle SecondaryWToggle;

	public GameObject SecondaryWHighlightGO;

	public Transform SecWeaponSlot;

	public GameObject S1HolderEmptyBG;

	public UIToggle SideWToggle;

	public GameObject SideWHighlightGO;

	public GameObject Token;

	public UISprite TokenIcon;

	public UILabel TokenNum;

	public Transform PartialTransform;

	public UIPanel TrashPanel;

	public GameObject TrashGO;

	public BoxCollider TrashGOBox;

	public GameObject TrashDragHighlight;

	public GameObject TrashDragOverHighlight;

	public GameObject TrashPartialGO;

	public GameObject TrashPartialDragHighlight;

	public GameObject TrashPartialDragOverHighlight;

	public GameObject TrashHint;

	public UIButton BtnCloseMask;

	public Transform MultipleMenu;

	public UIToggleButton CapactiyMenu;

	public UIToggleButton DeviceMenu;

	public UIPanel DeviceItemList;

	public UITable2 ItemTableList;

	public GameObject IceMakerExp;

	public UILabel CurExp;

	public UISprite ExpProcess;

	public GameObject Title;

	public UILabel PartialNum;

	public UISprite PartialScrollLine;

	public GameObject PartialScrollCon;

	public UIButton DropUselessBtn;

	public GameObject ParticalLineCon;

	public UISprite PartialLine;

	public GameObject UIFXSortGuide;

	public GameObject UIFXUselessGuide;

	public GameObject TrashSingleAll;

	public GameObject TrashSingleAllDrag;

	public GameObject TrashSingleAllDragOver;

	public GameObject TrashPartialAll;

	public BoxCollider TrashPartialAllBox;

	public GameObject TrashPartialAllDrag;

	public GameObject TrashPartialAllDragOver;

	public GameObject PartialAllScrollCon;

	public UILabel PartialAllNum;

	public UISprite PartialAllScrollLine;

	public GameObject ParticalAllLineCon;

	public UISprite PartialAllLine;

	public GameObject TrashOld;

	public GameObject TrashDragHighlightOld;

	public GameObject TrashDragOverHighlightOld;

	public GameObject TrashPartialOld;

	public GameObject TrashPartialDragHighlightOld;

	public GameObject TrashPartialDragOverHighlightOld;

	public Transform TeammateItemGivenTrans;

	public Transform PartialTransferTrans;

	public UIWidget MistakeClickMask;

	public GameObject DropInfoEffect;

	public UISprite DropAfterFill;

	public UISprite DropBeforeFill;

	public UILabel DropInfoText;

	public GameObject TrashDragHighlight_Right;

	public GameObject TrashDragOverHighlight_Right;

	public UISprite SortSpr;

	public GameObject NameTipColor;

	public Transform DeviceSlot;

	public GameObject DeviceHolderEmptyBG;

	public UIToggle DeviceToggle;

	public GameObject DeviceHighlightGO;

	public GameObject BgContainer;

	public GameObject EighthInfiniteBgContainer;

	public UIToggle MeleeToggle;

	public GameObject EquipTitle;

	public GameObject LeftToggleTrans;

	public GameObject EquipmentSection;

	public GameObject UpgradeSection;

	public Transform UpgradeTrans;

	public GameObject NormalContainer;

	public GameObject WeaponContainer;

	public UILabel ItemType;

	public UITable PropertyTable;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
