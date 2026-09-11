using GCommon;
using proto;

namespace COW;

public class UIVirtualBrandItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public UIModelOptionalDownload modelDownload;

		public ResDownloadType resType;

		public uint tag;

		public UIVirtualBrandItemController _003C_003E4__this;

		internal void _003CShowDownloadWnd_003Eb__0()
		{
		}
	}

	private UIVirtualBrandItemView m_View;

	private uint m_uBrandID;

	private UIModelVirtualBrand m_model;

	private VirtualBrandLogoDesc m_logoDesc;

	private bool m_bIsWarmUp;

	private const string WARM_UP_LABEL_KEY = "T_36_DY_VB_WARMUP";

	private const string WARM_UP_TIPS_KEY = "T_37_DY_COMINGSOON";

	private const string WARM_UP_LABEL_COLOR = "#515d70";

	private const string WARM_UP_IMAGE_DEFAULT = "FF_UI_VirtualBrand_Logo_Unknown";

	private bool m_bisEasyList;

	private string m_brandName;

	private UINewDownloadInfoController m_downloadController;

	protected override void OnUIInit()
	{
	}

	private void SetDownLoadController()
	{
	}

	private void OnClickDesgar()
	{
	}

	private void ShowDownloadWnd(uint brandID)
	{
	}

	private void DownloadAllBrandAb(bool flag)
	{
	}

	private void OnCliCkBtn()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetGridOrEasyList(bool isEasyList = true)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	private void GotoShowCase()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
