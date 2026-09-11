using GCommon;
using UnityEngine;

namespace COW;

internal class UIRoomListSettingPreviewItemController : UIBaseController
{
	private UIRoomListSettingPreviewItemView m_View;

	private Color m_DefaultColor;

	private Color m_HighlightColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(string settingName, string settingContent, bool isDefault)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
