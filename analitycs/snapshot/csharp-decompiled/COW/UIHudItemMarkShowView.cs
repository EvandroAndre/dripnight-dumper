using GCommon;
using UnityEngine;

namespace COW;

public class UIHudItemMarkShowView : UIBaseView
{
	public UISprite EnemyLine;

	public UISprite MarkPoint;

	public UISprite PickUpLine;

	public UIWidget UIShowContainer;

	public UISprite TeamPointMark;

	public UILabel LabelTeamId;

	public VFXCreateHelper EnemyMark;

	public UISprite triggerImg;

	public VFXCreateHelper triggerImgVfx;

	public GameObject Distance;

	public GameObject ArrowDown;

	public UISprite ArrowDownSprite;

	public GameObject ArrowRight;

	public UISprite ArrowRightSprite;

	public GameObject ArrowLeft;

	public UISprite ArrowLeftSprite;

	public GameObject ArrowUp;

	public UISprite ArrowUpSprite;

	public UISprite OKImg;

	public UISprite OKImg1;

	public UISprite OKImg2;

	public UILabel OKIndexLabel;

	public UILabel OKIndexLabel1;

	public UILabel OKIndexLabel2;

	public UITable okImgs;

	public UILabel DistanceM;

	public UILabel DistanceLabel;

	public TweenScale TweenScale;

	public UISprite ItemFrameImg;

	public Transform RevivePointTrans;

	public Transform LockAirDropTrans;

	public Transform TreasuryTrans;

	public Transform SAPPortalTrans;

	public GameObject suggestJumpRoot;

	public Transform DistanceUpOffest;

	public Transform DistanceDownOffset;

	public VFXCreateHelper ResponseWhiteEffect;

	public VFXCreateHelper ResponseRedEffect;

	public VFXCreateHelper ResponseItemEffect;

	public Transform InteractAreaTrans;

	public UISprite EffectLevelBg;

	public UISprite BlackBg;

	public Transform EnergyDeviceTrans;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
