using System.Collections.Generic;
using LitJson;
using message;

namespace COW.Gameplay.UGC;

public class UGCCustomLevelObjectEditorManifest
{
	public class ManifestData : ILibraryManifest, IStoreInfoManifest
	{
		private string _003CUUID_003Ek__BackingField;

		private List<ResPackage> _003CResPackages_003Ek__BackingField;

		private List<LibraryItem> _003CChildren_003Ek__BackingField;

		public PDNPIMFAGEN GameDataDownloadDesc;

		public Dictionary<string, ItemBytesInfo> ItemBytesInfoMapping;

		public string UUID
		{
			get
			{
				return _003CUUID_003Ek__BackingField;
			}
			set
			{
				_003CUUID_003Ek__BackingField = value;
			}
		}

		public List<ResPackage> ResPackages
		{
			get
			{
				return _003CResPackages_003Ek__BackingField;
			}
			set
			{
				_003CResPackages_003Ek__BackingField = value;
			}
		}

		public List<LibraryItem> Children
		{
			get
			{
				return _003CChildren_003Ek__BackingField;
			}
			set
			{
				_003CChildren_003Ek__BackingField = value;
			}
		}

		public bool FromJsonData()
		{
			return false;
		}

		private bool BuildDownloadDescList()
		{
			return false;
		}
	}

	public interface IStoreInfoManifest
	{
		string UUID { get; set; }
	}

	public interface ILibraryManifest : IStoreInfoManifest
	{
		List<ResPackage> ResPackages { get; set; }

		List<LibraryItem> Children { get; set; }
	}

	public enum PlatformMask
	{
		Android = 1,
		Ios = 2,
		Desktop = 4,
		Server = 8
	}

	public class ResPackage
	{
		private string _003CName_003Ek__BackingField;

		private string _003CUUID_003Ek__BackingField;

		private string _003CUseVersionMD5_003Ek__BackingField;

		private int _003CWhoRequire_003Ek__BackingField;

		private List<ResFile> _003CFileList_003Ek__BackingField;

		public string Name
		{
			get
			{
				return _003CName_003Ek__BackingField;
			}
			set
			{
				_003CName_003Ek__BackingField = value;
			}
		}

		public string UUID
		{
			get
			{
				return _003CUUID_003Ek__BackingField;
			}
			set
			{
				_003CUUID_003Ek__BackingField = value;
			}
		}

		public string UseVersionMD5
		{
			get
			{
				return _003CUseVersionMD5_003Ek__BackingField;
			}
			set
			{
				_003CUseVersionMD5_003Ek__BackingField = value;
			}
		}

		public int WhoRequire
		{
			get
			{
				return _003CWhoRequire_003Ek__BackingField;
			}
			set
			{
				_003CWhoRequire_003Ek__BackingField = value;
			}
		}

		public List<ResFile> FileList
		{
			get
			{
				return _003CFileList_003Ek__BackingField;
			}
			set
			{
				_003CFileList_003Ek__BackingField = value;
			}
		}
	}

	public class ResFile
	{
		private string _003CSubFileID_003Ek__BackingField;

		private string _003CSHA1_003Ek__BackingField;

		private int _003CFileSize_003Ek__BackingField;

		private string _003CURL_003Ek__BackingField;

		private int _003CPlatformRequireMask_003Ek__BackingField;

		public string SubFileID
		{
			get
			{
				return _003CSubFileID_003Ek__BackingField;
			}
			set
			{
				_003CSubFileID_003Ek__BackingField = value;
			}
		}

		public string SHA1
		{
			get
			{
				return _003CSHA1_003Ek__BackingField;
			}
			set
			{
				_003CSHA1_003Ek__BackingField = value;
			}
		}

		public int FileSize
		{
			get
			{
				return _003CFileSize_003Ek__BackingField;
			}
			set
			{
				_003CFileSize_003Ek__BackingField = value;
			}
		}

		public string URL
		{
			get
			{
				return _003CURL_003Ek__BackingField;
			}
			set
			{
				_003CURL_003Ek__BackingField = value;
			}
		}

