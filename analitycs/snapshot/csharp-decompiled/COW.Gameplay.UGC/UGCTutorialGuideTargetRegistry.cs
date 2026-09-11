using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public static class UGCTutorialGuideTargetRegistry
{
	private static Dictionary<string, UIWidget> s_Widgets;

	private static Dictionary<string, Vector3> s_Positions;

	private static Dictionary<string, GameObject> s_GameObjects;

	public static void Register(string key, UIWidget widget)
	{
	}

	public static void Unregister(string key)
	{
	}

	public static UIWidget GetWidget(string key)
	{
		return null;
	}

	public static void RegisterPosition(string key, Vector3 position)
	{
	}

	public static void UnregisterPosition(string key)
	{
	}

	public static bool TryGetPosition(string key, out Vector3 position)
	{
		position = default(Vector3);
		return false;
	}

	public static void RegisterGameObject(string key, GameObject go)
	{
	}

	public static void UnregisterGameObject(string key)
	{
	}

	public static GameObject GetGameObject(string key)
	{
		return null;
	}

	public static void Clear()
	{
	}
}
