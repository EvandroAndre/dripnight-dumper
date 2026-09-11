using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UICheckboxButton : UIButton
{
	public bool IsDefualtChecked;

	public GameObject CheckedObject;

	public GameObject UnCheckedObject;

	public OnCheckboxValueChanged OnValueChanged;

	public OnCheckboxValueChangedNtf OnValueChangedNotifyGroup;

	public List<EventDelegate> onValueChange;

	private bool m_IsChecked;

	public bool IsChecked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void Awake()
	{
	}

	private void OnCheckBoxTicked()
	{
	}
}
