using GCommon;

namespace COW;

public class UIHudMatchFeedBackInputItemController : UIHudMatchFeedbackChoiceItemBaseController
{
	private UIHudMatchFeedBackInputItemView m_View;

	private string previousText;

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

	public override void SetUIData(string optionText, string optionText2, uint optionId, uint belongsQuestionId, bool isSingle)
	{
	}

	public override void ChangeSelected(bool selected)
	{
	}

	public override void ChangeExclusive(bool selected)
	{
	}

	private void OnClickItem()
	{
	}

	private void OnInputFieldChanged()
	{
	}

	private void OnClearBtnClick()
	{
	}

	public override string GetOptionInputText()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetUIData(string P0, string P1, uint P2, uint P3, bool P4)
	{
	}

	public void _003C_003EiFixBaseProxy_ChangeSelected(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ChangeExclusive(bool P0)
	{
	}

	public string _003C_003EiFixBaseProxy_GetOptionInputText()
	{
		return null;
	}
}
