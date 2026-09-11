using GCommon;
using UnityEngine;

namespace COW;

public class UIPopWindowFrameController : MonoBehaviour
{
	public const string CONTENT_IN_ANIM_START_EVT_NAME = "ContentInAnimStart";

	public UIPanel m_MainPanel;

	public UIButton BtnClose;

	public UILabel LabelTitle;

	public UIButton BtnRule;

	private string m_RuleKey;

	private UIPopWindowFrameStyle m_FrameStyle;

	private UIBaseController m_ParentController;

	public void InitFrame(UIBaseController parentController, UIPopWindowFrameStyle frameStyle)
	{
	}

	public void SetFrameDepth(int newDepth)
	{
	}

	public void OnBtnRuleClick()
	{
	}

	public void SetCloseBtnVisble(bool flag)
	{
	}
}
