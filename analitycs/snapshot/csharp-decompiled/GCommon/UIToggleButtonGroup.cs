using UnityEngine;

namespace GCommon;

public class UIToggleButtonGroup : MonoBehaviour
{
	public delegate void OnItemSelect(UIToggleButton selectButton);

	public delegate void OnItemUnSelect(UIToggleButton selectButton);

	public delegate void OnItemAwakeFinished();

	public UIToggleButton[] toggleButtons;

	public UIToggleButton DefaultClickBtn;

	public OnItemSelect OnItemSelectCallback;

	public OnItemSelect OnItemUnSelectCallback;

	public OnItemAwakeFinished OnAwakeCallback;

	private void Awake()
	{
	}

	protected virtual void OnAwake()
	{
	}

	private void OnDestroy()
	{
	}

	public void ResetAllToggleButton(bool includeInactive = true)
	{
	}

	public void ToggleGroupAutoInvoke(bool enable)
	{
	}

	public virtual void OnSelectButton(UIToggleButton selectedButton)
	{
	}

	public void OnSelectItemByIndex(int index)
	{
	}

	public void RefreshButtonStates()
	{
	}

	public void RebindButtons()
	{
	}

	public void SetToggleButtonSelectEnable(bool enable)
	{
	}
}
