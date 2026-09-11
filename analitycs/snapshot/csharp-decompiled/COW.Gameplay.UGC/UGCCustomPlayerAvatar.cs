using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW.Gameplay.UGC;

internal class UGCCustomPlayerAvatar : MonoBehaviour
{
	public class CorrectBoneScale : MonoBehaviour
	{
		public Transform bone;

		private void LateUpdate()
		{
		}
	}

	private sealed class _003CCor_ChangePlayerImpl_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UGCCustomPlayerAvatar _003C_003E4__this;

		public string ugcPlayerResUUID;

		private AvatarManager _003CavatarManager_003E5__2;

		private int _003CmaxWaitCount_003E5__3;

		private int _003CwaitCount_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCor_ChangePlayerImpl_003Ed__14(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private Dictionary<string, Transform> m_codeNeedBones;

	private string ms_root_name;

	private Player m_player;

	private AvatarManager m_avatarManager;

	private Dictionary<string, Dictionary<string, UGCResAnimationClip>> m_replaceAnimations;

	private bool m_isUsingAvatar;

	private UGCSkeletonAvatarSystem m_avatarSystem;

	public UGCSkeletonAvatarSystem Avatar => null;

	private void BuildAllCodeNeedBone(Transform parentObj)
	{
	}

	private void SetStandardBoneToIdentity(Transform rootBone)
	{
	}

	private void SetTransformToIdentity(Transform t, Transform rootBone)
	{
	}

	private void AddCodeNeedBoneObj(string name, Transform parentObj)
	{
	}

	public static UGCCustomPlayerAvatar SChangeToUGCPlayer(Player player, string ugcPlayerResUUID)
	{
		return null;
	}

	private void recreatePlayerAvatar()
	{
	}

	private void tryCorrectBone(string bonename)
	{
	}

	public bool ChangeToFFPlayer()
	{
		return false;
	}

	private void ChangeToUGCPlayer(Player player, string ugcPlayerResUUID)
	{
	}

	private IEnumerator Cor_ChangePlayerImpl(string ugcPlayerResUUID)
	{
		return null;
	}

	private void onSkeletonAndMeshLoaded()
	{
	}

	private void LoadPlayer(UGCResCustomPlayer resPlayer)
	{
	}

	public void RegisterReplaceAnimation()
	{
	}

	private void SetAllClipOverride(UGCResAnimationClip resClip)
	{
	}

	private void LoadAvatar(UGCResOneAvatar resAvatar)
	{
	}

	private void OnAvatarLoaded()
	{
	}

	private void _003CCor_ChangePlayerImpl_003Eb__14_0(bool succ, UGCResCustomPlayer resObj)
	{
	}
}
