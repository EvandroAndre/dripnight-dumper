using GCommon;
using UnityEngine;

namespace COW;

public class UIMysteryMallLuckyDrawView : UIBaseView
{
	public UIButton BtnClose;

	public GameObject GetLuckContainer;

	public UIButton BtnGetLuck;

	public UILabel LabelBtnGetLuck;

	public UISprite SpriteGetLuck;

	public UILabel LabelGetLuckTip;

	public UISprite SpriteGetLuckTip;

	public GameObject FinishLuckContainer;

	public UILabel LabelCongratulation;

	public UILabel LabelSuperLuckTip;

	public GameObject VFXDrawingContainer;

	public GameObject Effect_Mask;

	public GameObject VFXStopDrawContainer;

	public UILabel LabelLuckNumLBit;

	public UILabel LabelLuckNumRBit;

	public GameObject StopDraw_Effect;

	public MeshRenderer VFXLuckNum;

	public UILabel LabelLuckBitTip;

	public UISprite LuckNumDefaultBg;

	public UISprite LuckNumBg;

	public UILabel LabelLuckBitTip1;

	public UIButton BtnGoMystery;

	public UILabel LabelBtnGoMystery;

	public UISprite SpriteGoMystery;

	public UINetworkTextureExt CdnBgTexture;

	public UIButton ProbabilityTips;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
