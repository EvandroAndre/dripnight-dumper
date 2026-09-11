using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class ShaderStripSettings : ScriptableObject
{
	[Serializable]
	public class KeywordStripInfo
	{
		public int DataID;

		public List<string> ValidKeywords;

		public List<string> StripKeywords;
	}

	public enum EShaderLoadPathType
	{
		kLoadPathAuto,
		kLoadPathFromApk,
		kLoadPathFromTargetAB
	}

	[Serializable]
	public class ShaderLoadPathInfo
	{
		public string ShaderName;

		public EShaderLoadPathType LoadType;

		public string ABName;
	}

	private const string EngineFileName = "ShaderStripSettings";

	private const int MAX_DATA_ID = 254;

	private const int MAX_AB_PATH_KEYWORD_LENGTH = 256;

	public KeywordStripInfo[] KeywordStripInfos;

	public ShaderLoadPathInfo[] ShaderLoadPathInfos;

	private static ShaderStripSettings m_Instance;

	private int m_CurActiveDataID;

	public static ShaderStripSettings instance => null;

	public static bool EnableShaderKeywordStripByConfig => false;

	public static bool HaveEnoughStorage(long bytes)
	{
		return false;
	}

	public void SaveToEngineFile()
	{
	}

	private static void WriteKeywordsToDatas(List<string> keywords, ref List<byte> datas)
	{
	}

	public void AppyStripSettings()
	{
	}

	public void ApplyStripByDataID(int data_id)
	{
	}
}
