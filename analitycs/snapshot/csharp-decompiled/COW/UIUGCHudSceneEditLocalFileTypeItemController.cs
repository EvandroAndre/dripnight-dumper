using COW.Gameplay.UGC;
using GCommon;
using message;

namespace COW;

public class UIUGCHudSceneEditLocalFileTypeItemController : UIBaseController
{
	private UIHudSceneEditLocalFileTypeItemView m_View;

	private UIUGCHudSceneEditLocalFileController.FileTypeTabData m_ItemData;

	public IHDACHNBFNG Type => IHDACHNBFNG.GameObject;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(object data)
	{
	}

	public void SetSelected(IHDACHNBFNG type)
	{
	}

	private void OnFrameClicked()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
