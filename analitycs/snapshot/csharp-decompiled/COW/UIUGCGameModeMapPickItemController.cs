using COW.Gameplay.UGC;
using GCommon;

namespace COW;

public class UIUGCGameModeMapPickItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public string tagdes;

		internal void _003CSetTypeData_003Eb__0()
		{
		}
	}

	private UIUGCGameModeMapPickItemView m_View;

	public bool m_Selected;

	public uint Type;

	private bool m_NeedCheckDownload;

	private UIUGCHotIndicatorController m_HeatInfo;

	private UINewDownloadInfoController m_OptionalMapResDownloader;

	private UGCSimpleDownloadTask m_ResDownloadTask;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(int isSelect, bool showNewTagVFX)
	{
	}

	public void SetTypeData(uint typeID, string cdnURL, string label, uint[] maps, string desc, bool needDowunload)
	{
	}

	public void TrySelect()
	{
	}

	public void TryUnselect()
	{
	}

	private void RefreshView()
	{
	}

	public bool RefreshOptionalMapResDownloader(bool showDownloadPop = false)
	{
		return false;
	}

	private void OnClickBtnPick()
	{
	}

	public void SetHeat(uint heat)
	{
	}

	private void TryDownloadMapRes()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
