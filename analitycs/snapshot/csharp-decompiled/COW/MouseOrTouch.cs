using UnityEngine;

namespace COW;

public class MouseOrTouch
{
	public KeyCode key;

	public Vector2 pos;

	public Vector2 lastPos;

	public Vector2 dragStartPos;

	public Vector2 delta;

	public Vector2 totalDelta;

	public GameObject last;

	public GameObject current;

	public GameObject pressed;

	public GameObject dragged;

	public float pressTime;

	public float clickTime;

	public bool touchBegan;

	public bool pressStarted;

	public bool dragStarted;

	public float deltaTime => 0f;
}
