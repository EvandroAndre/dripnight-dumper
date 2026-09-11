using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCellController : UIBaseController
{
	public enum UIStyle
	{
		Normal,
		CanDrop,
		Filled
	}

	public const int CELL_LENGTH = 75;

	public const int CELL_LENGTH_WITH_MARGIN = 75;

	private UIProfileCustomCellView m_View;

	public Vector2Int Position;

	public int Index;

	public UIModelProfileCustom.EDataSource DataSource;

	public Bounds BoundsCache;

	public int ModuleID;

	private bool m_EnableClick;

	private UIStyle m_Style;

	private bool m_DuringDrag;

	public UIStyle Style
	{
		set
		{
		}
	}

	public bool DuringDrag
	{
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetPosAndType(int index, Vector2Int pos, UIModelProfileCustom.EDataSource source, bool enableClick)
	{
	}

	private void RefreshUI()
	{
	}

	public void GenerateBoundsCache(Transform parent)
	{
	}

	private void OnCellClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
