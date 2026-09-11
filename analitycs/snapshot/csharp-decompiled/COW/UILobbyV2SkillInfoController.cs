using GCommon;

namespace COW;

internal class UILobbyV2SkillInfoController : UIBaseController
{
	private UILobbyV2SkillInfoView m_View;

	private uint m_SkillId;

	private bool m_IsPet;

	private bool m_IsNotEmpty;

	private string m_Details;

	private string m_Name;

	private bool m_IsSelf;

	private AvatarSkillData m_SkillData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint skillId, bool isSelf, bool isPet = false)
	{
	}

	public void SetPetDetails(string details)
	{
	}

	private void OnClickClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
