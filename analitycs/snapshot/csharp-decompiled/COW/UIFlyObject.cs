using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIFlyObject : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public UIFlyObject _003C_003E4__this;

		public Vector3 fromPoint;

		public Vector3 toPoint;

		public float fromAlpha;

		public float toAlpha;

		public Vector3 fromScaleV;

		public Vector3 toScaleV;

		public float speed;

		internal void _003CStartFly_003Eb__0(uint ticket, bool succeeded, UnityEngine.Object obj)
		{
		}
	}

	public Transform ShowNode;

	public TweenPositionArcWithScaleAndAlpha AnimCtrl;

	private Action endCallBackCache;

	private GameObject m_FlyVfxObj;

	public bool StartFly(string startUIName, string startViewPoint, string endUIName, string endViewPoint, ResourceID flyFx, Action endCallBack = null, float speed = 1f, float fromAlpha = 1f, float toAlpha = 1f, float fromScale = 1f, float toScale = 1f)
	{
		return false;
	}

	public bool StartFly(Vector3 fromPoint, Vector3 toPoint, ResourceID flyFx, Action endCallBack = null, float speed = 1f, float fromAlpha = 1f, float toAlpha = 1f, float fromScale = 1f, float toScale = 1f)
	{
		return false;
	}

	public bool FindPosFromUINameAndViewPoint(string uiName, string viewPoint, out Vector3 point)
	{
		point = default(Vector3);
		return false;
	}

	private void OnAnimEnd(TweenPositionArc flyObj)
	{
	}
}
