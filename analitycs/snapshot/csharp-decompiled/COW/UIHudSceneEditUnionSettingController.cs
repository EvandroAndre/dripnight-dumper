using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditUnionSettingController : UIBaseController
{
	private UIHudSceneEditUnionSettingView m_View;

	private Action<bool> m_onSelected;

	private Action m_onReposition;

	public UIWidget BG => null;

	public event Action<bool> onSelected
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action onReposition
	{
		add
		{
		}
		remove
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

	public void SetViewData(string title, bool selected, string tips = null)
	{
	}

	public void AddChild(Transform child)
	{
	}

	public void Reposition()
	{
	}

	private void OnClickToggle()
	{
	}

	private void OnReposition()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
