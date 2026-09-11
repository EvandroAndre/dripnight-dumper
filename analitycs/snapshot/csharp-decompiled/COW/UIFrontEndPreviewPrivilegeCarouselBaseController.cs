using System.Collections.Generic;
using proto;

namespace COW;

public abstract class UIFrontEndPreviewPrivilegeCarouselBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewPrivilegeCarouselBaseView>
{
	private class LegendClothGopos
	{
		public GoPos GoPosData;

		public bool IsOwned;
	}

	private List<LegendClothPrivilege> m_DataList;

	private LegendClothGopos m_GoPos;

	private bool m_TweenProgrossBar;

	private uint m_LegendClothId;

	private int m_LastSelectedIndex;

	private float m_CarouselTimer;

	private const float CarouselInterval = 5f;

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public override int GetAdditionalDepthOnPopWnd()
	{
		return 0;
	}

	public void SetScrollViewPanelDepth(int depth)
	{
	}

	private void OnGotoBtnClick()
	{
	}

	private void ResetData()
	{
	}

	public void SetViewData(List<LegendClothPrivilege> dataList, uint legendClothId)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public int _003C_003EiFixBaseProxy_GetAdditionalDepthOnPopWnd()
	{
		return 0;
	}
}
