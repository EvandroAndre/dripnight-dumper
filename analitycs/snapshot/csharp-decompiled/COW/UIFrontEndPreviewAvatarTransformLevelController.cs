using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIFrontEndPreviewAvatarTransformLevelController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewAvatarTransformLevelBaseView>
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public int index;

		public UIFrontEndPreviewAvatarTransformLevelController _003C_003E4__this;

		internal void _003CInitBackPackBtnList_003Eb__0()
		{
		}
	}

	protected List<UIToggleButton> m_BackPackBtn;

	private bool m_IsShow;

	private UIFrontEndPreviewAvatarTransformLevelView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitView()
	{
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewAvatarTransformLevelBaseView InitBaseView()
	{
		return null;
	}

	protected virtual void InitBackPackBtnList()
	{
	}

	private void RefreshCollectionItemByLv(int index)
	{
	}

	public void ClickDefaultAvatarTransform()
	{
	}

	public void UpdateLevelKey(string key1, string key2)
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

	public bool IsShowAvatarTransformLevel()
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
