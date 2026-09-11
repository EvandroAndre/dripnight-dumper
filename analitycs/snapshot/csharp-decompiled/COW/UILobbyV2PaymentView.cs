using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2PaymentView : UIBaseView
{
	public GameObject Payment;

	public UIButton PaymentBtn;

	public Transform SrcCountDown;

	public GameObject PaymentDefaultSprite;

	public UINetworkTexture PaymentNetworkTexture;

	public UILabel BonusLabel;

	public GameObject PaymentBonusContainer;

	public GameObject TipsContainer;

	public GameObject CountDownContainer;

	public VFXCreateHelper VFXCreateHelper;

	public EffectMovement EffectMovement;

	public GameObject VFX_PaymentButtonNetworkTexture;

	public GameObject UIFX_Once;

	public Transform RedDotPos;

	public GameObject SpecailSquadTreasureVFXContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
