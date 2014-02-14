using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace TreeHash
{
	public interface IHashAlgorithmFactory
	{
		HashAlgorithm GetHashAlgorithm();
	}
}
