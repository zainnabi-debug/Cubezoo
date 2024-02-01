using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cubezoo_Interface.IUserDirectory
{
    public interface IUserDirectory
    {
        Task<List<Cubezoo_Models.DTO.UserDirectory>> GetUserDirectoriesAsync();
    }
}
