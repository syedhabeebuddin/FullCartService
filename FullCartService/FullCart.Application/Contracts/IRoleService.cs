using FullCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCart.Application.Contracts
{
    public interface IRoleService
    {
        Task<Role> AddRole(Role role);
    }
}
