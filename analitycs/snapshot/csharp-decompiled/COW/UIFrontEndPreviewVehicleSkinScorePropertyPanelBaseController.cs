using System.Collections.Generic;

namespace COW;

public abstract class UIFrontEndPreviewVehicleSkinScorePropertyPanelBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewVehicleSkinScorePropertyPanelBaseView>
{
	private List<UICollectionVehicleSkinScoreItemController> m_VeicleSkinScoreList;

	protected override void InitView()
	{
	}

	public bool RefreshVehicleSkinPropertyScore(uint itemid)
	{
		return false;
	}

	public void RepositionProperty()
	{
	}

	protected virtual UICollectionVehicleSkinScoreItemController GetUICollectionVehicleSkinScoreItemController()
	{
		return null;
	}

	public void SetScrollViewPanelDepth(int depth)
	{
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}
}
