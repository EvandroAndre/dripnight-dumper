using System;
using UnityEngine;

namespace GCommon;

public class UIMenuItem : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public Action<UIMenuItem> onClick;

		public UIMenuItem _003C_003E4__this;

		internal void _003CSetClickCallback_003Eb__0()
		{
		}
	}

	public UILabel[] titles;

	public GameObject select;

	public GameObject unSelect;

	public UIWidget size;

	public UIButton button;

	public GameObject[] exObjects;

	private bool m_Selected;

	private UIMenuItem m_ParentMenu;

	private UIMenuItemData m_MenuData;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetMenuData(UIMenuItemData menuData)
	{
	}

	public bool IsMenu(string id)
	{
		return false;
	}

	public void SetSelected(bool value)
	{
	}

	public void DirectlyRunSelectCallback()
	{
	}

	public void SetClickCallback(Action<UIMenuItem> onClick)
	{
	}
}
