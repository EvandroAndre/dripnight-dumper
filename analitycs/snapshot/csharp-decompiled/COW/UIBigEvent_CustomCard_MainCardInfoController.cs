using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomCard_MainCardInfoController : UICustomCardBaseInfoController
{
	private UIBigEvent_CustomCard_MainCardInfoView m_View;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIModelBigEvent_CustomCard m_UIModelCustomCard;

	private float m_delay;

	private uint m_AnimDelayKey;

	private ResourceID m_AppearEffectVFXResID;

	private GameObject m_AppearEffectVFXGO;

	private const string ENTER_ANIM = "UIFX_Ui_CustomCard_MainCard_In";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void InitAnim(float delay)
	{
	}

	private void OnPlayEnterAnim()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected override string GetCdnUrl()
	{
		return null;
	}

	private void OnClickWishBtn()
	{
	}

	private void OnClickCardBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public string _003C_003EiFixBaseProxy_GetCdnUrl()
	{
		return null;
	}
}
