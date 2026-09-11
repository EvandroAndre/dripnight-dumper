using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class PlayDoubleAvatarAnimParams
{
	public class AvatarAnimParams
	{
		public List<uint> clothIDList;

		public int animID;

		public string specialAnim;

		public string idleAnim;

		public AvatarTransformInfo avatarInfo;

		public HashSet<uint> unlockClothEffectItemIDList;
	}

	public AvatarAnimParams avatarAnimParmsA;

	public AvatarAnimParams avatarAnimParmsB;

	public Vector3 cameraRotation;

	public bool inputDisable;
}
