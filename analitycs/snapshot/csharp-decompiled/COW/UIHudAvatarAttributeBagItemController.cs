using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudAvatarAttributeBagItemController : UIBaseController
{
	private UIHudAvatarAttributeBagItemView m_View;

	protected AvatarAttributesInfoData m_Data;

	protected uint attributeId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetView(uint _attributeId)
	{
	}

	protected void SetViewInternal()
	{
	}

	private Color GetColorByType(uint attributeType)
	{
		return default(Color);
	}

	private void OnAttributeClick()
	{
	}

	private void OnItemSelect(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
