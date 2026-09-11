using System;
using UnityEngine;

namespace COW;

public class UIHUDUGC_IconFlyCell
{
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public UIHUDUGC_IconFlyCell _003C_003E4__this;

		public Color color;

		public Vector3 scale;

		internal void _003CSetIconId_003Eb__0(UIAtlas atlas, string spriteName)
		{
		}
	}

	private GameObject gameObject;

	private UISprite sprite;

	private Transform transform;

	protected string mIconName;

	protected Vector3 mStartPos;

	protected Vector3 mEndPos;

	protected float mSpeed;

	protected Vector3 mMiddlePoint;

	protected float mTime;

	protected int mMinTryMove;

	protected bool mPlayAnimation;

	protected ulong mEndTimeStamp;

	private Action<UIHUDUGC_IconFlyCell> m_PlayEndCall;

	public ulong EndTimeStamp => 0uL;

	public UIHUDUGC_IconFlyCell(int depth = 0)
	{
	}

	public void Destroy()
	{
	}

	public void SetEndCallBack(Action<UIHUDUGC_IconFlyCell> endCall)
	{
	}

	public void SetIconId(string cur, Color color, Vector3 scale)
	{
	}

	public void SetParent(Transform parent)
	{
	}

	public void StartAnimation(Vector3 startPos, Vector3 endPos, float speed = 1f)
	{
	}

	protected virtual void StopAnimation()
	{
	}

	public void Update()
	{
	}
}
