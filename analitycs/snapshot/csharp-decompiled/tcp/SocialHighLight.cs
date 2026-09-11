using System;
using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class SocialHighLight : IMessage
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<SocialHighLight> _003C_003E9__7_0;

		public static Comparison<SocialHighLight> _003C_003E9__8_0;

		internal int _003CGetTeamUpRecommendSocialHighlightBR_003Eb__7_0(SocialHighLight a, SocialHighLight b)
		{
			return 0;
		}

		internal int _003CGetTeamUpRecommendSocialHighlightCS_003Eb__8_0(SocialHighLight a, SocialHighLight b)
		{
			return 0;
		}
	}

	public ESocial.HighLight high_light;

	public long expire_at;

	public uint value;

	public void ParseFrom(ProtoReader reader)
	{
	}

	public static SocialHighLight GetMaxPriorityHighlight(List<SocialHighLight> socialhighlights, EMatch.MatchMode matchMode = EMatch.MatchMode.MatchMode_NONE)
	{
		return null;
	}

	public static List<SocialHighLight> GetTeamUpRecommendSocialHighlightBR(List<SocialHighLight> socialhighlights)
	{
		return null;
	}

	public static List<SocialHighLight> GetTeamUpRecommendSocialHighlightCS(List<SocialHighLight> socialhighlights)
	{
		return null;
	}

	private static uint GetTeamUpRecommendPriortyBR(SocialHighLight socialHighLight)
	{
		return 0u;
	}

	private static uint GetTeamUpRecommendPriortyCS(SocialHighLight socialHighLight)
	{
		return 0u;
	}
}
