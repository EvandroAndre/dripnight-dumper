using System;
using System.Collections.Generic;

public class UIEventMutex
{
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public UIEventMutex _003C_003E4__this;

		public int Id;

		internal void _003CSetMutex_003Eb__0()
		{
		}
	}

	private HashSet<int> m_MutexList;

	public bool IsMutex(int Id)
	{
		return false;
	}

	public void SetMutex(int Id, uint autoReleaseTimeMs = 0u)
	{
	}

	public void ReleaseMutex(int Id)
	{
	}

	public bool Check(int Id, Action callback, uint autoReleaseTimeMs = 0u)
	{
		return false;
	}

	public void Clear()
	{
	}
}
