using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHippoCrisisPreStartRecommendController : UINavigationController, IUIModelDataChangeObserver
{
	private UIHippoCrisisPreStartRecommendView m_View;

	private UIHippoCrisisCommonTopCurrencyController m_CurrencyCtrl;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private List<UIHippoCrisisRecommendEquipmentController> m_Ctrls;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	private void InitTopRightBar()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void InitRecommendPreset()
	{
	}

	private void AddBestOwnedEquipments()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}
}
