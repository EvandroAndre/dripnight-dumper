using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW;

public class ChatBox3D : MonoBehaviour
{
	private class GiveMeFiveCenterPositionContext
	{
		private readonly Vector3 m_StaticPosition;

		private readonly Transform m_FollowTransform;

		private readonly Vector3 m_FollowLocalPosition;

		public bool IsFollowing => false;

		public Transform FollowTransform => null;

		public Vector3 FollowLocalPosition => default(Vector3);

		public GiveMeFiveCenterPositionContext(Vector3 staticPosition, Transform followTransform)
		{
		}

		public Vector3 GetPosition()
		{
			return default(Vector3);
		}
	}

	private sealed class _003CDestroyAfterGiveMeFiveFailAnim_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float failAnimLength;

		public ChatBox3D _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDestroyAfterGiveMeFiveFailAnim_003Ed__38(int _003C_003E1__state)
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

	private sealed class _003CMoveGiveMeFiveSticker_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public ChatBox3D _003C_003E4__this;

		public GiveMeFiveCenterPositionContext startPositionContext;

		public GiveMeFiveCenterPositionContext centerPositionContext;

		public float stopDistance;

		public bool useAcceleration;

		private float _003Celapsed_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMoveGiveMeFiveSticker_003Ed__34(int _003C_003E1__state)
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

	private sealed class _003CMoveGiveMeFiveStickerToCenter_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GiveMeFiveCenterPositionContext startPositionContext;

		public GiveMeFiveCenterPositionContext centerPositionContext;

		public ChatBox3D _003C_003E4__this;

		public GiveMeFiveAnimController animController;

		public bool playSuccessEffect;

		public bool playSuccessSound;

		private float _003CstopDistance_003E5__2;

		private bool _003CshouldKeepEndPosition_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMoveGiveMeFiveStickerToCenter_003Ed__32(int _003C_003E1__state)
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

	private sealed class _003CWaitGiveMeFiveStickerMove_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public ChatBox3D _003C_003E4__this;

		public GiveMeFiveCenterPositionContext centerPositionContext;

		public GiveMeFiveCenterPositionContext startPositionContext;

		public float stopDistance;

		public bool keepEndPosition;

		private float _003Celapsed_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitGiveMeFiveStickerMove_003Ed__37(int _003C_003E1__state)
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

	private const float kGiveMeFiveFlightEndFallbackDuration = 1.33f;

	private UILabel m_Label;

	private UISprite m_Sticker;

	private Transform m_3DObjectParent;

	private BHGGAEEHJCO m_TargetPlayerID;

	private Player m_Player;

	private uint m_DelayCallID;

	private GameObject m_GiveMeFiveStickerObject;

	private Coroutine m_GiveMeFiveMoveCoroutine;

	private Coroutine m_GiveMeFiveFailAnimCoroutine;

	private bool m_IsGiveMeFiveSpecialSticker;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateFollowTransform()
	{
	}

	private Vector3 GetMainCameraPositionByChatBoxFollowNode(Transform followNode)
	{
		return default(Vector3);
	}

	private Transform GetTeammateChatBoxFollowNode()
	{
		return null;
	}

	public void BindPlayer(BHGGAEEHJCO player_id, string msg)
	{
	}

	public void UnBindPlayer()
	{
	}

	public bool IsValid()
	{
		return false;
	}

	public bool CanHandleGiveMeFiveResult(BHGGAEEHJCO playerID)
	{
		return false;
	}

	public bool HandleStickerIngameSpecial(ChatStickerData stickerData, StickerIngameSpecial specialConfig = null)
	{
		return false;
	}

	private void ApplyStickerIngameSpecialByConfig(ChatStickerData stickerData, StickerIngameSpecial cfg)
	{
	}

	public bool HandleGiveMeFiveResultFailed()
	{
		return false;
	}

	public bool HandleGiveMeFiveResultSuccess(Vector3 startPosition, Vector3 centerPosition, BHGGAEEHJCO centerFollowPlayerID, bool playSuccessEffect, bool playSuccessSound)
	{
		return false;
	}

	private GiveMeFiveCenterPositionContext CreateGiveMeFiveCenterPositionContext(Vector3 centerPosition, BHGGAEEHJCO centerFollowPlayerID)
	{
		return null;
	}

	private GiveMeFiveCenterPositionContext CreateGiveMeFiveStartPositionContext(Vector3 startPosition)
	{
		return null;
	}

	private GiveMeFiveCenterPositionContext CreateGiveMeFivePositionContext(Vector3 position, BHGGAEEHJCO followPlayerID)
	{
		return null;
	}

	private Transform GetGiveMeFiveCenterFollowTransform(Player player)
	{
		return null;
	}

	private void BindDefaultStickerSprite(ChatStickerData stickerData)
	{
	}

	private void CreateGiveMeFiveSpecialSticker()
	{
	}

	private IEnumerator MoveGiveMeFiveStickerToCenter(GiveMeFiveCenterPositionContext startPositionContext, GiveMeFiveCenterPositionContext centerPositionContext, GiveMeFiveAnimController animController, bool playSuccessEffect, bool playSuccessSound)
	{
		return null;
	}

	private void PlayGiveMeFiveSuccessEffect(GiveMeFiveCenterPositionContext centerPositionContext, bool playSuccessSound)
	{
	}

	private IEnumerator MoveGiveMeFiveSticker(GiveMeFiveCenterPositionContext startPositionContext, GiveMeFiveCenterPositionContext centerPositionContext, float stopDistance, float duration, bool useAcceleration)
	{
		return null;
	}

	private Vector3 GetGiveMeFiveStickerMoveEndPosition(Vector3 startPosition, Vector3 centerPosition, float stopDistance)
	{
		return default(Vector3);
	}

	private void UpdateGiveMeFiveStickerLookAt(Vector3 centerPosition)
	{
	}

	private IEnumerator WaitGiveMeFiveStickerMove(float duration, GiveMeFiveCenterPositionContext centerPositionContext = null, GiveMeFiveCenterPositionContext startPositionContext = null, float stopDistance = 0f, bool keepEndPosition = false)
	{
		return null;
	}

	private IEnumerator DestroyAfterGiveMeFiveFailAnim(float failAnimLength)
	{
		return null;
	}

	private void StopGiveMeFiveMoveCoroutine()
	{
	}

	private void StopGiveMeFiveFailAnimCoroutine()
	{
	}

	private void ClearGiveMeFiveSpecialSticker()
	{
	}

	private void CancelDestroyDelayCall()
	{
	}

	private void Show()
	{
	}

	private void Hide()
	{
	}

	private void OnTrainingZoneChanged(object[] param)
	{
	}

	private void _003CBindPlayer_003Eb__18_0()
	{
	}
}