		public int PlatformRequireMask
		{
			get
			{
				return _003CPlatformRequireMask_003Ek__BackingField;
			}
			set
			{
				_003CPlatformRequireMask_003Ek__BackingField = value;
			}
		}
	}

	public class LibraryItem
	{
		private string _003CName_003Ek__BackingField;

		private string _003CUUID_003Ek__BackingField;

		private string _003CType_003Ek__BackingField;

		private string _003CSubType_003Ek__BackingField;

		private string _003CPackageUUID_003Ek__BackingField;

		private List<string> _003CRelyOns_003Ek__BackingField;

		private string _003CAtlasUUID_003Ek__BackingField;

		private InfoHasItemBytes _003CInfo_003Ek__BackingField;

		private string _003CFileResource_003Ek__BackingField;

		private List<LibraryItem> _003CChildren_003Ek__BackingField;

		public string Name
		{
			get
			{
				return _003CName_003Ek__BackingField;
			}
			set
			{
				_003CName_003Ek__BackingField = value;
			}
		}

		public string UUID
		{
			get
			{
				return _003CUUID_003Ek__BackingField;
			}
			set
			{
				_003CUUID_003Ek__BackingField = value;
			}
		}

		public string Type
		{
			get
			{
				return _003CType_003Ek__BackingField;
			}
			set
			{
				_003CType_003Ek__BackingField = value;
			}
		}

		public string SubType
		{
			get
			{
				return _003CSubType_003Ek__BackingField;
			}
			set
			{
				_003CSubType_003Ek__BackingField = value;
			}
		}

		public string PackageUUID
		{
			get
			{
				return _003CPackageUUID_003Ek__BackingField;
			}
			set
			{
				_003CPackageUUID_003Ek__BackingField = value;
			}
		}

		public List<string> RelyOns
		{
			get
			{
				return _003CRelyOns_003Ek__BackingField;
			}
			set
			{
				_003CRelyOns_003Ek__BackingField = value;
			}
		}

		public string AtlasUUID
		{
			get
			{
				return _003CAtlasUUID_003Ek__BackingField;
			}
			set
			{
				_003CAtlasUUID_003Ek__BackingField = value;
			}
		}

		public InfoHasItemBytes Info
		{
			get
			{
				return _003CInfo_003Ek__BackingField;
			}
			set
			{
				_003CInfo_003Ek__BackingField = value;
			}
		}

		public string FileResource
		{
			get
			{
				return _003CFileResource_003Ek__BackingField;
			}
			set
			{
				_003CFileResource_003Ek__BackingField = value;
			}
		}

		public List<LibraryItem> Children
		{
			get
			{
				return _003CChildren_003Ek__BackingField;
			}
			set
			{
				_003CChildren_003Ek__BackingField = value;
			}
		}

		public bool FromJsonData(ManifestData context)
		{
			return false;
		}
	}

	public class InfoHasItemBytes
	{
		private ItemBytesInfo _003CItemByteInfo_003Ek__BackingField;

		public int width;

		public int height;

		public double timelength;

		public ItemBytesInfo ItemByteInfo
		{
			get
			{
				return _003CItemByteInfo_003Ek__BackingField;
			}
			set
			{
				_003CItemByteInfo_003Ek__BackingField = value;
			}
		}

		public bool FromJsonData(ManifestData context, string name)
		{
			return false;
		}
	}

	public class ItemBytesInfo
	{
		private string _003CBytesID_003Ek__BackingField;

		private int _003Cstatic_type_id_003Ek__BackingField;

		private string _003CUGCType_003Ek__BackingField;

		private string _003CUGCProps_003Ek__BackingField;

		private JsonData _003CRenderUnit_003Ek__BackingField;

		private JsonData _003CPropertyApplies_003Ek__BackingField;

		private string _003CCameraUnit_003Ek__BackingField;

		private RenderUnit m_RenderUnit;

		private PropertyApplies m_PropertyApplies;

		private string m_PrefabName;

		private int _003CEntityKeyword_003Ek__BackingField;

		public string BytesID
		{
			get
			{
				return _003CBytesID_003Ek__BackingField;
			}
			set
			{
				_003CBytesID_003Ek__BackingField = value;
			}
		}

