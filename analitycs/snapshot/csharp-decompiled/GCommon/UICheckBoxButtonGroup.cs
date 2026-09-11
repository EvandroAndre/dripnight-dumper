using UnityEngine;

namespace GCommon;

public class UICheckBoxButtonGroup : MonoBehaviour
{
	public delegate void OnItemCheck(UICheckboxButton checkbox);

	public UICheckboxButton[] checkBoxButtons;

	public OnItemCheck OnItemCheckCallback;

	private int m_MaxCheckBoxOnCount;

	private int checkBoxOnCount;

	public int MaxCheckBoxOnCount
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

	protected virtual void OnAwake()
	{
	}

	public void ResetAllCheckBoxButton()
	{
	}

	public virtual void OnCheckBoxButton(UICheckboxButton selectedButton)
	{
	}

	public void RebindButtons()
	{
	}

	public void SetcheckBoxButtonEnable(bool enable)
	{
	}
}
