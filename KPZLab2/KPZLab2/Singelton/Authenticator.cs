using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KPZLab2.Singelton
{
    public sealed class Authenticator
    {
        private static readonly Lazy<Authenticator> instance =
            new Lazy<Authenticator>(() => new Authenticator(), LazyThreadSafetyMode.ExecutionAndPublication);

        private Authenticator()
        {
        }

        public static Authenticator Instance
        {
            get { return instance.Value; }
        }

        public void Authenticate(string user, string password)
        {
            Console.WriteLine($"User '{user}' аутентифікований успішно.");
        }
    }
}
