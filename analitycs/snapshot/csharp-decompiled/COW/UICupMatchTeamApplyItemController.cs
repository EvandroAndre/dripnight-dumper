using GCommon;

namespace COW;

public class UICupMatchTeamApplyItemController : UIEasyListItemController
{
	public enum ViewType
	{
		Apply,
		Invite
	}

	private UICupMatchTeamApplyItemView m_View;

	private UIBaseProfileInfoController m_BaseProfileUI;

	private UIModelCupMatch.AccountInfoBasicWithCupInfo m_ApplicantData;

	private UIModelCupMatch m_ModelCupMatch;

	public ViewType m_ViewType;

	private int m_CupMatchKey;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetCupMatchType(int cupMatchKey)
	{
	}

	private void View()
	{
	}

	private void Reject()
	{
	}

	private void Accept()
	{
	}

	private void OnProfileClick()
	{
	}

	private void _003CAccept_003Eb__13_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
