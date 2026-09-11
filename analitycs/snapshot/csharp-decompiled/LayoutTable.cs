using System.Collections.Generic;
using UnityEngine;

public class LayoutTable : BaseTableItem
{
	private ELayoutType m_LayoutType;

	private Transform m_StartTopLeftPos;

	private GameObject[] m_GOs;

	private Vector2 m_Padding;

	private bool m_ExecuteOnStart;

	private List<ILayoutTableItem> m_Items;

	private float _003CTotalWidthForVertical_003Ek__BackingField;

	private float _003CTotalHeightForVertical_003Ek__BackingField;

	private float _003CTotalHeightForHorizontal_003Ek__BackingField;

	private float _003CTotalWidthForHorizontal_003Ek__BackingField;

	public float TotalWidthForVertical
	{
		get
		{
			return _003CTotalWidthForVertical_003Ek__BackingField;
		}
		private set
		{
			_003CTotalWidthForVertical_003Ek__BackingField = value;
		}
	}

	public float TotalHeightForVertical
	{
		get
		{
			return _003CTotalHeightForVertical_003Ek__BackingField;
		}
		private set
		{
			_003CTotalHeightForVertical_003Ek__BackingField = value;
		}
	}

	public float TotalHeightForHorizontal
	{
		get
		{
			return _003CTotalHeightForHorizontal_003Ek__BackingField;
		}
		private set
		{
			_003CTotalHeightForHorizontal_003Ek__BackingField = value;
		}
	}

	public float TotalWidthForHorizontal
	{
		get
		{
			return _003CTotalWidthForHorizontal_003Ek__BackingField;
		}
		private set
		{
			_003CTotalWidthForHorizontal_003Ek__BackingField = value;
		}
	}

	public GameObject[] GetGos()
	{
		return null;
	}

	public List<ILayoutTableItem> GetItems()
	{
		return null;
	}

	private void Start()
	{
	}

	public override void Init()
	{
	}

	public override void UnInit()
	{
	}

	protected override void EditorExecute()
	{
	}

	public void Execute()
	{
	}

	public override Vector2 GetSize()
	{
		return default(Vector2);
	}
}
