using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIHudMatchFeedBackController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public uint questionId;

		public Predicate<UIHudMatchFeedBackItemController> _003C_003E9__0;

		public Predicate<UIHudMatchFeedBackItemController> _003C_003E9__1;

		internal bool _003COnQuestionOptionSelected_003Eb__0(UIHudMatchFeedBackItemController num)
		{
			return false;
		}

		internal bool _003COnQuestionOptionSelected_003Eb__1(UIHudMatchFeedBackItemController result)
		{
			return false;
		}
	}

	private UIHudMatchFeedBackView m_View;

	private UIModelMatch m_ModelMatch;

	private List<UIHudMatchFeedBackItemController> m_QuestionItemCtrlList;

	private uint m_FirstQuestionId;

	private uint m_GameplayFeedbackType;

	private bool m_CanSubmit;

	private GameplayFeedbackQuestionDesc m_FirstQuestionDesc;

	private HashSet<uint> m_ChildQuestions;

	private Action m_SubmitCallBack;

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

	private void RefreshUIData()
	{
	}

	private void OnQuestionOptionUnSelected(uint optionId, uint questionId)
	{
	}

	private void OnQuestionOptionSelected(uint optionId, uint questionId)
	{
	}

	private void FindAllChildQuestion(uint optionId, bool needShow)
	{
	}

	private void OnSubmitBtnClick()
	{
	}

	private void RefreshSubmitBtn()
	{
	}

	public void RegisterCallBack(Action callBack)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
