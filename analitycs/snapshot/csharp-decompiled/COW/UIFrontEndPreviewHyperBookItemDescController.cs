using GCommon;

namespace COW;

public class UIFrontEndPreviewHyperBookItemDescController : UIFrontEndPreviewItemDescBaseController
{
	private UIFrontEndPreviewHyperBookItemDescView m_UIView;

	private const string HIDDEN_PAGE_DESC_TITLE_KEY = "T_34_XY_HYPERBOOK_HIDDENTITLE";

	private const string HIDDEN_PAGE_DESC_CONTENT_KEY = "T_34_XY_HYPERBOOK_HIDDENDEC";

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

	private bool IsSpecialBook(uint bookID)
	{
		return false;
	}

	public override void RefreshItemDesc(uint itemid, UIGrid iconGrid)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshItemDesc(uint P0, UIGrid P1)
	{
	}
}
