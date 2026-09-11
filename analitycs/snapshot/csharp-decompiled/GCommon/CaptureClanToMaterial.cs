using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class CaptureClanToMaterial : MonoBehaviour
{
	private sealed class _003CCapture_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CaptureClanToMaterial _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCapture_003Ed__20(int _003C_003E1__state)
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

	public Renderer TargetRenderer;

	public int TargetMaterialIndex;

	public string ShaderPropertyName;

	public int CaptureTextureSize;

	public float OrthographicSize;

	public Vector2 PositionOffset;

	public UISprite m_ClanIcon;

	public UILabel m_ClanNameLabel;

	public UISprite m_ClanFrameIcon;

	private int m_ShaderPropertyID;

	private RenderTexture m_RenderTexture;

	private Material m_TargetMaterial;

	private GameObject m_CameraObj;

	private Camera m_Camera;

	private bool m_ClanIconSetFinish;

	private bool m_ClanFrameSetFinish;

	private static Color _BackGroundColor;

	private static bool _Capture;

	private void Start()
	{
	}

	private void SetupCamera()
	{
	}

	private IEnumerator Capture()
	{
		return null;
	}

	private void SetTexture(Material[] sharedMaterials)
	{
	}

	private void DisableSubmeshRendering()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetInfo(string clanName, uint clanBadgeId, uint clanFrameId, bool isInGame)
	{
	}

	private void SetChildEnable(bool enable)
	{
	}

	private void StartCapture()
	{
	}

	private void _003CSetInfo_003Eb__24_0()
	{
	}

	private void _003CSetInfo_003Eb__24_1()
	{
	}
}
