using GCommon;
using UnityEngine;

namespace COW;

public class UILabNavigationView : UIBaseView
{
	public UIScrollView EntranceScrollView;

	public UITable EntranceTable;

	public UIButton BookEntrance;

	public UIButton LegendClothEntrance;

	public GameObject HyperBookEntranceTips;

	public GameObject LegendClothEntranceTips;

	public UILabel HyperBookFootnoteLabel;

	public UILabel LegendClothFootnodeLabel;

	public GameObject HyperBookOpenState;

	public GameObject HyperBookNotOpenState;

	public GameObject LegendClothOpenState;

	public GameObject LegendClothNotOpenState;

	public UIButton GuideMask;

	public UIButton VirtualBrandEntrance;

	public GameObject VirtualBrandOpenState;

	public GameObject VirtualBrandNotOpenState;

	public GameObject VirtualBrandVirtualBrand;

	public UILabel VirtualBrandFootnodeLabel;

	public UIButton TailorEntrance;

	public GameObject TailorOpenStateGroup;

	public GameObject TailorNotOpenStateGroup;

	public GameObject TailorTitleTipsIcon;

	public UILabel TailorFootnoteLabel;

	public UIButton IPCollabEntrance;

	public GameObject IPCollabOpenState;

	public GameObject IPCollabNotOpenState;

	public UILabel IPCollabFootnoteLabel;

	public GameObject EntranceIconCDNGameObject;

	public UINetworkTexture EntranceIconCDN;

	public GameObject EntranceIcon;

	public Transform IPVFXTransform;

	public Transform NotIPVFXTransform;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
