using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudActiveSkillPerksChooseItem : MonoBehaviour
{
	private GameObject SkillSummary;

	private UISprite SkillSummarySkillIcon;

	private UILabel SkillSummarySkillName;

	private UILabel SkillSummarySkillContent;

	private GameObject SkillDetail;

	private UISprite SkillDetailSkillIcon;

	private UILabel SkillDetailSkillName;

	private UILabel SkillDetailSkillContent;

	private UIButton SwitchViewBtn;

	private UIButton SelectBtn;

	private GameObject SelectBtnDefaultView;

	private Transform SelectBtnActivityPos;

	private int m_PerksIdx;

	private Action<int> m_ChooseIndexAction;

	private string m_Style;

	private VisualInstanceHolder m_StyledBtnHolder;

	private void Awake()
	{
	}

	public void SetData(int perksIdx, uint skillId, Action<int> chooseIndexAction, string style)
	{
	}

	private void TryChangeStyle(string style)
	{
	}

	private void OnSelectClick()
	{
	}

	private void OnSwitchViewClick()
	{
	}
}
