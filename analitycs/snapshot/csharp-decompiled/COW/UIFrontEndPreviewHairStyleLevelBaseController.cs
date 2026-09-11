using System.Collections.Generic;
using GCommon;

namespace COW;

public abstract class UIFrontEndPreviewHairStyleLevelBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewHairStyleLevelBaseView>
{
	private enum EClothesStyleLevel
	{
		Level0,
		Level1,
		Level2,
		Level3
	}

	private List<UIToggleButton> m_HairStyleBtn;

	private EClothesStyleLevel m_SelectStyle;

	protected override void InitView()
	{
	}

	private void InitHairStyleBtnList()
	{
	}

	private void OnBtnHairStyleConClick()
	{
	}

	private void OnBtnSpreadCLick()
	{
	}

	public void ClickDefaultHairStyle()
	{
	}

	public void ClickDefaultEpicClothStyle()
	{
	}

	private void RefreshHairStyleItemByLv(int level)
	{
	}

	public void RefreshHairStyleShow()
	{
	}

	public bool IsSelectItemAbReady()
	{
		return false;
	}

	public bool IsHairUpStyle()
	{
		return false;
	}

	public void SetHairStyleIconVisble(bool isVisble)
	{
	}

	public void SetEpicClothStyleIconVisble(bool isVisble)
	{
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}
}
