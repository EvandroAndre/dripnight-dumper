using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIGameModeNewPlayerUnlockFeaturePopController : UIPopupWindowController
{
	private sealed class _003CSetPosition_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGameModeNewPlayerUnlockFeaturePopController _003C_003E4__this;

		public Vector3 itempos;

		private Transform _003CcontentTr_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetPosition_003Ed__24(int _003C_003E1__state)
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

	private UIGameModeNewPlayerUnlockFeaturePopView m_View;

	private const float m_HeightSpace = 40f;

	private UIRoot m_UIRoot;

	private DLBMPCCFKKM m_MatchMode;

	private NIKKALKPIBO m_GameMode;

	private uint m_UnlockEventID;

	private uint m_ActivityID;

	private UIModelNewPlayerUnlockFeature m_ModelUnlockFeature;

	private GameplayAffixEventData m_ActivityEventData;

	public Vector2 NewPlayerTitleSize;

	public Vector2 FeatureTitleSize;

	public Vector2 FeatureItemSize;

	public Vector2 AffixDetailSize;

	public UITable2.Margin NewPlayerTitleMargin;

	public UITable2.Margin FeatureTitleMargin;

	public UITable2.Margin FeatureItemMargin;

	public UITable2.Margin AffixDetailMargin;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void SetViewData(DLBMPCCFKKM matchMode, NIKKALKPIBO gameMode, Vector3 itempos)
	{
	}

	private void InitTable2Template()
	{
	}

	private void InitDetailItem()
	{
	}

	private IEnumerator SetPosition(Vector3 itempos)
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__22_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__22_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__22_2()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
