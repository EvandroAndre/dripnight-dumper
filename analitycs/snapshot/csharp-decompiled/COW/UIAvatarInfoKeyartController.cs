using GCommon;

namespace COW;

public class UIAvatarInfoKeyartController : UINavigationController
{
	private UIAvatarInfoKeyartView m_View;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private string m_VideoUrl;

	private string m_KeyartUrl;

	private uint m_AvatarId;

	private AvatarProfile m_AvatarProfile;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void OnRelationBtn1Click()
	{
	}

	private void OnRelationBtn2Click()
	{
	}

	private void OnRelationBtn3Click()
	{
	}

	private void OnStoryBtnClick()
	{
	}

	private void OnVideoBtnClick()
	{
	}

	private string GetAvatarGuildUrl()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
