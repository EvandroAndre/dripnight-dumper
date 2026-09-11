using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIHudMatchFeedBackItemController : UIBaseController
{
	private UIHudMatchFeedBackItemView m_View;

	private uint m_QuestionId;

	private uint m_PreOptionId;

	private bool m_IsSingle;

	private uint m_PreQuestionId;

	private UIModelMatch m_ModelMatch;

	private List<UIHudMatchFeedbackChoiceItemBaseController> m_FeedBackChoicesItemList;

	public uint QuestionId => 0u;

	public uint PreOptionId => 0u;

	public uint PreQuestionId => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetUIData(GameplayFeedbackQuestionDesc desc, bool isSingle)
	{
	}

	private uint GetPreQuestionId(uint preOptionId)
	{
		return 0u;
	}

	public List<uint> GetAllSelectedOptionId()
	{
		return null;
	}

	public string GetInputText()
	{
		return null;
	}

	public bool HasAllQuestionsFilledOut()
	{
		return false;
	}

	public void ChangeHasSelectedSingleChoise(uint optionId)
	{
	}

	public void CheckAndChangeExclusiveOption(uint optionId, bool selected)
	{
	}

	public void RepositionGrid()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
