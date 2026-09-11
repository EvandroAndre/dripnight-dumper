using System;
using GCommon;

namespace COW;

public class UIModelIceWallDisplay : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__14_0;

		internal void _003CRequestSetIceSkinID_003Eb__14_0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const string HDICEDISPLAYGUIDE = "HDICEWALLDISPLAYGUIDE_";

	public const string UILobbyIceDisplayGuideKey = "UILOBBYICEWALLDISPLAYGUIDEKEY_";

	public const string UILobbyIceAutoRotateGuideKey = "UILOBBYICEWALLAutoRotateGUIDEKEY_";

	private uint _003CSelectedIceWallSkinID_003Ek__BackingField;

	private bool _003CGetDataAfterLogin_003Ek__BackingField;

	public uint SelectedIceWallSkinID
	{
		get
		{
			return _003CSelectedIceWallSkinID_003Ek__BackingField;
		}
		private set
		{
			_003CSelectedIceWallSkinID_003Ek__BackingField = value;
		}
	}

	public bool GetDataAfterLogin
	{
		get
		{
			return _003CGetDataAfterLogin_003Ek__BackingField;
		}
		private set
		{
			_003CGetDataAfterLogin_003Ek__BackingField = value;
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public void ProcessData(uint skinID)
	{
	}

	public void RequestSetIceSkinID(uint skinID, bool autorotate = false)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