		public int static_type_id
		{
			get
			{
				return _003Cstatic_type_id_003Ek__BackingField;
			}
			set
			{
				_003Cstatic_type_id_003Ek__BackingField = value;
			}
		}

		public string UGCType
		{
			get
			{
				return _003CUGCType_003Ek__BackingField;
			}
			set
			{
				_003CUGCType_003Ek__BackingField = value;
			}
		}

		public string UGCProps
		{
			get
			{
				return _003CUGCProps_003Ek__BackingField;
			}
			set
			{
				_003CUGCProps_003Ek__BackingField = value;
			}
		}

		public JsonData RenderUnit
		{
			get
			{
				return _003CRenderUnit_003Ek__BackingField;
			}
			set
			{
				_003CRenderUnit_003Ek__BackingField = value;
			}
		}

		public JsonData PropertyApplies
		{
			get
			{
				return _003CPropertyApplies_003Ek__BackingField;
			}
			set
			{
				_003CPropertyApplies_003Ek__BackingField = value;
			}
		}

		public string CameraUnit
		{
			get
			{
				return _003CCameraUnit_003Ek__BackingField;
			}
			set
			{
				_003CCameraUnit_003Ek__BackingField = value;
			}
		}

		public int EntityKeyword
		{
			get
			{
				return _003CEntityKeyword_003Ek__BackingField;
			}
			set
			{
				_003CEntityKeyword_003Ek__BackingField = value;
			}
		}

		public RenderUnit GetRenderUnit()
		{
			return null;
		}

		public PropertyApplies GetPropertyApplies()
		{
			return null;
		}

		public string GetPrefabName()
		{
			return null;
		}

		public bool FromJsonData(ManifestData context, string name)
		{
			return false;
		}
	}

	public class RenderUnit
	{
		private string _003CType_003Ek__BackingField;

		private string _003CID_003Ek__BackingField;

		private Vector3Double _003CPosition_003Ek__BackingField;

		private Vector3Double _003CRotation_003Ek__BackingField;

		private Vector3Double _003CScale_003Ek__BackingField;

		private List<JsonData> _003CChildren_003Ek__BackingField;

		private List<RenderUnit> _003CChildrenRenderUnit_003Ek__BackingField;

		public string Type
		{
			get
			{
				return _003CType_003Ek__BackingField;
			}
			set
			{
				_003CType_003Ek__BackingField = value;
			}
		}

		public string ID
		{
			get
			{
				return _003CID_003Ek__BackingField;
			}
			set
			{
				_003CID_003Ek__BackingField = value;
			}
		}

		public Vector3Double Position
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

		public Vector3Double Rotation
		{
			get
			{
				return _003CRotation_003Ek__BackingField;
			}
			set
			{
				_003CRotation_003Ek__BackingField = value;
			}
		}

		public Vector3Double Scale
		{
			get
			{
				return _003CScale_003Ek__BackingField;
			}
			set
			{
				_003CScale_003Ek__BackingField = value;
			}
		}

		public List<JsonData> Children
		{
			get
			{
				return _003CChildren_003Ek__BackingField;
			}
			set
			{
				_003CChildren_003Ek__BackingField = value;
			}
		}

		public List<RenderUnit> ChildrenRenderUnit
		{
			get
			{
				return _003CChildrenRenderUnit_003Ek__BackingField;
			}
			set
			{
				_003CChildrenRenderUnit_003Ek__BackingField = value;
			}
		}

		public virtual bool FromJsonData()
		{
			return false;
		}

		public static bool BuildRenderUnit(JsonData jsonData, out RenderUnit renderUnit)
		{
			renderUnit = null;
			return false;
		}
	}

	public class TreeRenderUnit : RenderUnit
	{
	}

	public class MeshRenderUnit : RenderUnit
	{
		private string _003CMeshID_003Ek__BackingField;

		private List<string> _003CMaterials_003Ek__BackingField;

		private string _003CColliderID_003Ek__BackingField;

