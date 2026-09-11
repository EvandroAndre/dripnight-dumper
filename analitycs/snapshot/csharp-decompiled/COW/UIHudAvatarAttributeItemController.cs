using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudAvatarAttributeItemController : UIBaseController
{
	private UIHudAvatarAttributeItemView m_View;

	private AvatarAttributesInfoData m_Data;

	private uint attributeId;

	private uint m_LevelUpId;

	private uint m_RandomNewId;

	public uint LevelUpID => 0u;

	public uint RandomNewID => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetView(uint _attributeId, bool has, bool isNeedReplayAnim = false)
	{
	}

	private void SetViewInternal()
	{
	}

	private Color GetColorByType(uint attributeType)
	{
		return default(Color);
	}

	private void OnAttributeClick()
	{
	}

	public void SetSelectState(bool isSelect)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
