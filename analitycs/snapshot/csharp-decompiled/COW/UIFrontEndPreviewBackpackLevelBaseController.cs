using System.Collections.Generic;
using GCommon;

namespace COW;

public abstract class UIFrontEndPreviewBackpackLevelBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewBackpackLevelBaseView>
{
	protected List<UIToggleButton> m_BackPackBtn;

	private bool m_IsShow;

	protected override void InitView()
	{
	}

	protected virtual void InitBackPackBtnList()
	{
	}

	private void RefreshCollectionItemByLv(ECollectionLevel collectionLevel)
	{
	}

	public void ClickDefaultBackPack()
	{
	}

	public virtual uint GetBackpackSelectLevel()
	{
		return 0u;
	}

	public void ShowBackpackLevel()
	{
	}

	public void HideBackpackLevel()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public bool IsShowBackpackLevel()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
