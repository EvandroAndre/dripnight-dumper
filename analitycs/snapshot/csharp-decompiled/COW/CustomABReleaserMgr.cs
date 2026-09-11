using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class CustomABReleaserMgr
{
	private static CustomABReleaserMgr m_Instance;

	private List<string> m_StringLUT;

	private Dictionary<int, int> m_ABInstanceID2ABPath;

	private Dictionary<int, int> m_ABPath2RefCount;

	private Dictionary<int, int[]> m_ABPath2Dependencies;

	private HashSet<int> m_IgnoreHash;

	private List<int> m_ClearKeysCache1;

	private List<int> m_ClearKeysCache2;

	private bool m_Enable;

	private bool m_IsValid;

	public static CustomABReleaserMgr instance => null;

	public void Init()
	{
	}

	public void Clear()
	{
	}

	public bool GetEnable()
	{
		return false;
	}

	public void SetValid(bool isValid)
	{
	}

	public bool GetValid()
	{
		return false;
	}

	public bool IsManaged(int abInstanceID)
	{
		return false;
	}

	private void IncreaseRefCount(int abPathIndex)
	{
	}

	private void DecreaseRefCount(int abPathIndex)
	{
	}

	public void Add(int abInstanceID, string abPath, string[] dependencies, bool isIgnore)
	{
	}

	public void AttachComponent(GameObject go, int abInstanceID, bool isFromABInstance = true)
	{
	}

	public void Remove(int abInstanceID)
	{
	}

	private void Release()
	{
	}

	private bool RemoveStringLUTAt(int index)
	{
		return false;
	}

	private bool LookUpStringIndex(string str, out int index)
	{
		index = default(int);
		return false;
	}

	private int CalculateStringIndex(string str)
	{
		return 0;
	}

	private string GetString(int index)
	{
		return null;
	}
}
