using System.Collections.Generic;

namespace proto;

public class CSBatchGetProfileRes
{
	public List<AvatarProfileWithID> profiles;

	public List<AccountCollectionCustomItemInfoWithID> collection_customs;
}
