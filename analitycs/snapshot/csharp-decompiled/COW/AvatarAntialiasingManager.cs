using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class AvatarAntialiasingManager : MonoSingleton<AvatarAntialiasingManager>
{
	private sealed class _003CDelaySetAntialiasing_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AvatarAntialiasingManager _003C_003E4__this;

		public int samples;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelaySetAntialiasing_003Ed__25(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private HashSet<SkinnedMeshRenderer> rendererList;

	private static bool _isValid;

	private static bool _suppress;

	private static int lowAA;

	private static int midAA;

	private static int highAA;

	private static List<string> shaders;

	private static int antialiasingSetFrame;

	private static int bannedFrame;

	public static bool isValid => false;

	public static void SetValid(bool valid)
	{
	}

	public static void SetSuppress(bool value)
	{
	}

	public static bool IsSafeToDrawGraphics()
	{
		return false;
	}

	public static void DontSetAntialiasingThisFrame()
	{
	}

	public override void Init()
	{
	}

	public void AddRenderer(SkinnedMeshRenderer renderer)
	{
	}

	private void AddAndTrackRenderer(SkinnedMeshRenderer renderer)
	{
	}

	private bool RemoveAndUntrackRenderer(SkinnedMeshRenderer renderer, bool removeFromList = true)
	{
		return false;
	}

	public void RemoveRenderer(SkinnedMeshRenderer renderer)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void CheckOnVisibilityChange(RendererVisibilityNotifier notifier)
	{
	}

	private void Refresh(object[] data)
	{
	}

	public void Check(SkinnedMeshRenderer renderer, bool assertInList = false)
	{
	}

	public void Check()
	{
	}

	private IEnumerator DelaySetAntialiasing(int samples)
	{
		return null;
	}

	private void SetAntialiasing(int samples)
	{
	}

	private void SetAntialiasingImmediately(int samples, bool force = false)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
