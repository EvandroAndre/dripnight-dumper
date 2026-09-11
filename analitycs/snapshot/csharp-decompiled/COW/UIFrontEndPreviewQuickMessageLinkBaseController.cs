using System;
using proto;

namespace COW;

public abstract class UIFrontEndPreviewQuickMessageLinkBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewQuickMessageLinkBaseView>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BundleShowData, uint> _003C_003E9__4_0;

		internal uint _003CSetMsgId_003Eb__4_0(BundleShowData item)
		{
			return 0u;
		}
	}

	private uint m_MsgId;

	private bool m_IsCommonRewardWnd;

	protected override void InitView()
	{
	}

	private void OnGotoBtnClick()
	{
	}

	public void SetMsgId(uint id, bool isCommonRewardWnd)
	{
	}

	public void SetMainPanelDepth(int depth)
	{
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}
}
