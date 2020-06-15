using IdentityServer4;

namespace Domain.Models.Entities
{
    internal class User : IdentityServerUser
    {
        public User(string subjectId) : base(subjectId)
        {

        }

        public string PortalCode { get; set; }
    }
}