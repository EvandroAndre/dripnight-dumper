using UnityEngine;

public class GridTableItem : BaseTableItem
{
	private UIGrid m_Grid;

	private float m_PadLeft;

	private float m_PadRight;

	private float m_PadBottom;

	private float m_PadUp;

	private Vector2 m_PresetRealItemSize;

	private Vector2 m_RealItemSize;

	private int m_ActiveCount;

	private float m_PresetCount;

	private bool m_HalfLine;

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
}
