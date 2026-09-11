using System.Collections.Generic;
using System.Threading;

namespace GCommon;

public class CSVThreadLoad : SingletonModule<CSVThreadLoad>
{
	private Thread m_CSVThread;

	private AutoResetEvent m_AutoEvent;

	private AutoResetEvent m_AnoymousMappingTmpLock;

	private bool m_NeedReleaseAnoymousMappingTmp;

	private List<CSVThreadWork> m_RecvCSVWork;

	private List<CSVThreadWork> m_TempRecvCSVWork;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public void StarCSVThread()
	{
	}

	public void ClearCSVThreadAndSignal()
	{
	}

	public void ProduceCSVWork(CSVThreadWork work)
	{
	}

	public void UnregisterAnoymousMappingTmp()
	{
	}

	public void RleaseAnoymousMappingTmpLock()
	{
	}

	public void RegisterAnoymousMappingTmp()
	{
	}

	private void UnregisterAnoymousMappingTmpAndBlockThread()
	{
	}

	private void ProceedCSV()
	{
	}

	private void OnCSVThread()
	{
	}
}
