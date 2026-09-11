using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudSceneEditInspectorTransformCompController : UIHudSceneEditInspectorCompController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetViewData(string title, string entityType, SceneEditObjectBase objectBase, string tips)
	{
	}

	protected override bool EnableExpand()
	{
		return false;
	}

	public override bool IsEmptyInspectorComp()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SetViewData(string P0, string P1, SceneEditObjectBase P2, string P3)
	{
	}

	public bool _003C_003EiFixBaseProxy_EnableExpand()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsEmptyInspectorComp()
	{
		return false;
	}
}
