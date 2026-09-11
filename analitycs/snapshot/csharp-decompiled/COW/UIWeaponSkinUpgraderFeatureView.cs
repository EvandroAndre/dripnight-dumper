using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinUpgraderFeatureView : UIBaseView
{
	public Animator ShowFeatureAnim;

	public UIPanel MainPanel;

	public GameObject UIContent;

	public UISprite BGSprite;

	public UITexture GachaFeature_Bg;

	public GameObject ObjAnnouncementArea;

	public GameObject InterfaceMask;

	public GameObject ItemShow;

	public GameObject ItemInfoContainer;

	public BaseItemView BaseInfoView;

	public GameObject Bottom_btn;

	public UIButton ShareBtn;

	public Animator ShareIconAnimator;

	public UIButton OkBtn;

	public GameObject propertyContainer;

	public UIGrid scoreGrid;

	public UILabel ItemNameLabel;

	public UISprite IPTag;

	public GameObject propertyVioContainer;

	public UIGrid scoreVioGrid;

	public UILabel ItemNameVioLabel;

	public UISprite IPTagVio;

	public GameObject propertyRedContainer;

	public UIGrid scoreRedGrid;

	public UILabel ItemNameRedLabel;

	public UISprite IPTagRed;

	public GameObject ObjKillUIFXArea;

	public Transform ScopeSelectTrans;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
