using System;
using System.Collections.Generic;
using UnityEngine;
using proto;

namespace COW;

public class SparkPetManager
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public uint stageID;

		public ESparkAvatarType eSparkAvatarType;

		public Action<uint, UISparkPetAvatar, uint> sparkPetAvatarCreatedCallback;

		public SparkPetConfig sparkPetConfig;

		public ESparkAvatarOrigin eSparkAvatarOrigin;

		public uint[] appearanceItemIds;

		public EFriend.SparkState sparkState;

		public bool showBeSummonedAnim;

		public bool skipSelfDyeAutoApply;

		public uint colorID;

		internal void _003CCreateSparkPetAvatar_003Eb__0(uint tkt, bool succeeded, UnityEngine.Object obj)
		{
		}
	}

	public const uint SparkPetOptionalReDefId = 603u;

	public static HashSet<uint> AsyncLoadSparkPetTickets;

	public static UISparkPetAvatar CreateUISparkPetAvatar()
	{
		return null;
	}

	public static uint CreateSparkPetAvatar(uint sparkPetID = 0u, uint stageID = 0u, Action<uint, UISparkPetAvatar, uint> sparkPetAvatarCreatedCallback = null, ESparkAvatarType eSparkAvatarType = ESparkAvatarType.None, ESparkAvatarOrigin eSparkAvatarOrigin = ESparkAvatarOrigin.None, uint[] appearanceItemIds = null, EFriend.SparkState sparkState = EFriend.SparkState.SparkState_ACTIVE, bool showBeSummonedAnim = false, bool skipSelfDyeAutoApply = false, uint colorID = 1u)
	{
		return 0u;
	}

	private static void OnAsyncLoadSparkPetGameObjectFailed(Action<uint, UISparkPetAvatar, uint> sparkPetAvatarCreatedCallback, ESparkAvatarType eSparkAvatarType = ESparkAvatarType.Self)
	{
	}

	private static void OnSparkPetGameObjectCreated(uint ticket, GameObject petGo, SparkPetConfig sparkPetConfig, Action<uint, UISparkPetAvatar, uint> sparkPetAvatarCreatedCallback, ESparkAvatarType eSparkAvatarType, ESparkAvatarOrigin eSparkAvatarOrigin, uint[] appearanceItemIds = null, EFriend.SparkState sparkState = EFriend.SparkState.SparkState_ACTIVE, bool showBeSummonedAnim = false, bool skipSelfDyeAutoApply = false, uint colorID = 1u)
	{
	}

	public static void SetSelfSparkPetDyeColor(uint colorID)
	{
	}

	public static bool IsSparkPetResABReady()
	{
		return false;
	}

	public static bool IsSparkPetMinResABReady(uint sparkPetID = 0u, uint stageID = 0u)
	{
		return false;
	}

	public static void CancelAllAsyncLoads()
	{
	}

	public static void CancelAsyncLoad(uint ticket)
	{
	}
}
