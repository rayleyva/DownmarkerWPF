﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarkPad.Contracts
{
	public interface IDocumentParser
	{
		string Parse(string source);
		string ParseClean(string source);
	}
}