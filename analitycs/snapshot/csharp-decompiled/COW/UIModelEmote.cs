using System;
using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

public class UIModelEmote : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public TransformData transformData;

		public int transformerLevel;

		internal void _003CLocalPlayerRequestPlayTransform_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public ulong accountID;

		internal bool _003CPlayTransformSuccess_003Eb__0(GroupMemberInfo o)
		{
			return false;
		}
	}

	public static bool LocalInviterIsAwaitingAccept;

	public static ulong LocalPlayerAcceptInviterId;

	public override uint GetModelType()
	{
		return 0u;
	}

	public static void RequestInviteDuoEmote(uint emoteId)
	{
	}

	public static void InternalInviteDuoEmote(uint emoteId, ulong inviterAccount)
	{
	}

	public static void RequestAcceptDuoEmote(uint emoteId, ulong inviterAccount)
	{
	}

	private static void PlayDuoEmote(uint emoteId, ulong inviterAccount, ulong inviteeAccount)
	{
	}

	public static void ReceiveDuoEmoteInviteBehavior(uint emoteId, ulong inviterAccount, ulong[] inviteeAccount)
	{
	}

	public static void ReceiveDuoEmoteAcceptBehavior(uint emoteId, ulong inviterAccount, ulong inviteeAccount)
	{
	}

	public static void ReceiveDuoEmoteConfirmBehavior(uint emoteId, ulong inviterAccount, ulong inviteeAccount)
	{
	}

	public static bool LocalPlayerRequestPlayEmote(uint emoteId)
	{
		return false;
	}

	private static GEventShowEmote InternalPlayEmote(ulong accountId, uint emoteId, EDuoEmoteStage eDuoEmoteStage, EmoteExtralInfo extralInfo = null)
	{
		return null;
	}

	private static void SendCooperateEmoteLog(GEventShowEmote showEmoteData)
	{
	}

	public static bool LocalPlayerRequestPlayFollowDanceEmote(int emoteID)
	{
		return false;
	}

	public static bool LocalPlayerRequestPlayTransform(TransformData transformData, int transformerLevel)
	{
		return false;
	}

	public static void PlayTransformSuccess(uint emoteID, uint level, uint extraInfo = 0u)
	{
	}

	public static void QuitPlayTransform(uint emoteID, uint level)
	{
	}

	private static List<TeammateEmoteInfo> BuildTeammateEmoteInfo(EmoteData emoteData, ulong accountId, UIModelGroup modelGroup, bool isFemale)
	{
		return null;
	}

	private static bool InternalPlayTransform(TransformData transformData, int transformerLevel, Action successAction = null)
	{
		return false;
	}

	public EAvatarModelIngameType GetTargetTransformType(EAvatarModelIngameType currentTransformType, TransformData transformData, EAvatarModelIngameType uitype)
	{
		return EAvatarModelIngameType.Normal;
	}
}
