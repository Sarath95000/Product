using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProduct.Users.Initializers
{
    interface Initializer
    {
        List<User> InitializeUserDefaultValues(List<User> userList);
    }
}
