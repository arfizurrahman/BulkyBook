using System;
using System.Collections.Generic;
using System.Text;
using Braintree;

namespace BulkyBook.Utility
{
    public interface IBrainTreeGate
    {
        IBraintreeGateway CreateGateway();
        IBraintreeGateway GetGateway();
    }
}
