using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyIAPBundleController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static OnFinished _003C_003E9__14_0;

		internal void _003CUpdateData_003Eb__14_0()
		{
		}
	}

	private UILobbyIAPBundleView m_View;

	private UIModelIAPBundle m_Model;

	private uint m_AnimDelayCall;

	private uint m_ShiningDealyCall;

	private float m_FlyTime;

	private float m_ShiningTime;

	private Vector3 m_StartPos;

	private Vector3 m_EndPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnIAPBundleButtonClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnUIIAPBundleClose()
	{
	}

	private void ExecuteFlyEffect()
	{
	}

	public void UpdateData()
	{
	}

	private void _003CExecuteFlyEffect_003Eb__13_0()
	{
	}

	private void _003CExecuteFlyEffect_003Eb__13_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
