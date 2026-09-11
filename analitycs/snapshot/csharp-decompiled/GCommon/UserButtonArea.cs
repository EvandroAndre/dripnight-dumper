using UnityEngine;

namespace GCommon;

public class UserButtonArea
{
	private Vector2 m_Position;

	private Vector2 m_Size;

	private EInputButtonType m_ButtonType;

	private bool m_Enable;

	public UserButtonArea(int key, Vector2 pos, Vector2 size, EInputButtonType buttonType, bool isEnable = true)
	{
	}

	public void Update(Vector2 pos, Vector2 size, EInputButtonType buttonType, bool isEnable)
	{
	}

	public bool InButtonRange(Vector2 point)
	{
		return false;
	}

	public void Enable(bool v)
	{
	}

	public bool IsEnable()
	{
		return false;
	}
}
