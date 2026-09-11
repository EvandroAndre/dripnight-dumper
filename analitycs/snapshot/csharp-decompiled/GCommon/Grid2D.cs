using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class Grid2D<T> where T : GridValueBase, new()
{
	private Rectangle2D m_Shape;

	private float m_HalfLength;

	private float m_HalfWidth;

	private int m_ColumnCount;

	private int m_RowCount;

	private Dictionary<int, T> m_Values;

	private int m_GridCount;

	private Vector2 m_GridSize;

	public int ColumnCount => 0;

	public int RowCount => 0;

	public Grid2D(Vector3 pos, float length, float width, float grid_length_size, float grid_width_size)
	{
	}

	public Grid2D(Vector3 leftBottom, Vector3 rightTop, float grid_length_size, float grid_width_size)
	{
	}

	public Dictionary<int, T> GetAllValues()
	{
		return null;
	}

	public T GetValue(Vector3 pos)
	{
		return null;
	}

	public List<T> GetValusArroundPosition(Vector3 pos, int radius, List<T> resultList = null)
	{
		return null;
	}

	public List<T> GetValuesArroundIndex(int index, int radius, List<T> resultList)
	{
		return null;
	}

	public Vector3 GetGridCoordinateByIndex(int index)
	{
		return default(Vector3);
	}

	public void SetValue(Vector3 pos, T value)
	{
	}

	public T GetValue(int index)
	{
		return null;
	}

	public void SetValue(int index, T value)
	{
	}

	public bool IsPointInside(Vector3 pos, float margin = 0f)
	{
		return false;
	}

	public Vector3 GetGridPos(Vector3 pos)
	{
		return default(Vector3);
	}

	public T GetValueByCoordinate(int row, int column)
	{
		return null;
	}

	public Vector3 GetGridCoordinate(Vector3 pos)
	{
		return default(Vector3);
	}

	public Vector3 GetGridCoordinatePos(Vector3 pos)
	{
		return default(Vector3);
	}

	public Vector3 GetGridCoordinatePosByIndex(int index)
	{
		return default(Vector3);
	}

	public Vector3 GetGridPosByCoordinate(Vector3 coordinate)
	{
		return default(Vector3);
	}

	private int GetIndexByXZ(Vector3 pos)
	{
		return 0;
	}

	public void ClearAllValues()
	{
	}

	public void Destroy()
	{
	}
}
