using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Lean.Touch;
using UnityEngine;

namespace COW;

internal class UIUGCPhotoCutWindowController : UIPopupWindowController
{
	private enum Orientation
	{
		UP,
		RIGHT,
		DOWN,
		LEFT
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public RenderTexture renderTexture;

		public Rect coverScreenRect;

		public int captureWidth;

		public int captureHeight;

		public UIUGCPhotoCutWindowController _003C_003E4__this;

		internal void _003CBtnOnSaveAsCover_003Eb__0()
		{
		}
	}

	private UIUGCPhotoCutWindowView m_View;

	private UIRoot m_Root;

	private float m_TweenTime;

	private bool m_IsPressed;

	private bool m_IsRotate;

	private bool m_IsApproaching;

	private AnimationCurve m_ApproachCurse;

	private AnimationCurve m_RotateCurse;

	private Vector3 m_OriginPos;

	private Vector3 m_DestPos;

	private Vector3 m_OriginScale;

	private Vector3 m_DestScale;

	private Orientation m_OriginOrientation;

	private Orientation m_DestOrientation;

	private SceneEditSlotInfo m_SlotInfo;

	private HNDHJGJILHC mEditGame;

	public Action Callback;

	private static Dictionary<int, Quaternion> m_Orientation2Rotation;

	private int m_CoverHeight;

	private int m_CoverWidth;

	private void Update()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetImage(string path)
	{
	}

	public void SetSlotInfo(SceneEditSlotInfo info)
	{
	}

	private void OnBgPress(GameObject go, bool state)
	{
	}

	private void OnBgGesture(List<LeanFinger> fingers)
	{
	}

	private void OnBgDrag(GameObject go, Vector2 delta)
	{
	}

	private void CheckApproach()
	{
	}

	private void AutoApproach(float time)
	{
	}

	private void DoRotate()
	{
	}

	private void BtnOnClose()
	{
	}

	private void BtnOnSaveAsCover()
	{
	}

	private Rect GetCoverPreviewScreenRect()
	{
		return default(Rect);
	}

	private void AutoRoatate(float time)
	{
	}

	public bool CanInteractive()
	{
		return false;
	}

	protected override void OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
