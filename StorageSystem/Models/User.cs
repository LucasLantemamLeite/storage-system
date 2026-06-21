using StorageSystem.Enums;
using StorageSystem.Shared.Base;

namespace StorageSystem.Models;

public sealed class User : Entity
{
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public string Password { get; private set; }
    public Role Role { get; private set; }
    public Guid CompanyId { get; }
    
    public User(string email, string phone, string password, Role role,Guid companyId, string name) : base(name)
    {
        Email = email;
        Phone = phone;
        Password = password;
        Role = role;
        CompanyId = companyId;
    }

    public User(string email, string phone, string password, Role role, Guid companyId,
        Guid id, string name, DateTime created, DateTime updated, bool active) : base(id, name, created, updated, active)
    {
        Email = email;
        Phone = phone;
        Password = password;
        Role = role;
        CompanyId = companyId;
    }
}