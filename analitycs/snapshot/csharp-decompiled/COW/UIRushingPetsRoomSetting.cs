using System;
using UnityEngine;
using message;

namespace COW;

public class UIRushingPetsRoomSetting : MonoBehaviour
{
	public UILabel Title;

	public UIToggle Toggle;

	private Action<LDFLOLDLEOH, uint> m_ToggeleCB;

	private LDFLOLDLEOH paramType;

	public void Init()
	{
	}

	public void SetCallBack(Action<LDFLOLDLEOH, uint> toggleCB)
	{
	}

	private void OnToggleChanged()
	{
	}

	public void InitInfo(LDFLOLDLEOH curType, string key, bool toggle)
	{
	}
}
