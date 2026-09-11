using System;
using GCommon;

namespace COW;

public class UIDetailTipsBtnItemController : UIBaseController
{
	private UIDetailTipsBtnItemView m_View;

	private uint m_Gopos;

	private string m_SubGopos;

	private uint m_DetailId;

	private Action m_GoClickCallback;

	private LabelPosStyle m_LabelPosStyle;

	private UIModelBigEvent.TokenGoposTipWayType m_wayType;

	private int m_from;

	private UIModelUser m_ModelUser;

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

	public void SetBigEventData(UIModelBigEvent.TokenTipsData tokenTipsData, Action goClickCallback)
	{
	}

	public void SetBigEventLabelByTokenType(uint tokenId, uint gameMode, string wayStr)
	{
	}

	public void SetBigEventTemplate(BigEventTemplateTokenTips tokenTipsData, uint detailId, Action goClickCallback)
	{
	}

	public void SetBigEventTemplateLabelByTokenType(uint useType, uint gameMode, string wayStr)
	{
	}

	public void SetData(string des, Action goClickCallback, LabelPosStyle style = LabelPosStyle.Default)
	{
	}

	private void OnGoClick()
	{
	}

	private void OnCustomClick()
	{
	}

	private void CheckShowState(string desc)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
