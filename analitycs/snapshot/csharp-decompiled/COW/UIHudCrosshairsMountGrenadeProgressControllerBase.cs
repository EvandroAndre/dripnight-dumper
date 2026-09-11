using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCrosshairsMountGrenadeProgressControllerBase : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public UIHudCrosshairsMountGrenadeProgressControllerBase _003C_003E4__this;

		public int count;

		public int interval;

		internal void _003CSetProgress_003Eb__0()
		{
		}

		internal void _003CSetProgress_003Eb__1()
		{
		}
	}

	protected float m_ProgressWidth;

	protected Vector3 m_ProgressItemOffset;

	protected int m_Count;

	protected int m_MaxCount;

	protected uint m_LastEffectTickCount;

	protected float m_CD;

	protected bool m_InCD;

	private uint m_DelayCall;

	private uint m_DelayCallMaxCount;

	private List<GameObject> m_ProgressSprites;

	private List<GameObject> m_ProgressSpritesFulfill;

	private List<GameObject> m_ProgressSpritesHighlight;

	private List<GameObject> m_ProgressSpritesPool;

	public virtual GameObject GetTemplate()
	{
		return null;
	}

	public virtual Transform GetRootNode()
	{
		return null;
	}

	public virtual int GetAmplifyRatio()
	{
		return 0;
	}

	public void InitProgress(int count, float cd, uint lastEffectTimeTickCount)
	{
	}

	public void SetProgress(int count, int interval)
	{
	}

	private void Update()
	{
	}
}
