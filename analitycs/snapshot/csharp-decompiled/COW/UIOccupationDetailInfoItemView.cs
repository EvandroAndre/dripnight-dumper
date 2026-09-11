using GCommon;
using UnityEngine;

namespace COW;

public class UIOccupationDetailInfoItemView : UIBaseView
{
	public UILabel Lv;

	public UILabel Exp;

	public UILabel RoleDesc;

	public UIButton RecommendBtn;

	public UIButton ShowBtn;

	public UIPanel Panel;

	public GameObject LoadBG;

	public GameObject UnloadBG;

	public UIButton MoreInfoBtn;

	public UISprite LevelBar;

	public UILabel OnlyView;

	public UIMultiColorAdptor ColorAdptor;

	public UIButton Mask;

	public GameObject ElietPreview;

	public UIButton ElietPreviewMask;

	public UILabel ElietPreviewName;

	public UISprite ElietPreviewIcon;

	public UILabel EliteDesc;

	public UIButton EliteTip;

	public Transform UIFX_ScaleAll;

	public GameObject EliteDesc_Position;

	public UILabel RoleDescFull;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
