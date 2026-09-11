using GCommon;
using proto;

namespace COW;

public class UIFrontEndPreviewHackerStoreItemDescController : UIFrontEndPreviewItemDescBaseController
{
	private const int PROPERTYPANELHALFBGWIDTH = 53;

	private UIFrontEndPreviewHackerStoreItemDescView m_UIView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewItemDescBaseView InitBaseView()
	{
		return null;
	}

	public override void SetNewQuaityIcon(uint id)
	{
	}

	public override void SetNewQuaitySpIcon(EInventory.AwardType type)
	{
	}

	protected override void SetItemDescBg()
	{
	}

	protected override void OnItemDescBgChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_SetNewQuaityIcon(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetNewQuaitySpIcon(EInventory.AwardType P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetItemDescBg()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemDescBgChanged()
	{
	}
}
