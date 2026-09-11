using System.Collections.Generic;
using System.IO;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugInfoUploadController : UIToggleConfirmController
{
	private List<FileInfo> m_LogInfos;

	private List<string> m_FileNames;

	private FileInfo m_CurrentZipFile;

	private string m_LatestError;

	private Coroutine m_Coroutine;

	private DebugInfoUploadTab m_CurrentTab;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override ResourceID GetFrameResourceId()
	{
		return default(ResourceID);
	}

	public override string CustomTitle()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshData()
	{
	}

	protected override void OnConfirmBtn()
	{
	}

	private void OnVoiceTabClick()
	{
	}

	private void OnPCMDeleteClick()
	{
	}

	private void OnDebugTabClick()
	{
	}

	private void OnDeleteBtn()
	{
	}

	private void DeleteLogsAndZip()
	{
	}

	private void VoiceLogUploadCB(int errCode, int progress)
	{
	}

	private FileInfo GetCurrentFileInfo()
	{
		return null;
	}

	public int SortLogs(FileInfo x, FileInfo y)
	{
		return 0;
	}

	protected override void OnDestroy()
	{
	}

	private void _003COnPCMDeleteClick_003Eb__13_0()
	{
	}

	private void _003COnDeleteBtn_003Eb__15_0()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetFrameResourceId()
	{
		return default(ResourceID);
	}

	public string _003C_003EiFixBaseProxy_CustomTitle()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnConfirmBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
