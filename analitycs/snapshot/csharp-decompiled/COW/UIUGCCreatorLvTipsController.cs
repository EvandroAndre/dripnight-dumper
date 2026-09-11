using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCCreatorLvTipsController : UIPopupWindowController
{
	private sealed class _003CSetPosition_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCCreatorLvTipsController _003C_003E4__this;

		public Vector3 anchorPos;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetPosition_003Ed__18(int _003C_003E1__state)
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

	private const float m_HeightSpace = 40f;

	private static UIUGCCreatorLvTipsController m_CurrentTips;

	private UIUGCCreatorLvTipsView m_View;

	private UIRoot m_UIRoot;

	private Texture m_DefaultTexture;

	private UINetworkTexture m_NetworkTexture;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static UIUGCCreatorLvTipsController ShowTips(Vector3 anchorPos, string title, string description, string textureUrl = "")
	{
		return null;
	}

	private static UIUGCCreatorLvTipsController OpenTipsController()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	public void SetData(Vector3 anchorPos, string title, string description, string textureUrl = "")
	{
	}

	public void SetText(string title, string description)
	{
	}

	public void SetTextureUrl(string textureUrl)
	{
	}

	private void RestoreDefaultTexture()
	{
	}

	private void EnsureNetworkTexture()
	{
	}

	private void PrepareForShow()
	{
	}

	private IEnumerator SetPosition(Vector3 anchorPos)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}
}
