using GCommon;
using UnityEngine;

namespace COW;

public class UIEvoGunNavigationComponentView : UIBaseView
{
	public GameObject Owned;

	public GameObject NotOwned;

	public GameObject Details;

	public UIButton BtnDetails;

	public GameObject Share;

	public UIButton BtnShare;

	public GameObject ChangeFeature;

	public UIButton BtnChangeFeature;

	public GameObject Upgrade;

	public UIButton BtnUpgrade;

	public GameObject QuickEquip;

	public UIButton BtnQuickEquip;

	public GameObject Obtain;

	public UIButton BtnObtain;

	public GameObject CarouselTrans;

	public GameObject CanObtain;

	public GameObject CantObtain;

	public UILabel LabelLevel;

	public GameObject Level;

	public Transform Property;

	public UISprite LevelBg;

	public UISprite SpriteChangeFeaturePoint;

	public UISprite SpriteChangeFeature;

	public Transform OwnedPropertyTrans;

	public GameObject TopRightLine;

	public UIColor TopRightLineColor1;

	public UILabel LabelUpgrade;

	public UISprite SpriteUpgrade;

	public Transform PrivilegeListTrans;

	public GameObject SharePos;

	public GameObject RedPoint;

	public GameObject TopRightLineWithShareNode;

	public UILabel LabelQuickEquip;

	public Transform GuidTrans;

	public UISprite SpriteShare;

	public GameObject Equipped;

	public UIAnchor Right;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
