using System;
using System.Collections;
using System.Collections.Generic;
using COW;
using COW.GamePlay;
using UnityEngine;

namespace GCommon;

internal class CaptureCustomToMaterial : MonoBehaviour
{
	private sealed class _003CCapture_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CaptureCustomToMaterial _003C_003E4__this;

		public bool isHighQuality;

		public bool isFrontGame;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCapture_003Ed__30(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	public RenderTexture CaptureRenderTexture;

	public UILabel NameLabel;

	public UITable NumberGrid;

	public UISprite TenDigitSprite;

	public UISprite OneDigitSprite;

	private GameObject m_CameraObj;

	private Camera m_Camera;

	private UIStatedAvatar m_Avatar;

	private AvatarManager m_AvatarManager;

	private static Color _BackGroundColor;

	private static readonly int s_SourceAlpha2ID;

	public Vector2 PositionOffset;

	public float OrthographicSize;

	private bool m_Capture;

	private bool m_SourceAlpha2Set;

	private uint m_Cloth;

	private bool m_IsFemale;

	private bool m_IsForSharer;

	private bool m_HasPending;

	private string m_PendingName;

	private int m_PendingNumber;

	private bool m_PendingIsHighQuality;

	private uint m_PendingCloth;

	private UIStatedAvatar m_PendingAvatar;

	private AvatarManager m_PendingAvatarManager;

	private bool m_PendingIsForSharer;

	private bool m_PendingIsFrontGame;

	public void SetInfo(string name, int number, bool isHighQuality, uint cloth, UIStatedAvatar avatar = null, AvatarManager avatarManager = null, bool isForSharer = false, bool isFrontGame = false, RenderTexture captureRenderTexture = null)
	{
	}

	private void SetData(string name, int number)
	{
	}

	private void SetupCamera(bool isHighQuality, bool isFrontGame)
	{
	}

	private IEnumerator Capture(bool isHighQuality, bool isFrontGame)
	{
		return null;
	}

	private static void SetSourceAlpha2(UISprite sprite)
	{
	}
}
