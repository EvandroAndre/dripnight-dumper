using GCommon;
using UnityEngine;

namespace COW;

public abstract class UIFrontEndPreviewBooyahPassPreviewBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewBooyahPassPreviewBaseView>, IEasyList
{
	private UIModelBooyahPass m_ModelBooyahPass;

	private bool m_HasInitPriviewView;

	private int m_LastSelectIndex;

	protected override void InitView()
	{
	}

	public void RefreshPreviewView()
	{
	}

	private void InitPreviewView()
	{
	}

	private void OnBooyahPassPreviewSmallItemClick(object[] data)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}
}
