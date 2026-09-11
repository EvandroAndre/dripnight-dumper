using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIPresetAgentBubbleMessageItemController : UIBaseController
{
	private UIPresetAgentFastMessageItemView m_View;

	private PresetAgentECAData m_Data;

	private uint m_RecommendId;

	private uint m_FastMessageId;

	private uint m_AvatarId;

	private List<uint> m_FastChatIds;

	private EPresetAgentScene m_Scene;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(PresetAgentECAData data, uint recommendId, uint fastMessageId, uint avatarId, List<uint> fastChatIds, EPresetAgentScene scene)
	{
	}

	private void OnBubbleMessageButtonClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
