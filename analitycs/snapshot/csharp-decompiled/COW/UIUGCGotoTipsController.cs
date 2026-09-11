using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCGotoTipsController : UIPopupWindowController
{
	private sealed class _003CSetPosition_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCGotoTipsController _003C_003E4__this;

		public Vector3 anchorPos;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetPosition_003Ed__32(int _003C_003E1__state)
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

	private const uint m_DefaultGoPos = 0u;

	private const string m_DefaultSubGoPos = "V2";

	private const UINavigationUtil.UINavigationFrom m_DefaultNavigationFrom = UINavigationUtil.UINavigationFrom.UGCCenter;

	private static UIUGCGotoTipsController m_CurrentTips;

	private UIUGCGotoTipsView m_View;

	private UIRoot m_UIRoot;

	private uint m_GoPos;

	private string m_SubGoPos;

	private string m_GoPosName;

	private string m_GoPosIconName;

	private UINavigationUtil.UINavigationFrom m_NavigationFrom;

	private Action m_GotoCallback;

	private bool m_CloseOnGoto;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static UIUGCGotoTipsController ShowTips(Vector3 anchorPos, string tips, uint goPos, string subGoPos, UINavigationUtil.UINavigationFrom navigationFrom, string goPosName = null, string iconName = null)
	{
		return null;
	}

	public static UIUGCGotoTipsController ShowTips(Vector3 anchorPos, string tips, Action callback, bool closeOnGoto = true, string goPosName = null, string iconName = null)
	{
		return null;
	}

	private static UIUGCGotoTipsController OpenTipsController()
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

	public void SetTips(string tips)
	{
	}

	public void SetGotoData(uint goPos, string subGoPos, Action callback = null, bool closeOnGoto = true, UINavigationUtil.UINavigationFrom navigationFrom = UINavigationUtil.UINavigationFrom.UGCCenter, string goPosName = null, string iconName = null)
	{
	}

	public void SetData(string tips, uint goPos, string subGoPos = "V2", UINavigationUtil.UINavigationFrom navigationFrom = UINavigationUtil.UINavigationFrom.UGCCenter, string goPosName = null, string iconName = null)
	{
	}

	public void SetData(string tips, uint goPos, string subGoPos, UINavigationUtil.UINavigationFrom navigationFrom, string goPosName, string iconName, Action callback, bool closeOnGoto = true)
	{
	}

	public void SetData(Vector3 anchorPos, string tips, uint goPos, string subGoPos = "V2", UINavigationUtil.UINavigationFrom navigationFrom = UINavigationUtil.UINavigationFrom.UGCCenter, string goPosName = null, string iconName = null)
	{
	}

	public void SetData(Vector3 anchorPos, string tips, uint goPos, string subGoPos, UINavigationUtil.UINavigationFrom navigationFrom, string goPosName, string iconName, Action callback, bool closeOnGoto = true)
	{
	}

	public void SetData(Vector3 anchorPos, string tips)
	{
	}

	private void ClearGotoData()
	{
	}

	private void PrepareForShow()
	{
	}

	private void RefreshGotoState()
	{
	}

	private void OnGotoClick()
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
