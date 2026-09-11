using GCommon;

namespace COW;

public class UIClothesPrivilegePreviewController : UIPrivilegePreviewController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void RefreshABDownloadInfo()
	{
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	public void _003C_003EiFixBaseProxy_RefreshABDownloadInfo()
	{
	}

	public FrontendPreviewType _003C_003EiFixBaseProxy_GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}
}
