using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPrivilegeItemIconController : MonoBehaviour
{
	public UIButton m_Btn;

	public UISprite m_Icon;

	public int m_Index;

	public Action<int> m_OnPrivilegeItemClick;

	public void SetIcon(ResourceID iconRes)
	{
	}

	public void SetOnClick(Action<int> onClick, int index)
	{
	}

	private void OnBtnClick()
	{
	}

	public int GetHeight()
	{
		return 0;
	}

	public int GetWidth()
	{
		return 0;
	}
}
