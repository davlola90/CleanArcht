using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Core.Events
{
    public abstract class Message:IRequest<bool>
    {
        public string MessageType { get; protected set; }
        public Message()
        {
            MessageType = GetType().Name;
        }
    }
}
