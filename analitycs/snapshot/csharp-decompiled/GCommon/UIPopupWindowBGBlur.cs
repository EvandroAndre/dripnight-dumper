using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace GCommon;

public class UIPopupWindowBGBlur : MonoBehaviour
{
	private sealed class _003CGetSomeTimeForGlassBlur_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject obj;

		public UIPopupWindowBGBlur _003C_003E4__this;

		private UIPopupWindowController _003Cctrl_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CGetSomeTimeForGlassBlur_003Ed__18(int _003C_003E1__state)
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

	private sealed class _003CGetSomeTimeForGlassBlurList_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<GameObject> objs;

		public UIPopupWindowBGBlur _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CGetSomeTimeForGlassBlurList_003Ed__19(int _003C_003E1__state)
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

	private Shader m_Shader;

	private Material m_Material;

	private Camera m_Camera;

	private CommandBuffer m_CommandBuffer;

	private RenderTexture m_blurTexture;

	private bool m_NeedExec;

	private Dictionary<GameObject, Vector3> m_lastPosDic;

	public bool Initialized => false;

	public void Cleanup()
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void Refresh(object[] data)
	{
	}

	private void Initialize()
	{
	}

	private void OnPostRender()
	{
	}

	public void ExecCommandBuffer(GameObject root)
	{
	}

	public void ExecCommandBuffer(List<GameObject> roots)
	{
	}

	public void ExecCommandBufferNoRoot()
	{
	}

	private IEnumerator GetSomeTimeForGlassBlur(GameObject obj)
	{
		return null;
	}

	private IEnumerator GetSomeTimeForGlassBlurList(List<GameObject> objs)
	{
		return null;
	}

	public static bool NeedGlassBlur()
	{
		return false;
	}
}
