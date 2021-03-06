﻿using System;
using Glimpse.Internal;

namespace Glimpse.Common
{
    public class DefaultGlimpseContextAccessor : IGlimpseContextAccessor
    {
        private readonly IContextData<MessageContext> _context;
        public DefaultGlimpseContextAccessor(IContextData<MessageContext> context)
        {
            _context = context;
        }

        public Guid RequestId => _context.Value.Id;
    }
}