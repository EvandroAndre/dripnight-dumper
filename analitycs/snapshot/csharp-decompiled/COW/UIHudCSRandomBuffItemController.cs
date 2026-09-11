using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudCSRandomBuffItemController : UIBaseController
{
	private UIHudCSRandomBuffItemView m_View;

	private CSRoundPickBuffData m_Data;

	private uint Id;

	private uint LevelUpId;

	private uint RandomNewId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetView(uint _Id, bool has)
	{
	}

	private void SetViewInternal()
	{
	}

	private Color GetColorByType(uint showType)
	{
		return default(Color);
	}

	private void OnItemClick()
	{
	}

	private void OnItemSelect(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
