using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace GCommon;

public class ResourceFallback
{
	private ResourceID m_Result;

	private List<uint> m_ResIdList;

	private int m_CurCheckIdx;

	private uint m_AsyncTicket;

	private Action<uint, bool, UnityEngine.Object> m_AsyncCallback;

	private static StringBuilder m_StringBuilder;

	private ResourceFallback()
	{
	}

	public static ResourceFallback Create(ResourceID resId1, ResourceID resId2, ResourceID[] resIds)
	{
		return null;
	}

	public static ResourceFallback CreateWithDefault(ResourceID resId1, ResourceID resId2)
	{
		return null;
	}

	public ResourceID GetResult()
	{
		return default(ResourceID);
	}

	private void CheckCurResAsync()
	{
	}

	private void CheckCurResAsyncCallback(uint ticket, bool succ, UnityEngine.Object inst)
	{
	}

	private void CheckCurResSync()
	{
	}

	public static ResourceID GetLocalizedResourceID(string resourceStr, bool needGender)
	{
		return default(ResourceID);
	}

	private static string GetGenderStr()
	{
		return null;
	}

	private static ResourceID GetRsourceByLangGender(string resourceStr, string lang, string gender)
	{
		return default(ResourceID);
	}
}
