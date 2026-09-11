using UnityEngine;

namespace COW;

public class UITrainingToggleSetting : MonoBehaviour
{
	public ETrainingToggleType ToggleType;

	public UIToggle NoneToggle;

	public UIToggle Lv1Toggle;

	public UIToggle Lv2Toggle;

	public UIToggle Lv3Toggle;

	public UIToggle Lv4Toggle;

	private void Start()
	{
	}

	private void OnValueChange()
	{
	}

	private void OnChangeHandler(ETrainingToggleType toggleType, uint value)
	{
	}
}
