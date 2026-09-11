using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_DirectionRulerController : UIHUDUGC_InternalHudController
{
	private enum AngleDirection
	{
		N = 0,
		NE = 45,
		E = 90,
		SE = 135,
		S = 180,
		SW = 225,
		W = 270,
		NW = 315
	}

	public class TagMarkInfo
	{
		private UISprite m_Sprite;

		private Transform m_LeftArrow;

		private Vector3 _003CPosition_003Ek__BackingField;

		private BHGGAEEHJCO _003CPlayerID_003Ek__BackingField;

		public Vector3 Position
		{
			get
			{
				return _003CPosition_003Ek__BackingField;
			}
			set
			{
				_003CPosition_003Ek__BackingField = value;
			}
		}

		public BHGGAEEHJCO PlayerID
		{
			get
			{
				return _003CPlayerID_003Ek__BackingField;
			}
			set
			{
				_003CPlayerID_003Ek__BackingField = value;
			}
		}

		public UISprite Sprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform LeftArrow => null;
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public Vector3 playerOff;

		internal int _003CUpdateTargetIcons_003Eb__0(TagMarkInfo x, TagMarkInfo y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public BHGGAEEHJCO playerId;

		internal bool _003CShowTagMark_003Eb__0(TagMarkInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public Vector3 playerOff;

		internal int _003CUpdateTagMark_003Eb__0(TagMarkInfo x, TagMarkInfo y)
		{
			return 0;
		}
	}

	private const int m_AngleInterval = 15;

	private const float m_RulerLength = 432f;

	private readonly Vector3 m_HideMarkPosition;

	private UIHUDUGC_DirectionRulerView m_View;

	private UGCDirectionRulerHudRepItem m_RepItem;

	private UGCEntityDataStore m_DateStore;

	private readonly Queue<UISprite> m_IconPool;

	private readonly Queue<UISprite> m_TagPool;

	private readonly Dictionary<int, string> m_ScaleStringDict;

	private readonly Dictionary<int, TagMarkInfo> m_StaticIcons;

	private readonly Dictionary<GameObject, TagMarkInfo> m_TargetIcons;

	private readonly List<TagMarkInfo> m_TagMarkInfos;

	private Transform m_Recycle;

	private UILabel[] m_ScaleValues;

	private float m_ScaleDisDelta;

	private int m_NumScaleInternal;

	private float m_StepPerAngle;

	private float m_RulerPosY;

	private float m_Ruler1PosX;

	private float m_Ruler2PosX;

	private float m_MarkPosY;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void InitAngleScale()
	{
	}

	private void Update()
	{
	}

	private float GetRotationAngleFromView(Player player)
	{
		return 0f;
	}

	private float GetFinalRulerScaleByVector3(Vector3 v)
	{
		return 0f;
	}

	private int FixAngle(int angle)
	{
		return 0;
	}

	private UISprite GetIcon()
	{
		return null;
	}

	private UISprite GetTag()
	{
		return null;
	}

	private void ReleaseIcon(UISprite icon)
	{
	}

	private void ReleaseTag(UISprite tag)
	{
	}

	private void UpdateTargetIcons(float rulerPosX, int startDirection, Player player)
	{
	}

	private void UpdateMarkUI(int startDirection, Vector3 markPos, Transform markSprite, Player player, float posY, bool forceShow = false)
	{
	}

	private void ShowTagMark(Vector3 pos, int teamIndex, BHGGAEEHJCO playerId)
	{
	}

	private void RemoveTagMark(BHGGAEEHJCO playerID)
	{
	}

	private void UpdateTagMark(float rulerPosX, int startDirection, Player player)
	{
	}

	private void ClipTagMark(TagMarkInfo tag)
	{
	}

	private void OnRemoveMapMark(object[] data)
	{
	}

	private void OnUpdateMapMark(object[] data)
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnShowTagChange(bool cur)
	{
	}

	private void OnTargetIconsChanged(Dictionary<object, object> value)
	{
	}

	private void OnTargetIconColorsChanged(Dictionary<object, object> value)
	{
	}

	private void OnStaticIconsChanged(Dictionary<object, object> value)
	{
	}

	private void OnStaticIconColorsChanged(Dictionary<object, object> value)
	{
	}

	private void UpdateStaticIcons(float rulerPosX, int startDirection, Player player)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
