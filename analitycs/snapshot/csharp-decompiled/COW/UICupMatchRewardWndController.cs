using GCommon;

namespace COW;

public class UICupMatchRewardWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UICupMatchRewardWndView m_View;

	private UIModelCupMatch m_ModelCupMatch;

	private uint m_CupMatchType;

	private uint m_CupMatchID;

	private int m_CupMatchKey;

	private UICupMatchRewardBoxAnimController m_BoxCtrl;

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

	public void SetData(uint cupMatchType, uint cupMatchID)
	{
	}

	private void RefreshView()
	{
	}

	private void HideAllUI()
	{
	}

	private void OnClaimBtnClick()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnGotoBtnClick()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
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

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
