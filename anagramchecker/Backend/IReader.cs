using System;
using System.Threading.Tasks;

namespace Backend
{
    public interface IReader
    {
        Task<string> ReadDictionary();
    }
}
