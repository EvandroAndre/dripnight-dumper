using System;
using System.Collections.Generic;
using UnityEngine;

public class UnityThread : MonoBehaviour
{
	private static UnityThread _I;

	private static List<Action> _UpdateActionsPending;

	private List<Action> _UpdateActionsExecuting;

	private static bool _HasUpdateActions;

	private static int _UnityMainThreadId;

	public static bool IsUnityMainThread => false;

	public static void Init(bool visible = false)
	{
	}

	private void Awake()
	{
	}

	public static void RunInUpdate(Action action)
	{
	}

	public static void ActionUpdate()
	{
	}

	private void Update()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public static void RunOnUnityMainThread(Action action)
	{
	}
}
