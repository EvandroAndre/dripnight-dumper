using GCommon;

namespace COW;

public class UIHudMatchFeedbackChoiceItemBaseController : UIBaseController
{
	protected bool m_Selected;

	protected uint m_OptionId;

	protected uint m_BelongsQuestionId;

	protected bool m_IsSingle;

	protected UIHudMatchFeedBackItemController parentCtrl;

	public bool IsSelected => false;

	public uint OptionId => 0u;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public virtual void SetUIData(string optionText, string optionText2, uint optionId, uint belongsQuestionId, bool isSingle)
	{
	}

	public virtual void ChangeSelected(bool selected)
	{
	}

	public virtual void ChangeExclusive(bool selected)
	{
	}

	public virtual bool IsFilledOut()
	{
		return false;
	}

	public virtual string GetOptionInputText()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
