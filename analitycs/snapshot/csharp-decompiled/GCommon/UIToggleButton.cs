using System;
using UnityEngine;

namespace GCommon;

public class UIToggleButton : UIButton
{
	public enum SwitchType
	{
		Alpha,
		Active
	}

	public delegate void OnSelectDelgate(UIToggleButton button);

	public GameObject SelectedObject;

	public GameObject UnSelectedObject;

	public bool IsDefault;

	public SwitchType Switch;

	private bool m_IsSelected;

	private bool m_Inited;

	private bool m_AutoInvokeOnSelect;

	private int m_IndexInGroup;

	public OnSelectDelgate onSelect;

	private UIWidget m_SelectWidget;

	private bool m_SelectEnable;

	private UIWidget m_UnselectWidget;

	private Func<bool> SelectPreCheck;

	private UIWidget SelectWidget => null;

	private UIWidget UnselectWidget => null;

	public bool IsSelected
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int IndexInGroup
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	protected override void OnEnable()
	{
	}

	private void OnToggleSelected()
	{
	}

	public void RefreshButtonStates()
	{
	}

	public void SetButtonSelectEnable(bool enable)
	{
	}

	public void SetbuttonSelectPreCheck(Func<bool> func)
	{
	}

	public void ToggleAutoInvoke(bool value)
	{
	}
}
