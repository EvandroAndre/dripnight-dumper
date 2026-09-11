using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class AroundGameQuickChatDataManager : SingletonModule<AroundGameQuickChatDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<AroundGameQuickChatData> _003C_003E9__6_0;

		internal int _003CProcessData_003Eb__6_0(AroundGameQuickChatData x, AroundGameQuickChatData y)
		{
			return 0;
		}
	}

	private Dictionary<uint, AroundGameQuickChatData> m_Data;

	private Dictionary<uint, List<AroundGameQuickChatData>> m_ClassifiedData;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public AroundGameQuickChatData GetQucickChatDataById(uint id)
	{
		return null;
	}

	public List<AroundGameQuickChatData> GetDataByCategory(EFastChatCategory category)
	{
		return null;
	}

	private void ProcessData()
	{
	}
}
