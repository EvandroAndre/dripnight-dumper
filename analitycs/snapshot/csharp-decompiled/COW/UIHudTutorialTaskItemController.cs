using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTutorialTaskItemController : UIEasyListItemController
{
	private sealed class _003CCoComplete_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudTutorialTaskItemController _003C_003E4__this;

		public Action onFinished;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoComplete_003Ed__21(int _003C_003E1__state)
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

	private const float GlowDuration = 0.9f;

	private const float LineFxDelay = 1f;

	private const float CompleteFxDuration = 0.85f;

	private UIHudTutorialTaskItemView m_View;

	private HudTutorialTaskPayload m_Payload;

	private Coroutine m_CompleteRoutine;

	private UIWidget m_RootWidget;

	private GameObject m_LineFxNode;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindScrollView(UIScrollView scrollView)
	{
	}

	private void OnClickTaskItem()
	{
	}

	private static bool TryResolveMarkObjectType(UIModelBRTutorialTask model, uint taskId, out OPICPDCLKAG objectType)
	{
		objectType = default(OPICPDCLKAG);
		return false;
	}

	private void MarkNearestLevelObject(OPICPDCLKAG objectType)
	{
	}

	private static BaseLevelObject FindNearestLevelObject(NAHFMFGGCDN levelObjectMgr, OPICPDCLKAG objectType, Vector3 fromPos)
	{
		return null;
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void RefreshDescription(HudTutorialTaskPayload payload)
	{
	}

	public void ShowTask(bool playItemAnim)
	{
	}

	public void HideTask()
	{
	}

	public void StopCompleteSequence()
	{
	}

	public void PlayCompleteSequence(Action onFinished)
	{
	}

	private IEnumerator CoComplete(Action onFinished)
	{
		return null;
	}

	private void ResetTransientVisuals()
	{
	}

	private static void PlayEffectObject(GameObject effectRoot)
	{
	}

	private static void PlayPersistentEffectObject(GameObject effectRoot)
	{
	}

	private static void StopEffectObject(GameObject effectRoot)
	{
	}

	private void PlayLineEffect()
	{
	}

	private GameObject FindLineFxNode()
	{
		return null;
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
