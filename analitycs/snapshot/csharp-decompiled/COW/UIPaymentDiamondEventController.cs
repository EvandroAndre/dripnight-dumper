using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentDiamondEventController : UIPaymentController.PaymentTabContentController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static OnFinished _003C_003E9__39_0;

		internal void _003CRefreshCountDownTime_003Eb__39_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public uint goPosType;

		public uint goPos;

		public string subPos;

		internal void _003CRefreshContentWithoutAnim_003Eb__0()
		{
		}
	}

	private sealed class _003CStartRunProgress_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPaymentDiamondEventController _003C_003E4__this;

		public float progress;

		private float[] _003Cparts_003E5__2;

		private int _003CcurrentIndex_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartRunProgress_003Ed__36(int _003C_003E1__state)
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

	private UIPaymentDiamondEventView m_View;

	private UIModelPayment m_model;

	private List<UIPaymentDiamondItemController> m_Items;

	private string m_ItemIdentifier;

	private bool m_Purchased;

	private int[] m_DiscountFontSize;

	private int[] m_OffFontSize;

	private Color[] m_OutLineColor;

	private Color[] m_BackgroundColor;

	private Color[] m_BackLineColor;

	private Color[] m_PointColor;

	private Color[] m_BackgroundTriangleColor;

	private Vector2[] m_BackgroundTriangleSize;

	private int[] m_BackgroundTrianglePositionY;

	private string[] m_EffectID;

	private string[] m_SoundID;

	private int m_DefaultLabelSize;

	private Color m_DefaultColor;

	private Vector2 m_DefaultSize;

	private int m_DefaultPositionY;

	private Action m_ClickGoPos;

	private float m_Progress;

	private uint m_DiamondCount;

	private int m_CurrentIndex;

	private bool m_IsNeedRefresh;

	private const int LSMCOUNT = 4;

	private const int ITEMWIDTH = 260;

	private List<UILabel> m_CountLabels;

	private IEnumerator m_ProgressCoroutine;

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

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void RefreshContent()
	{
	}

	private void RefreshDiamondItemList(int diamondCount)
	{
	}

	private IEnumerator StartRunProgress(float progress)
	{
		return null;
	}

	private void RefreshContentWithoutAnim()
	{
	}

	private void OnPurchased(string productIdentifier)
	{
	}

	private void RefreshCountDownTime()
	{
	}

	private void OnClickGoPos()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}
}