		public string MeshID
		{
			get
			{
				return _003CMeshID_003Ek__BackingField;
			}
			set
			{
				_003CMeshID_003Ek__BackingField = value;
			}
		}

		public List<string> Materials
		{
			get
			{
				return _003CMaterials_003Ek__BackingField;
			}
			set
			{
				_003CMaterials_003Ek__BackingField = value;
			}
		}

		public string ColliderID
		{
			get
			{
				return _003CColliderID_003Ek__BackingField;
			}
			set
			{
				_003CColliderID_003Ek__BackingField = value;
			}
		}
	}

	public class AvatarRenderUnit : RenderUnit
	{
		private string _003CUUID_003Ek__BackingField;

		public string UUID
		{
			get
			{
				return _003CUUID_003Ek__BackingField;
			}
			set
			{
				_003CUUID_003Ek__BackingField = value;
			}
		}
	}

	public class SimpleRenderUnit : RenderUnit
	{
		private string _003CResourceID_003Ek__BackingField;

		public string ResourceID
		{
			get
			{
				return _003CResourceID_003Ek__BackingField;
			}
			set
			{
				_003CResourceID_003Ek__BackingField = value;
			}
		}
	}

	public class ItemRenderUnit : RenderUnit
	{
		private int _003CItemID_003Ek__BackingField;

		private string _003CSurfaceTex_003Ek__BackingField;

		private string _003CBorderTex_003Ek__BackingField;

		private int _003CSurfaceColor_003Ek__BackingField;

		private int _003CBorderColor_003Ek__BackingField;

		public int ItemID
		{
			get
			{
				return _003CItemID_003Ek__BackingField;
			}
			set
			{
				_003CItemID_003Ek__BackingField = value;
			}
		}

		public string SurfaceTex
		{
			get
			{
				return _003CSurfaceTex_003Ek__BackingField;
			}
			set
			{
				_003CSurfaceTex_003Ek__BackingField = value;
			}
		}

		public string BorderTex
		{
			get
			{
				return _003CBorderTex_003Ek__BackingField;
			}
			set
			{
				_003CBorderTex_003Ek__BackingField = value;
			}
		}

		public int SurfaceColor
		{
			get
			{
				return _003CSurfaceColor_003Ek__BackingField;
			}
			set
			{
				_003CSurfaceColor_003Ek__BackingField = value;
			}
		}

		public int BorderColor
		{
			get
			{
				return _003CBorderColor_003Ek__BackingField;
			}
			set
			{
				_003CBorderColor_003Ek__BackingField = value;
			}
		}
	}

	public class CameraRenderUnit : RenderUnit
	{
		private int _003CProjectionMode_003Ek__BackingField;

		private float _003CFov_003Ek__BackingField;

		private float _003COrthoSize_003Ek__BackingField;

		public int ProjectionMode
		{
			get
			{
				return _003CProjectionMode_003Ek__BackingField;
			}
			set
			{
				_003CProjectionMode_003Ek__BackingField = value;
			}
		}

		public float Fov
		{
			get
			{
				return _003CFov_003Ek__BackingField;
			}
			set
			{
				_003CFov_003Ek__BackingField = value;
			}
		}

		public float OrthoSize
		{
			get
			{
				return _003COrthoSize_003Ek__BackingField;
			}
			set
			{
				_003COrthoSize_003Ek__BackingField = value;
			}
		}
	}

	public class BatchCombineRenderUnit : RenderUnit
	{
		private string _003CResourceID_003Ek__BackingField;

		public string ResourceID
		{
			get
			{
				return _003CResourceID_003Ek__BackingField;
			}
			set
			{
				_003CResourceID_003Ek__BackingField = value;
			}
		}
	}

	public class PropertyApplies
	{
		public class ApplyTarget
		{
			public string RenderUnitID;

			public string RenderUnitPropertyReference;

			public string EntityType;

			public string EntityPropertyName;
		}

		public Dictionary<string, List<ApplyTarget>> ApplyTargets;

		public static bool BuildPropertyApplies(JsonData jsonData, out PropertyApplies propertyApplies)
		{
			propertyApplies = null;
			return false;
		}
	}
}
