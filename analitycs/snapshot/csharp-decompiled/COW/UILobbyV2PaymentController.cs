using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2PaymentController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public uint entranceType;

		internal void _003CRefreshPaymentView_003Eb__0()
		{
		}
	}

	private UILobbyV2PaymentView m_View;

	private UIModelActivity m_ModelActivity;

	private UIModelPayment m_ModelPayment;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private UICountDownController m_PaymentCountDownCtrl;

	private uint m_PaymentType;

	private uint m_AnimDelayCall;

	private float m_FlyTime;

	private uint m_LastPaymentType;

	private Vector3 m_StartPos;

	private Vector3 m_EndPos;

	private ResourceID m_VFXResId;

	private GameObject m_VFXObj;

	private UITipsNormalController m_TipsCtrl;

	private UILobbyV2PaymentSquadTreasureDAController m_SquadTreasureDACtrl;

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

	private void OnPaymentBtnClick()
	{
	}

	public void RefreshPaymentView(ulong paymentEndTime, uint paymentType, uint entranceType)
	{
	}

	private void RefreshVFX()
	{
	}

	private void RefreshSpecialVFX()
	{
	}

	private void HideSpecialVFX()
	{
	}

	private void InstantVFXObj()
	{
	}

	private void DestroyVFXObj()
	{
	}

	public void ResetTipsContainer(bool isShow)
	{
	}

	private void OnGrowthFundV2Close()
	{
	}

	private void ExecuteFlyEffect()
	{
	}

	private string GetTitleLabel()
	{
		return null;
	}

	private void InitTipsView()
	{
	}

	private void _003CExecuteFlyEffect_003Eb__27_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
