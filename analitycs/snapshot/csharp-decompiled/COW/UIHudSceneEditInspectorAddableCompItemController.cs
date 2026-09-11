using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudSceneEditInspectorAddableCompItemController : UIBaseController
{
	private UIHudSceneEditInspectorAddableCompItemView m_View;

	private SceneEditObjectBase m_ModifyObject;

	private InspectorCraftlandConfig_Default m_Data;

	private bool m_IsEnableModify;

	private bool m_IsSelected;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(InspectorCraftlandConfig_Default data)
	{
	}

	public void SetModifyObject(SceneEditObjectBase modifyObject)
	{
	}

	public void EnableAddToggle(bool enable)
	{
	}

	public void SetSelected(bool isSelected)
	{
	}

	private void OnAddToggleClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
