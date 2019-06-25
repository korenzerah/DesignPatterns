using DesignPatterns.facade.interfaces;
using DesignPatterns.facade.proxies;

namespace DesignPatterns.facade
{
    public static class LoginFactory
    {
        public static IUserProxy LoginToFacadeSystem(string pwd) {
            switch(pwd) {                
                case("koren"): {
                    return new CustomerFacadeProxy();
                }
                case("elal"): {
                    return new CompanyFacadeProxy();
                }
                default: {
                    return new AnonymousFacadeProxy();
                }
            }
        }
    }
}