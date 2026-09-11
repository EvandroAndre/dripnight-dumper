using COW.GamePlay;
using GCommon;

namespace COW;

public class UISceneEditPaintItemIconController : UIBaseController
{
	private SceneEditPaintTool mPaintTool;

	private int m_curID;

	private UISceneEditPaintItemIconView m_View;

	private SceneEditPaintTool PaintTool => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnIconDelete()
	{
	}

	public void RefreshIconByItemID(int id)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
