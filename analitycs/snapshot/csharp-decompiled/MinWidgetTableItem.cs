using System.Collections.Generic;
using UnityEngine;

public class MinWidgetTableItem : BaseTableItem
{
	private GameObject[] m_WidgetGOs;

	private ELayoutType m_SizType;

	private List<ILayoutTableItem> m_Widgets;

	private ILayoutTableItem m_MinHorizontal;

	private ILayoutTableItem m_MinVertical;

	public override void Init()
	{
	}

	public override void UnInit()
	{
	}

	public override Vector2 GetSize()
	{
		return default(Vector2);
	}

	protected override void EditorExecute()
	{
	}

	public ILayoutTableItem GetSelectedItem()
	{
		return null;
	}
}
