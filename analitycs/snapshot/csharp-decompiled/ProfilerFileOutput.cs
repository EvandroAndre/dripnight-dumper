using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ProfilerFileOutput : MonoBehaviour
{
	public static ProfilerFileOutput instance;

	private List<string> m_OutputText;

	private string m_OutputFilePath;

	private StreamWriter m_Writer;

	private void Start()
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

	public void Flush()
	{
	}

	public void FlushToFile()
	{
	}

	public void Close()
	{
	}
}
