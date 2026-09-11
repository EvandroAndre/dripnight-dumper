using System;
using UnityEngine;

namespace COW;

public class UILongPress : MonoBehaviour
{
	public UIButton button;

	public float longPressTime;

	public Action<bool> onLongPress;

	private bool isPressing;

	private float pressTimer;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnPressHandler(GameObject obj, bool isDown)
	{
	}
}
