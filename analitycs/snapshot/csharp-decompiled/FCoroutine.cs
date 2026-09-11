using System;
using System.Collections;

internal struct FCoroutine : IEquatable<FCoroutine>
{
	public enum EStatus
	{
		ES_Invalid = -1,
		ES_WaitForStart,
		ES_Running,
		ES_WaitForStop,
		ES_Stopped,
		ES_Count
	}

	public IEnumerator Enu;

	public EStatus Status;

	public bool Equals(FCoroutine other)
	{
		return false;
	}
}
