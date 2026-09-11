using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UMA;

[Serializable]
public class TextureProcessPROCoroutine : TextureProcessBaseCoroutine
{
	private sealed class _003CworkerMethod_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TextureProcessPROCoroutine _003C_003E4__this;

		private bool _003CsharedTexExist_003E5__2;

		private TextureMerge _003CtextureMerge_003E5__3;

		private int _003CatlasIndex_003E5__4;

		private UMAData.GeneratedMaterial _003Catlas_003E5__5;

		private UMAData.MaterialFragment _003CfirstFragment_003E5__6;

		private SlotData _003CslotData_003E5__7;

		private bool _003CusingRGB565_003E5__8;

		private int _003CtextureType_003E5__9;

		private Texture2D _003CtempTexture_003E5__10;

		private int _003Cxblocks_003E5__11;

		private int _003Cyblocks_003E5__12;

		private int _003Cx_003E5__13;

		private int _003Cy_003E5__14;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CworkerMethod_003Ed__14(int _003C_003E1__state)
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

	private UMAData umaData;

	private RenderTexture destinationTexture;

	private Texture[] resultingTextures;

	private UMAGeneratorBase umaGenerator;

	private Camera renderCamera;

	private RenderTextureDescriptor mTextureDescriptor;

	private int _alphaMaskID;

	private int _colorEffectParamID;

	private int alphaMaskID => 0;

	private int colorEffectParamID => 0;

	public override void Prepare(UMAData _umaData, UMAGeneratorBase _umaGenerator)
	{
	}

	protected override void Start()
	{
	}

	protected override IEnumerator workerMethod()
	{
		return null;
	}

	private bool IsOpenGL()
	{
		return false;
	}

	protected override void Stop()
	{
	}
}
