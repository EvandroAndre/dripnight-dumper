using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class SceneEditFeedBackDataManager : SingletonModule<SceneEditFeedBackDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UGCFeedBackConfigData> _003C_003E9__2_0;

		public static Comparison<UGCFeedBackConfigData> _003C_003E9__2_1;

		internal int _003COnInit_003Eb__2_0(UGCFeedBackConfigData a, UGCFeedBackConfigData b)
		{
			return 0;
		}

		internal int _003COnInit_003Eb__2_1(UGCFeedBackConfigData a, UGCFeedBackConfigData b)
		{
			return 0;
		}
	}

	private List<UGCFeedBackConfigData> m_FirstQuestionList;

	private List<UGCFeedBackConfigData> m_SecondQuestionList;

	protected override void OnInit()
	{
	}

	public List<UGCFeedBackConfigData> GetFirstQuestionList()
	{
		return null;
	}

	public List<UGCFeedBackConfigData> GetSecondQuestionList()
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}
}
