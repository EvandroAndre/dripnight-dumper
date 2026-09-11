using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

[Serializable]
public class FrontEndPreviewConfig : ScriptableObject
{
	[Serializable]
	public class PreviewOneConifg
	{
		public PreviewOneItem BagPack;

		public PreviewOneItem LootBox;

		public PreviewOneItem Parachute;

		public PreviewOneItem SkyBoard;

		public PreviewOneItem Weapon;

		public PreviewOneItem MeleeWeapon;

		public PreviewOneItem GrenadeWeapon;

		public PreviewOneItem VehicleSkin;

		public PreviewOneItem Camera;

		public PreviewOneItem RedEnvelope;

		public PreviewOneItem Pet;

		public PreviewOneItem Flight;

		public PreviewOneItem HyperBook;

		public PreviewOneItem IceWall;

		public PreviewOneItem SmokeGrenade;

		public PreviewOneItem FlyingKnife;

		public PreviewOneItem Emote;

		public PreviewOneItem HorseVehicle;

		public Dictionary<int, PreviewOneItem> PreviewOneItems;

		public Vector4 MiddlePoint;
	}

	[Serializable]
	public class PreviewOneItem
	{
		public FrontEndPreviewCameraType CameraType;

		public FrontEndPreviewComponent.CollectionPreviewType CollectionPreviewType;

		public Vector3 transfrom;

		public Vector3 rotation;

		public Vector3 scale;

		public int CameraFov;

		public bool NeedZoomIn;

		public bool SpecialViewPort;
	}

	public List<PreviewOneConifg> previewlist;

	public void Init()
	{
	}

	public PreviewOneConifg GetPreviewItemByIndex(int index)
	{
		return null;
	}

	public PreviewOneItem GetConfig(int index, FrontEndPreviewComponent.CollectionPreviewType collectionPreviewType)
	{
		return null;
	}
}
