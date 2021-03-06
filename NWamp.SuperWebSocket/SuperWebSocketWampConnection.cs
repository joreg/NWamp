﻿using SuperWebSocket;
using NWamp.Transport;

namespace NWamp
{
    /// <summary>
    /// Implementation of <see cref="IWampConnection"/> interface using Alchemy web sockets.
    /// </summary>
    public class SuperWebSocketWampConnection : IWampConnection
    {
        /// <summary>
        /// Alchemy web socket client context.
        /// </summary>
        private readonly WebSocketSession _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlchemyWampConnection"/> class.
        /// </summary>
        /// <param name="userContext">Alchemy web socket client context</param>
        public SuperWebSocketWampConnection(WebSocketSession userContext)
        {
            _context = userContext;
        }

        /// <summary>
        /// Gets alchemy user context for current connection.
        /// </summary>
        public WebSocketSession Context { get { return _context; } }

        /// <summary>
        /// Sends a JSON string to throug current connection to target client.
        /// </summary>
        /// <param name="json">JSON string</param>
        public void Send(string json)
        {
            _context.Send(json);
        }

        /// <summary>
        /// Disposes current client connection
        /// </summary>
        public void Dispose()
        {
//            _context.OnDisconnect();
        }
    }
}
