using System;
using GCommon;

namespace COW;

public class UINewPlayerV3TrainingCenterTabController : UIBaseController
{
	private const string SkillIcon = "TrainingCenter_Icon_abilities";

	private const string SkillIconSelected = "TrainingCenter_Icon_abilities_01";

	private const string TechniqueIcon = "TrainingCenter_Icon_maehanics";

	private const string TechniqueIconSelected = "TrainingCenter_Icon_maehanics_01";

	private const string PropIcon = "TrainingCenter_Icon_utility";

	private const string PropIconSelected = "TrainingCenter_Icon_utility_01";

	private UINewPlayerV3TrainingCenterTabView m_View;

	private StandardTabItemViewData m_Data;

	private Action<int> m_OnClick;

	private int m_TabIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void InitTabView(StandardTabItemViewData data, int tabIndex, Action<int> onClick)
	{
	}

	public bool CanClick()
	{
		return false;
	}

	public void OnTabClick()
	{
	}

	public void UpdateSelectState(bool isSelect)
	{
	}

	private string GetIconSpriteName(bool isSelect)
	{
		return null;
	}

	public void CheckTipButton()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
