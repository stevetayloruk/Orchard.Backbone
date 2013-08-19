using Orchard.Localization;
using Orchard.UI.Navigation;

namespace Pluralsight.Movies {
    public class AdminMenu : INavigationProvider {
        public Localizer T { get; set; }

        public string MenuName {
            get { return "admin"; }
        }

        public void GetNavigation(NavigationBuilder builder) {
            builder.Add(T("Backbone Sample"), "5", BuildMenu);
        }

        private void BuildMenu(NavigationItemBuilder menu) {
            menu.Add(T("Backbone Sample"), "5", item =>
		        item.Action("Index", "ActorsAdmin", new { area = "Backbone.Sample" }));
        }
    }
}