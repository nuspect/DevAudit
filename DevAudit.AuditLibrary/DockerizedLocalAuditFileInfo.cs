﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Alpheus.IO;

namespace DevAudit.AuditLibrary
{
    public class DockerizedLocalAuditFileInfo : LocalAuditFileInfo
    {
        #region Constructors
        public DockerizedLocalAuditFileInfo(DockerizedLocalEnvironment env, string file_path) : base(env, "/hostroot" + file_path){}
        #endregion


    }
}