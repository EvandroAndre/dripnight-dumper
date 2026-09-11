using GCommon;
using UnityEngine;

namespace COW;

public class UIPresetAgentFastMessageItemController : UIBaseController
{
	private UIPresetAgentFastMessageItemView m_View;

	private PresetAgentECAData m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(PresetAgentECAData data)
	{
	}

	public Vector2 GetSize()
	{
		return default(Vector2);
	}

	private void OnFastMessageButtonClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
