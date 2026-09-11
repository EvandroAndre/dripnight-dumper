using GCommon;

namespace COW;

public class UIKolHudItemController : UIEasyListItemController
{
	private UIKolHudItemView m_View;

	private KolHudItemData m_kolItemData;

	private UIModelKolHud m_ModelKolHud;

	private const uint FAKE_HEAD_PIC_ID = 902000007u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnPlayerInfoBtnClick()
	{
	}

	private void OnLikeBtnClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void RefreshLikeInfo()
	{
	}

	private void RefreshPlayerInfo()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
