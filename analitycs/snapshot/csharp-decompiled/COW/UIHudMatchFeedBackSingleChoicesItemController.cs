using GCommon;

namespace COW;

public class UIHudMatchFeedBackSingleChoicesItemController : UIHudMatchFeedbackChoiceItemBaseController
{
	private UIHudMatchFeedBackSingleChoicesItemView m_View;

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

	private void OnClickItem()
	{
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
}
