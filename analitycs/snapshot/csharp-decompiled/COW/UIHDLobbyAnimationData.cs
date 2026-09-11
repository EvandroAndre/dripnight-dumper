using System.Collections.Generic;
using GCommon;

namespace COW;

public static class UIHDLobbyAnimationData
{
	public class AnimationData
	{
		public int m_Frame;

		public double m_Speed;

		public double m_PositionX;
	}

	public static string m_CurrentAnimationName;

	private static Dictionary<string, Dictionary<int, int>> m_AnimationIndexData;

	private static Dictionary<string, List<AnimationData>> m_AnimationData;

	private static float m_ScreenRate;

	private static int m_LastIndex;

	private static bool m_hasInited;

	private static ResourceID[] m_ResourceData;

	private static string[] m_AnimationNames;

	public static void InitData()
	{
	}

	private static bool InitDataWithSingleFile(ResourceID resourceID, string name)
	{
		return false;
	}

	public static AnimationData GetData(float rate)
	{
		return null;
	}
}
