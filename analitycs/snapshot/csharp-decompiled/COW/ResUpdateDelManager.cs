using System.Collections.Generic;
using GCommon;
using TsiU;

namespace COW;

public class ResUpdateDelManager : TSingleton<ResUpdateDelManager>
{
	private Queue<ResVersionInfo.FileInfo> m_DelFileQueue;

	private List<ResVersionInfo.FileInfo> m_TempFileTrans;

	private bool m_CanDel;

	public void InitNeedDelFileGradual(List<ResVersionInfo.FileInfo> needGradualDelFiles)
	{
	}

	public void PauseDel(bool del)
	{
	}

	public void UpdateDel()
	{
	}
}
