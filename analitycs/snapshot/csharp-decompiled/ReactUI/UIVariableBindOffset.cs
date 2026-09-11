using UnityEngine;

namespace ReactUI;

public sealed class UIVariableBindOffset : UIVariableBindBool
{
	public Vector3 positionIfTrue;

	public Vector3 positionIfFalse;

	public bool enableSetPosition;

	protected override void OnValueChanged()
	{
	}
}
