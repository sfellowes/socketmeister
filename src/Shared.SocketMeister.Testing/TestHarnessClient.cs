﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Threading;

namespace SocketMeister.Testing
{
    /// <summary>
    /// Test Harness Client (SHARED)
    /// </summary>
    internal partial class TestHarnessClient
    {
        private int _clientId;
        private readonly object _lockClass = new object();

        public int ClientId
        {
            get { lock (_lockClass) { return _clientId; } }
            set { lock (_lockClass) { _clientId = value; } }
        }

        /// <summary>
        /// Lock to provide threadsafe operations
        /// </summary>
        public object LockClass {  get { return _lockClass; } }
    }
}
