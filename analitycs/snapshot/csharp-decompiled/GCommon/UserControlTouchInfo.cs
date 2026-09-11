using UnityEngine;

namespace GCommon;

public class UserControlTouchInfo
{
	public int TouchFinger;

	public Vector3 TouchPosition;

	public TouchPhase TouchPhase;

	public Vector3 DeltaPosition;

	public void Copy(UserControlTouchInfo t)
	{
	}
}
