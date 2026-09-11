using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class PreviewPetManager
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public Vector3? scale;

		public Vector3? pos;

		public Quaternion rotation;

		public bool closeLight;

		public int avatarlighttype;

		public Action<uint, UIPetAvatar> callback;

		internal void _003CCreatePetAvatar_003Eb__0(uint ticket, UIPetAvatar petavatar)
		{
		}
	}

	public static HashSet<uint> AsyncLoadPetTickets;

	private static bool IsInSingleAssetBundle;

	public static bool CheckPetResABReady(CSSharedItemData itemData)
	{
		return false;
	}

	public static bool CheckPetActionResABReadyByPetID(uint petID)
	{
		return false;
	}

	public static bool IsPetResABReady(uint itemID)
	{
		return false;
	}

	public static uint CreatePetAvatar(uint petId, uint skinId, Vector3? scale = null, Vector3? pos = null, int avatarlighttype = 1, Quaternion rotation = default(Quaternion), FrontEndPreviewComponent frontEndPreviewComponent = null, bool playPetLoopIdleSound = false, bool closeLight = false, bool needPlaneShadow = false, Action<uint, UIPetAvatar> callback = null)
	{
		return 0u;
	}
}
