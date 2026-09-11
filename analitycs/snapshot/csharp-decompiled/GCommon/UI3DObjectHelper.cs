using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UI3DObjectHelper : MonoBehaviour
{
	public Transform[] RegistedObjects;

	private Dictionary<string, Transform> m_RegistedObjectDict;

	private bool m_HideForGroupAnim;

	private ulong m_GroupBgAccountId;

	public Dictionary<string, Transform> RegistedObjectDict => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnLobbyVisibleChanged(object[] data)
	{
	}

	private void RefreshRegistedObjectDict()
	{
	}

	public Transform GetRegistedObjectWithName(string name)
	{
		return null;
	}
}
