using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCResOneAvatar : UGCResource
{
	public class AvatarPart
	{
		public MJAIEIAKNHJ m_partData;

		public UGCGameObject m_resGameObject;
	}

	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public AvatarPart part;

		public UGCResOneAvatar _003C_003E4__this;

		internal void _003CLoadFromData_003Eb__2(bool succ, UGCGameObject resObj)
		{
		}
	}

	public static string FFEmotePrefix;

	private MNJPGANHNOK m_resAvatarData;

	private UGCResSkeleton m_resSkeleton;

	public List<AvatarPart> AvatarPartList;

	public UGCResAnimationClip DefaultIdleClip;

	public MNJPGANHNOK AvatarData => null;

	public UGCResSkeleton Skeleton => null;

	public bool IsFFPlayerAvatar => false;

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	public override void OnUnityObjectLoaded(bool isSucc, Object resObject)
	{
	}

	private void _003CLoadFromData_003Eb__10_0(bool succ, UGCResSkeleton resObj)
	{
	}

	private void _003CLoadFromData_003Eb__10_1(bool succ, UGCResAnimationClip resObj)
	{
	}

	public bool _003C_003EiFixBaseProxy_LoadFromData(byte[] P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUnityObjectLoaded(bool P0, Object P1)
	{
	}
}
