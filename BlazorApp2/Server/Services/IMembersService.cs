using BlazorApp2.Client.Pages;
using BlazorApp2.Server.Models;

namespace BlazorApp2.Server.Services
{
    public interface IMembersService
    {
        public Task<List<Member>> Show();
    }
}
