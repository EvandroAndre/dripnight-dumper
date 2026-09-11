using System;
using GCommon;

namespace COW;

public class UIModelSkyboardDisplay : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__14_0;

		internal void _003CRequestSetSkyboardSkinID_003Eb__14_0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const string HDSKYBOARDDISPLAYGUIDE = "HDSKYBOARDDISPLAYGUIDE_";

	public const string UILobbySkyboardDisplayGuideKey = "UILOBBYSKYBOARDDISPLAYGUIDEKEY_";

	public const string UILobbySkyboardAutoRotateGuideKey = "UILOBBYSKYBOARDAUTOROTATEGUIDEKEY_";

	private uint _003CSelectedSkyboardSkinID_003Ek__BackingField;

	private bool _003CGetDataAfterLogin_003Ek__BackingField;

	public uint SelectedSkyboardSkinID
	{
		get
		{
			return _003CSelectedSkyboardSkinID_003Ek__BackingField;
		}
		private set
		{
			_003CSelectedSkyboardSkinID_003Ek__BackingField = value;
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

	public void ProcessData(uint SkinID)
	{
	}

	public void RequestSetSkyboardSkinID(uint skinID, bool autoRotate = false)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
