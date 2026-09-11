using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIPaymentTotalController : UIPaymentController.PaymentTabContentController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<uint> _003C_003E9__9_0;

		internal int _003CUpdateProgressBar_003Eb__9_0(uint p1, uint p2)
		{
			return 0;
		}
	}

	private UIPaymentTotalView m_View;

	private UIModelActivity m_Activity;

	private bool m_NeedPlayAnim;

	private List<UIPaymentTotalItemController> m_Items;

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

	protected override void OnVisibilityChanged()
	{
	}

	public override void RefreshContent()
	{
	}

	private void UpdateProgressBar(uint currentProgress, uint[] progressValues)
	{
	}

	private void OnGotoButtonClick()
	{
	}

	private void OnClickHintBtn()
	{
	}

	private void _003CRefreshContent_003Eb__8_0()
	{
	}

	private void _003CRefreshContent_003Eb__8_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}
}
