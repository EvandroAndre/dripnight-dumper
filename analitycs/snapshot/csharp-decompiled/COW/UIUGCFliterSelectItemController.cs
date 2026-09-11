using GCommon;
using UnityEngine;

namespace COW;

internal class UIUGCFliterSelectItemController : UIBaseController
{
	private UIUGCFliterSelectItemView m_View;

	private UGCFliterSelectItemData m_Data;

	private int m_DefaultLabelWidth;

	private Vector3 m_DefaultLabelPosition;

	private int m_DefaultPadding;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UGCFliterSelectItemData data)
	{
	}

	public UIToggleButton GetToggleButton()
	{
		return null;
	}

	public uint GetDataID()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
