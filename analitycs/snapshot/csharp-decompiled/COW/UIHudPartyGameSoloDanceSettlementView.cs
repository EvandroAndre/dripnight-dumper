using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPartyGameSoloDanceSettlementView : UIBaseView
{
	public GameObject GoSettlement;

	public GameObject GoSettlementScore;

	public Animation AnimationScore;

	public UILabel LabelSettlementScoreSelf;

	public UILabel LabelSettlementScoreSelfReal;

	public UILabel LabelSettlementScoreOther;

	public UILabel LabelSettlementScoreOtherReal;

	public Transform TrSettlementBtns;

	public UIGrid GridSettlementBtns;

	public UIButton BtnSettlementBack;

	public UILabel LabelBack;

	public UIButton BtnSettlementPlayAgain;

	public Transform Victory;

	public TweenScale VictoryTween;

	public UILabel VictoryTxt;

	public Transform Defeat;

	public TweenScale DefeatTween;

	public UILabel DefeatTxt;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
