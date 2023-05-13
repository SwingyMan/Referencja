using BlazorApp2.Client.Pages;
using BlazorApp2.Server.Models;

namespace BlazorApp2.Server.Services
{
    public class MembersService : IMembersService
    {
        public Task<List<Member>> Show()
        {
            var list = new List<Member>() { 
            new Member("Kuba","x","Amfibia","RMS","Informatyka",String.Empty),
            new Member("Maricn","x","Backend","RMS","Informatyka",String.Empty)
            };
            return Task.FromResult(list);
        }
        public MembersService() { }
    }
}
