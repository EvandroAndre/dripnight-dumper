using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMatchResultInstantSurveyView : UIBaseView
{
	public Animation Anim;

	public UIPanel UIHudMatchResultInstantSurvey;

	public VFXCreateHelper PageVFXCreateHelper;

	public UILabel Title;

	public UIButton BtnClose;

	public UILabel QuestionLabel;

	public UILabel QuestionNumLabel;

	public GameObject SelectionContainer;

	public GameObject TrueOrFalseContainer;

	public UIButton CancelBtn;

	public UIButton ConfirmBtn;

	public GameObject FinishContainer;

	public UILabel FinishLabel;

	public UISprite Mask;

	public UIWidget clickMask;

	public UITable ScoreContainer;

	public GameObject Timer;

	public UISprite TimeCircle;

	public UILabel TimeLabel;

	public GameObject CancelBtnUIFX;

	public GameObject ConfirmBtnUIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
