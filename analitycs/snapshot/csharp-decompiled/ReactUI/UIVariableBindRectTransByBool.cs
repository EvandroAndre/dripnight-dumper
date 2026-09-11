using UnityEngine;

namespace ReactUI;

public class UIVariableBindRectTransByBool : UIVariableBindBool
{
	public enum RectTransModeEnum
	{
		AnchorPos,
		SizeDelta,
		Rotate,
		Scale,
		Pivot,
		OffsetMin,
		OffsetMax
	}

	private RectTransform rectTrans;

	private RectTransModeEnum transMode;

	private Vector3 trueValue;

	private Vector3 falseValue;

	private float duration;

	protected override void OnValueChanged()
	{
	}
}
