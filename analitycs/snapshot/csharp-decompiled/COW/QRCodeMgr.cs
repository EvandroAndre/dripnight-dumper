using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using ZXing;

namespace COW;

public abstract class QRCodeMgr
{
	public class EncodeOptions
	{
		public TextureFormat Format;

		public Color ForegroundColor;

		public Color BackgroundColor;

		public static readonly EncodeOptions DEFAULT;
	}

	public abstract class PermissionHandler
	{
		public DecodeOptions DecodeOptions;

		public abstract bool? Check(bool request);

		protected void OnRequested(bool result)
		{
		}
	}

	public interface IDecodeHandler
	{
		void OnDecoding(Texture texture);

		bool OnDecoded(string text);

		void OnTextureUVRectUpdated(Rect rect);
	}

	public class DecodeOptions
	{
		public string Camera;

		public Vector2Int CameraRequestSize;

		public float CameraRequestFrameRate;
	}

	private class QRCodeMgr_Default : QRCodeMgr
	{
	}

	private class QRCodeMgr_ZXing : QRCodeMgr
	{
		private class WebCamTextureObserver : MonoBehaviour
		{
			public WebCamTexture Target;

			public Action<WebCamTexture> TargetFrameUpdateTrigger;

			public Action<Rect> TargetRectUpdateTrigger;

			public bool IsFrontFacing;

			private static readonly Rect UV_RECT_DEFAULT;

			private Rect _003CUVRect_003Ek__BackingField;

			public Rect UVRect
			{
				get
				{
					return _003CUVRect_003Ek__BackingField;
				}
				private set
				{
					_003CUVRect_003Ek__BackingField = value;
				}
			}

			public void Start()
			{
			}

			public void Update()
			{
			}

			private void _UpdateUVRect()
			{
			}
		}

		private DecodeOptions _DecodeOptions;

		private WebCamTexture _WebCamTexture;

		private WebCamTextureObserver _WebCamTextureObserver;

		private Thread _DecodeThreadObj;

		private Color32[] _DecodeBitmap;

		private string _DecodedText;

		private bool _DecodeHandlerResult;

		private AutoResetEvent _DecodeTrigger;

		private AutoResetEvent _HandlerTrigger;

		private BarcodeReader _BarcodeReader;

		private readonly BarcodeFormat[] _DecodeFormats;

		public override bool CanEncode => false;

		public override bool CanDecode => false;

		public override Texture CameraTexture => null;

		public override bool CanSetAutoFocusPoint => false;

		public override Vector2? AutoFocusPoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Rect CameraTextureUVRect => default(Rect);

		public override bool IsDecoding => false;

		public override Texture2D Encode(string text, EncodeOptions options = null)
		{
			return null;
		}

		private void _DestroyWebCamTexture()
		{
		}

		private void _CreateWebCamTexture()
		{
		}

		public override void StartDecoding(DecodeOptions decodeOptions = null)
		{
		}

		protected override void _StartDecoding(DecodeOptions decodeOptions)
		{
		}

		public override void StopDecoding()
		{
		}

		public override void PauseDecoding()
		{
		}

		public override void ResumeDecoding()
		{
		}

		public override string DecodeTexture(Texture2D texture)
		{
			return null;
		}

		public override Texture SwitchCamera(string cameraName)
		{
			return null;
		}

		private void _DecodeThread()
		{
		}

		private void _003C_CreateWebCamTexture_003Eb__23_0(WebCamTexture texture)
		{
		}

		private void _003C_DecodeThread_003Eb__38_0()
		{
		}

		public bool _003C_003EiFixBaseProxy_get_CanEncode()
		{
			return false;
		}

		public bool _003C_003EiFixBaseProxy_get_CanDecode()
		{
			return false;
		}

		public Texture2D _003C_003EiFixBaseProxy_Encode(string P0, EncodeOptions P1)
		{
			return null;
		}

		public Texture _003C_003EiFixBaseProxy_get_CameraTexture()
		{
			return null;
		}

		public bool _003C_003EiFixBaseProxy_get_CanSetAutoFocusPoint()
		{
			return false;
		}

		public Vector2? _003C_003EiFixBaseProxy_get_AutoFocusPoint()
		{
			return null;
		}

		public void _003C_003EiFixBaseProxy_set_AutoFocusPoint(Vector2? P0)
		{
		}

		public Rect _003C_003EiFixBaseProxy_get_CameraTextureUVRect()
		{
			return default(Rect);
		}

		public bool _003C_003EiFixBaseProxy_get_IsDecoding()
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_StartDecoding(DecodeOptions P0)
		{
		}

		public void _003C_003EiFixBaseProxy__StartDecoding(DecodeOptions P0)
		{
		}

		public void _003C_003EiFixBaseProxy_StopDecoding()
		{
		}

		public void _003C_003EiFixBaseProxy_PauseDecoding()
		{
		}

		public void _003C_003EiFixBaseProxy_ResumeDecoding()
		{
		}

		public string _003C_003EiFixBaseProxy_DecodeTexture(Texture2D P0)
		{
			return null;
		}

		public Texture _003C_003EiFixBaseProxy_SwitchCamera(string P0)
		{
			return null;
		}
	}

	public static Action<string> OnLog;

	private static QRCodeMgr _I;

	private PermissionHandler _003CCameraPermissionHandler_003Ek__BackingField;

	private List<IDecodeHandler> _DecodeHandlers;

	private Vector2? _003CAutoFocusPoint_003Ek__BackingField;

	public static QRCodeMgr I => null;

	public virtual bool CanEncode => false;

	public virtual bool CanDecode => false;

	public PermissionHandler CameraPermissionHandler
	{
		get
		{
			return _003CCameraPermissionHandler_003Ek__BackingField;
		}
		set
		{
			_003CCameraPermissionHandler_003Ek__BackingField = value;
		}
	}

	public virtual Texture CameraTexture => null;

	public virtual bool CanSetAutoFocusPoint => false;

	public virtual Vector2? AutoFocusPoint
	{
		get
		{
			return _003CAutoFocusPoint_003Ek__BackingField;
		}
		set
		{
			_003CAutoFocusPoint_003Ek__BackingField = value;
		}
	}

	public virtual Rect CameraTextureUVRect => default(Rect);

	public virtual bool IsDecoding => false;

	protected static void Log(string format, object[] args)
	{
	}

	private QRCodeMgr()
	{
	}

	public virtual Texture2D Encode(string text, EncodeOptions options = null)
	{
		return null;
	}

	public void Register(IDecodeHandler handler)
	{
	}

	public void Unregister(IDecodeHandler handler)
	{
	}

	protected void OnDecoding(Texture texture)
	{
	}

	protected void OnTextureUVRRectChanged(Rect rect)
	{
	}

	protected bool OnDecoded(string text)
	{
		return false;
	}

	public virtual void StartDecoding(DecodeOptions decodeOptions = null)
	{
	}

	protected virtual void _StartDecoding(DecodeOptions decodeOptions)
	{
	}

	public virtual void StopDecoding()
	{
	}

	public virtual void PauseDecoding()
	{
	}

	public virtual void ResumeDecoding()
	{
	}

	public virtual string DecodeTexture(Texture2D texture)
	{
		return null;
	}

	public virtual Texture SwitchCamera(string cameraName)
	{
		return null;
	}
}
