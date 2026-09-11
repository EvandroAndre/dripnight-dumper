using System.Collections.Generic;
using System.IO;
using LitJson;
using UnityEngine;

public class DebuggerFileOutput : MonoBehaviour
{
	public static DebuggerFileOutput instance;

	private List<string> m_OutputText;

	private List<string> m_OutputTextBackendLog;

	public const string RTC_LOG_NAME = "ffrtc_log.txt";

	public const string MAGICVOICE_LOG_NAME1 = "ff_magicvoice_log.txt";

	public const string MAGICVOICE_LOG_NAME2 = "ff_magicvoice_engine_log.txt";

	public const string RESHOTUPDATE_LOG_NAME = "HotUpdateFile";

	public const int FixedSizeMsgQueueLength = 4;

	public const string BackendJsonLogDirName = "BackendJsonLog";

	private string[] m_FixedSizeMsgQueue;

	private int m_DroppedFixedSizeMsgs;

	private int m_FixedSizeMsgQueueSize;

	private string m_OutputFilePath;

	private StreamWriter m_Writer;

	private string m_OutputFilePathBackendJson;

	private StreamWriter m_WriterBackendJson;

	private JsonWriter m_BackendJsonWriter;

	public string OutputFilePath => null;

	public StreamWriter WriterBackendJson => null;

	private JsonWriter BackendLogJsonWriter => null;

	public void AddToFixedSizeQueueNoLock(string msg)
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void Log(string msg)
	{
	}

	public void LogBackendJson(object msg, string prefix = "")
	{
	}

	public string ObjectToJson(object obj)
	{
		return null;
	}

	public void Flush()
	{
	}

	public void FlushToFile()
	{
	}

	public void Close()
	{
	}

	public static string GetLogDir()
	{
		return null;
	}

	public static List<FileInfo> GetAllLogInfo()
	{
		return null;
	}

	public void RestartWriterAsAppend()
	{
	}
}
