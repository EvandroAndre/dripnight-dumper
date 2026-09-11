using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHDLobbyYardController : UINavigationController
{
	private UIHDLobbyYardView m_View;

	private static List<string> UI3DOBJECT_NAMES;

	private float m_EnterTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	protected override void AvatarCameraStateChange(UINavigationData navigationData)
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnClickShareButton()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public List<string> _003C_003EiFixBaseProxy_GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_AvatarCameraStateChange(UINavigationData P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
